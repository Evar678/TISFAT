﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TISFAT.Entities;
using TISFAT.Util;

namespace TISFAT
{
    public partial class MainForm : Form
    {
        #region Properties
        public Project ActiveProject;
        private string ProjectFileName;
        private bool ProjectDirty;

        public CanvasForm Canvas;
        public Timeline MainTimeline;
        public ToolboxForm Toolbox;

        private static Random Why = new Random();

        public int HScrollVal
        {
            get { return scrl_HTimeline.Value; }
        }

        public bool HScrollVisible { get { return scrl_HTimeline.Visible; } }

        public int VScrollVal
        {
            get { return scrl_VTimeline.Value; }
        }
        #endregion

        public bool VScrollVisible { get { return scrl_VTimeline.Visible; } }

        public MainForm()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            GLContext.VSync = true;
            GLContext.KeyPress += MainForm_KeyPress;
            GLContext.MouseWheel += GLContext_MouseWheel;

            #region General Init
            // Create and show forms
            Canvas = new CanvasForm(sc_MainContainer.Panel2);
            Canvas.Show();

            MainTimeline = new Timeline(GLContext);

            Toolbox = new ToolboxForm(sc_MainContainer.Panel2);
            Toolbox.Show();

            ProjectNew();
            AddTestLayer();
            AddTestLayer();
            #endregion
        }

        private void GLContext_MouseWheel(object sender, MouseEventArgs e)
        {
            ScrollBar bar = scrl_VTimeline;

            if (ModifierKeys == Keys.Shift)
                bar = scrl_HTimeline;

            if (!bar.Visible)
                return;

            int scrollAmount = bar.SmallChange * -(e.Delta / 100);

            if (bar.Value + scrollAmount > 1 + bar.Maximum - bar.LargeChange)
                bar.Value = 1 + bar.Maximum - bar.LargeChange;
            else if (bar.Value + scrollAmount < bar.Minimum)
                bar.Value = bar.Minimum;
            else
                bar.Value += scrollAmount;

            MainTimeline.GLContext.Invalidate();
        }

        public void CalcScrollBars(int HContentSize, int VContentSize, int HViewSize, int VViewSize)
        {
            scrl_HTimeline.Visible = HViewSize < HContentSize;
            scrl_VTimeline.Visible = VViewSize < VContentSize;

            if (scrl_HTimeline.Visible)
            {
                scrl_HTimeline.Minimum = 0;

                scrl_HTimeline.SmallChange = HViewSize / 10;
                scrl_HTimeline.LargeChange = HViewSize / 5;

                scrl_HTimeline.Maximum = HContentSize - HViewSize;
                scrl_HTimeline.Maximum += scrl_HTimeline.LargeChange;
            }
            if (scrl_VTimeline.Visible)
            {
                scrl_VTimeline.Minimum = 0;

                scrl_VTimeline.SmallChange = VViewSize / 10;
                scrl_VTimeline.LargeChange = VViewSize / 5;

                scrl_VTimeline.Maximum = VContentSize - VViewSize;
                scrl_VTimeline.Maximum += scrl_VTimeline.LargeChange;
            }

            if (!scrl_HTimeline.Visible)
                scrl_HTimeline.Value = 0;
            if (!scrl_VTimeline.Visible)
                scrl_VTimeline.Value = 0;

            pnl_ScrollSquare.Visible = scrl_HTimeline.Visible || scrl_VTimeline.Visible;
        }

        private void AddTestLayer()
        {
            StickFigure figure = new StickFigure();

            var hip = new StickFigure.Joint();
            hip.Location = new PointF(200, 200);
            figure.Root = hip;
            var shoulder = StickFigure.Joint.RelativeTo(hip, new PointF(0, -53));
            var lElbow = StickFigure.Joint.RelativeTo(shoulder, new PointF(-21, 22));
            var lHand = StickFigure.Joint.RelativeTo(lElbow, new PointF(-5, 35));
            var rElbow = StickFigure.Joint.RelativeTo(shoulder, new PointF(21, 22));
            var rHand = StickFigure.Joint.RelativeTo(rElbow, new PointF(5, 35));
            var lKnee = StickFigure.Joint.RelativeTo(hip, new PointF(-16, 33));
            var lFoot = StickFigure.Joint.RelativeTo(lKnee, new PointF(-5, 41));
            var rKnee = StickFigure.Joint.RelativeTo(hip, new PointF(16, 33));
            var rFoot = StickFigure.Joint.RelativeTo(rKnee, new PointF(5, 41));
            var head = StickFigure.Joint.RelativeTo(shoulder, new PointF(0, -36));

            shoulder.HandleColor = Color.Yellow;
            hip.HandleColor = Color.Yellow;
            rElbow.HandleColor = Color.Red;
            rHand.HandleColor = Color.Red;
            rKnee.HandleColor = Color.Red;
            rFoot.HandleColor = Color.Red;

            head.HandleColor = Color.Yellow;
            head.IsCircle = true;

            Layer layer = new Layer(figure);
            layer.Framesets.Add(new Frameset());
            layer.Framesets[0].Keyframes.Add(new Keyframe(0, figure.CreateRefState()));
            layer.Framesets[0].Keyframes.Add(new Keyframe(20, figure.CreateRefState()));

            ActiveProject.Layers.Add(layer);
            MainTimeline.GLContext.Invalidate();
        }

        public void SetDirty(bool dirty)
        {
            ProjectDirty = dirty;
            Text = "TISFAT Zero - " + (Path.GetFileNameWithoutExtension(ProjectFileName) ?? "Untitled") + (dirty ? " *" : "");
        }

        private void SetFileName(string filename)
        {
            ProjectFileName = filename;
            SetDirty(filename == null);
        }

        #region MainForm Hooks
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (MainTimeline != null)
            {
                MainTimeline.GLContext_Init();
                MainTimeline.Resize();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.Resize();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Q)
                MainTimeline.SeekStart();

            if (e.KeyChar == (char)Keys.Space)
                btn_PlayPause_Click(null, null);
        }
        #endregion

        #region GLContext <-> Timeline hooks
        private void sc_MainContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.Resize();
        }

        private void GLContext_Paint(object sender, PaintEventArgs e)
        {
            if (MainTimeline == null)
                return;

            MainTimeline.GLContext_Paint(sender, e);

            if (MainTimeline.IsPlaying())
                MainTimeline.GLContext.Invalidate();
        }

        private void GLContext_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.MouseMoved(e.Location);
        }

        private void GLContext_MouseLeave(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.MouseLeft();
        }

        private void GLContext_MouseDown(object sender, MouseEventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.MouseDown(e.Location, e.Button);
        }

        private void GLContext_MouseUp(object sender, MouseEventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.MouseUp(e.Location, e.Button);
        }
        #endregion

        #region File Saving / Loading
        public void ProjectNew()
        {
            ActiveProject = new Project();
            SetFileName(null);
            MainTimeline.GLContext.Invalidate();
        }

        public void ProjectOpen(string filename)
        {
            if (MainTimeline == null)
                return;

            ActiveProject = new Project();

            using (var reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
            {
                UInt16 version = reader.ReadUInt16();
                ActiveProject.Read(reader, version);
            }

            SetFileName(filename);
            MainTimeline.GLContext.Invalidate();
        }

        public void ProjectSave(string filename)
        {
            if (MainTimeline == null)
                return;

            using (var writer = new BinaryWriter(new FileStream(filename, FileMode.Create)))
            {
                writer.Write(FileFormat.Version);
                ActiveProject.Write(writer);
            }

            SetFileName(filename);
            ProjectFileName = filename;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectNew();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "TISFAT Zero Project|*.tzp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ProjectOpen(dialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProjectFileName != null)
                ProjectSave(ProjectFileName);
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "TISFAT Zero Project|*.tzp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ProjectSave(dialog.FileName);
            }
        }
        #endregion

        #region Timeline Control Hooks
        private void btn_PlayPause_MouseEnter(object sender, EventArgs e)
        {
            btn_PlayPause.Image = MainTimeline.IsPlaying() ? Properties.Resources.pause_hover : Properties.Resources.play_hover;
        }

        private void btn_PlayPause_MouseLeave(object sender, EventArgs e)
        {
            btn_PlayPause.Image = MainTimeline.IsPlaying() ? Properties.Resources.pause_normal : Properties.Resources.play_normal;
        }

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (MainTimeline == null)
                return;

            MainTimeline.TogglePause();
            btn_PlayPause.Image = MainTimeline.IsPlaying() ? Properties.Resources.pause_hover : Properties.Resources.play_hover;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.SeekStart();
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.SeekLastFrame();
        }
        #endregion

        #region Live update view when splitter is moved
        private void sc_MainContainer_MouseDown(object sender, MouseEventArgs e)
        {
            // This disables the normal move behavior
            ((SplitContainer)sender).IsSplitterFixed = true;
        }

        private void sc_MainContainer_MouseUp(object sender, MouseEventArgs e)
        {
            // This allows the splitter to be moved normally again
            ((SplitContainer)sender).IsSplitterFixed = false;
        }

        private void sc_MainContainer_MouseMove(object sender, MouseEventArgs e)
        {
            // Check to make sure the splitter won't be updated by the
            // normal move behavior also
            if (((SplitContainer)sender).IsSplitterFixed)
            {
                // Make sure that the button used to move the splitter
                // is the left mouse button
                if (e.Button.Equals(MouseButtons.Left))
                {
                    // Checks to see if the splitter is aligned Vertically
                    if (((SplitContainer)sender).Orientation.Equals(Orientation.Vertical))
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.X > 0 && e.X < ((SplitContainer)sender).Width)
                        {
                            // Move the splitter
                            ((SplitContainer)sender).SplitterDistance = e.X;
                        }
                    }
                    // If it isn't aligned vertically then it must be
                    // horizontal
                    else
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.Y > 0 && e.Y < ((SplitContainer)sender).Height)
                        {
                            // Move the splitter
                            ((SplitContainer)sender).SplitterDistance = e.Y;
                        }
                    }
                }
                // If a button other than left is pressed or no button
                // at all
                else
                {
                    // This allows the splitter to be moved normally again
                    ((SplitContainer)sender).IsSplitterFixed = false;
                }
            }
        }
        #endregion

        private void scrl_Timeline_Scroll(object sender, ScrollEventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.GLContext.Invalidate();
        }

        public void ShowCxtMenu(Point Location, int FrameType, int FrameIndex)
        {
            // FrameTypes
            // 0 - Null Frame
            // 1 - Blank Frame
            // 2 - Key Frame

            insertKeyframeToolStripMenuItem.Visible = FrameType == 1 || FrameType == 2;
            insertKeyframeToolStripMenuItem.Enabled = FrameType == 1;

            removeKeyframeToolStripMenuItem.Visible = FrameType == 1 || FrameType == 2;
            removeKeyframeToolStripMenuItem.Enabled = !insertKeyframeToolStripMenuItem.Enabled;
            if (MainTimeline.SelectedFrameset != null && FrameType == 2)
                removeKeyframeToolStripMenuItem.Enabled = FrameIndex != MainTimeline.SelectedFrameset.StartTime && FrameIndex != MainTimeline.SelectedFrameset.EndTime;

            insertFramesetToolStripMenuItem.Visible = FrameType == 0;
            // TODO: Disable insert frameset if there's not enough space to create a new frameset

            removeFramesetToolStripMenuItem.Visible = FrameType == 1 || FrameType == 2;
            removeFramesetToolStripMenuItem.Enabled = MainTimeline.SelectedLayer.Framesets.Count > 1;

            toolStripSeparator4.Visible = FrameType != 0;

            moveLayerUpToolStripMenuItem.Enabled = Program.Form.ActiveProject.Layers.IndexOf(MainTimeline.SelectedLayer) > 0;
            moveLayerDownToolStripMenuItem.Enabled = Program.Form.ActiveProject.Layers.IndexOf(MainTimeline.SelectedLayer) < ActiveProject.Layers.Count;

            cxtm_Timeline.Show(GLContext, Location);
        }

        private void insertKeyframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.InsertKeyframe();
        }

        private void removeKeyframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.RemoveKeyframe();
        }

        private void moveLayerUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.MoveLayerUp();
        }

        private void moveLayerDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.MoveLayerDown();
        }

        private void removeLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTimeline != null)
                MainTimeline.RemoveLayer();
        }
    }
}
