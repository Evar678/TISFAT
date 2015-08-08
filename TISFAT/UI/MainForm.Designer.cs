﻿namespace TISFAT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sc_MainContainer = new System.Windows.Forms.SplitContainer();
            this.pnl_ScrollSquare = new System.Windows.Forms.Panel();
            this.scrl_VTimeline = new System.Windows.Forms.VScrollBar();
            this.scrl_HTimeline = new System.Windows.Forms.HScrollBar();
            this.pnl_ToolboxPanel = new System.Windows.Forms.Panel();
            this.btn_Rewind = new System.Windows.Forms.Button();
            this.btn_FastForward = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.GLContext = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animatedGifgifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxtm_Timeline = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertKeyframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeKeyframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLayerUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLayerDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gotoFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.removeFramesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertFramesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.sc_MainContainer)).BeginInit();
            this.sc_MainContainer.Panel1.SuspendLayout();
            this.sc_MainContainer.SuspendLayout();
            this.pnl_ToolboxPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cxtm_Timeline.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_MainContainer
            // 
            this.sc_MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc_MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc_MainContainer.Location = new System.Drawing.Point(0, 24);
            this.sc_MainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.sc_MainContainer.Name = "sc_MainContainer";
            this.sc_MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_MainContainer.Panel1
            // 
            this.sc_MainContainer.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sc_MainContainer.Panel1.Controls.Add(this.pnl_ScrollSquare);
            this.sc_MainContainer.Panel1.Controls.Add(this.scrl_VTimeline);
            this.sc_MainContainer.Panel1.Controls.Add(this.scrl_HTimeline);
            this.sc_MainContainer.Panel1.Controls.Add(this.pnl_ToolboxPanel);
            this.sc_MainContainer.Panel1.Controls.Add(this.GLContext);
            this.sc_MainContainer.Panel1MinSize = 130;
            // 
            // sc_MainContainer.Panel2
            // 
            this.sc_MainContainer.Panel2.AutoScroll = true;
            this.sc_MainContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sc_MainContainer.Size = new System.Drawing.Size(752, 517);
            this.sc_MainContainer.SplitterDistance = 181;
            this.sc_MainContainer.SplitterWidth = 2;
            this.sc_MainContainer.TabIndex = 0;
            this.sc_MainContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_MainContainer_SplitterMoved);
            this.sc_MainContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sc_MainContainer_MouseDown);
            this.sc_MainContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sc_MainContainer_MouseMove);
            this.sc_MainContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sc_MainContainer_MouseUp);
            // 
            // pnl_ScrollSquare
            // 
            this.pnl_ScrollSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ScrollSquare.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_ScrollSquare.Location = new System.Drawing.Point(734, 132);
            this.pnl_ScrollSquare.Name = "pnl_ScrollSquare";
            this.pnl_ScrollSquare.Size = new System.Drawing.Size(17, 17);
            this.pnl_ScrollSquare.TabIndex = 4;
            // 
            // scrl_VTimeline
            // 
            this.scrl_VTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrl_VTimeline.LargeChange = 1;
            this.scrl_VTimeline.Location = new System.Drawing.Point(734, 0);
            this.scrl_VTimeline.Maximum = 0;
            this.scrl_VTimeline.Name = "scrl_VTimeline";
            this.scrl_VTimeline.Size = new System.Drawing.Size(17, 132);
            this.scrl_VTimeline.TabIndex = 3;
            this.scrl_VTimeline.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrl_Timeline_Scroll);
            // 
            // scrl_HTimeline
            // 
            this.scrl_HTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrl_HTimeline.LargeChange = 1;
            this.scrl_HTimeline.Location = new System.Drawing.Point(-1, 132);
            this.scrl_HTimeline.Maximum = 0;
            this.scrl_HTimeline.Name = "scrl_HTimeline";
            this.scrl_HTimeline.Size = new System.Drawing.Size(735, 17);
            this.scrl_HTimeline.TabIndex = 2;
            this.scrl_HTimeline.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrl_Timeline_Scroll);
            // 
            // pnl_ToolboxPanel
            // 
            this.pnl_ToolboxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ToolboxPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_ToolboxPanel.Controls.Add(this.btn_Rewind);
            this.pnl_ToolboxPanel.Controls.Add(this.btn_FastForward);
            this.pnl_ToolboxPanel.Controls.Add(this.btn_End);
            this.pnl_ToolboxPanel.Controls.Add(this.btn_Start);
            this.pnl_ToolboxPanel.Controls.Add(this.btn_PlayPause);
            this.pnl_ToolboxPanel.Location = new System.Drawing.Point(0, 149);
            this.pnl_ToolboxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ToolboxPanel.Name = "pnl_ToolboxPanel";
            this.pnl_ToolboxPanel.Size = new System.Drawing.Size(750, 30);
            this.pnl_ToolboxPanel.TabIndex = 1;
            // 
            // btn_Rewind
            // 
            this.btn_Rewind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Rewind.FlatAppearance.BorderSize = 0;
            this.btn_Rewind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Rewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rewind.Image = global::TISFAT.Properties.Resources.rewind_normal;
            this.btn_Rewind.Location = new System.Drawing.Point(303, 3);
            this.btn_Rewind.Name = "btn_Rewind";
            this.btn_Rewind.Size = new System.Drawing.Size(24, 24);
            this.btn_Rewind.TabIndex = 5;
            this.btn_Rewind.UseVisualStyleBackColor = true;
            // 
            // btn_FastForward
            // 
            this.btn_FastForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FastForward.FlatAppearance.BorderSize = 0;
            this.btn_FastForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_FastForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_FastForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FastForward.Image = global::TISFAT.Properties.Resources.forward_normal;
            this.btn_FastForward.Location = new System.Drawing.Point(423, 3);
            this.btn_FastForward.Name = "btn_FastForward";
            this.btn_FastForward.Size = new System.Drawing.Size(24, 24);
            this.btn_FastForward.TabIndex = 4;
            this.btn_FastForward.UseVisualStyleBackColor = true;
            // 
            // btn_End
            // 
            this.btn_End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_End.FlatAppearance.BorderSize = 0;
            this.btn_End.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_End.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_End.Image = global::TISFAT.Properties.Resources.seek_end;
            this.btn_End.Location = new System.Drawing.Point(393, 3);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(24, 24);
            this.btn_End.TabIndex = 3;
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Image = global::TISFAT.Properties.Resources.seek_start;
            this.btn_Start.Location = new System.Drawing.Point(333, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(24, 24);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.btn_PlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.Image = global::TISFAT.Properties.Resources.play_normal;
            this.btn_PlayPause.Location = new System.Drawing.Point(363, 3);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(24, 24);
            this.btn_PlayPause.TabIndex = 1;
            this.btn_PlayPause.UseVisualStyleBackColor = true;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            this.btn_PlayPause.MouseEnter += new System.EventHandler(this.btn_PlayPause_MouseEnter);
            this.btn_PlayPause.MouseLeave += new System.EventHandler(this.btn_PlayPause_MouseLeave);
            // 
            // GLContext
            // 
            this.GLContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GLContext.BackColor = System.Drawing.Color.Black;
            this.GLContext.Location = new System.Drawing.Point(0, 0);
            this.GLContext.Margin = new System.Windows.Forms.Padding(0);
            this.GLContext.Name = "GLContext";
            this.GLContext.Size = new System.Drawing.Size(750, 149);
            this.GLContext.TabIndex = 0;
            this.GLContext.VSync = false;
            this.GLContext.Paint += new System.Windows.Forms.PaintEventHandler(this.GLContext_Paint);
            this.GLContext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GLContext_MouseDown);
            this.GLContext.MouseLeave += new System.EventHandler(this.GLContext_MouseLeave);
            this.GLContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GLContext_MouseMove);
            this.GLContext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GLContext_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animatedGifgifToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // animatedGifgifToolStripMenuItem
            // 
            this.animatedGifgifToolStripMenuItem.Name = "animatedGifgifToolStripMenuItem";
            this.animatedGifgifToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.animatedGifgifToolStripMenuItem.Text = "Animated Gif (*.gif)";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // cxtm_Timeline
            // 
            this.cxtm_Timeline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertKeyframeToolStripMenuItem,
            this.removeKeyframeToolStripMenuItem,
            this.toolStripSeparator4,
            this.insertFramesetToolStripMenuItem,
            this.removeFramesetToolStripMenuItem,
            this.toolStripSeparator6,
            this.moveLayerUpToolStripMenuItem,
            this.moveLayerDownToolStripMenuItem,
            this.removeLayerToolStripMenuItem,
            this.toolStripSeparator5,
            this.gotoFrameToolStripMenuItem});
            this.cxtm_Timeline.Name = "cxtm_Timeline";
            this.cxtm_Timeline.Size = new System.Drawing.Size(171, 198);
            // 
            // insertKeyframeToolStripMenuItem
            // 
            this.insertKeyframeToolStripMenuItem.Name = "insertKeyframeToolStripMenuItem";
            this.insertKeyframeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.insertKeyframeToolStripMenuItem.Text = "Insert Keyframe";
            this.insertKeyframeToolStripMenuItem.Click += new System.EventHandler(this.insertKeyframeToolStripMenuItem_Click);
            // 
            // removeKeyframeToolStripMenuItem
            // 
            this.removeKeyframeToolStripMenuItem.Name = "removeKeyframeToolStripMenuItem";
            this.removeKeyframeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeKeyframeToolStripMenuItem.Text = "Remove Keyframe";
            this.removeKeyframeToolStripMenuItem.Click += new System.EventHandler(this.removeKeyframeToolStripMenuItem_Click);
            // 
            // moveLayerUpToolStripMenuItem
            // 
            this.moveLayerUpToolStripMenuItem.Name = "moveLayerUpToolStripMenuItem";
            this.moveLayerUpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.moveLayerUpToolStripMenuItem.Text = "Move Layer Up";
            this.moveLayerUpToolStripMenuItem.Click += new System.EventHandler(this.moveLayerUpToolStripMenuItem_Click);
            // 
            // moveLayerDownToolStripMenuItem
            // 
            this.moveLayerDownToolStripMenuItem.Name = "moveLayerDownToolStripMenuItem";
            this.moveLayerDownToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.moveLayerDownToolStripMenuItem.Text = "Move Layer Down";
            this.moveLayerDownToolStripMenuItem.Click += new System.EventHandler(this.moveLayerDownToolStripMenuItem_Click);
            // 
            // removeLayerToolStripMenuItem
            // 
            this.removeLayerToolStripMenuItem.Name = "removeLayerToolStripMenuItem";
            this.removeLayerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeLayerToolStripMenuItem.Text = "Remove Layer..";
            this.removeLayerToolStripMenuItem.Click += new System.EventHandler(this.removeLayerToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(167, 6);
            // 
            // gotoFrameToolStripMenuItem
            // 
            this.gotoFrameToolStripMenuItem.Enabled = false;
            this.gotoFrameToolStripMenuItem.Name = "gotoFrameToolStripMenuItem";
            this.gotoFrameToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gotoFrameToolStripMenuItem.Text = "Goto Frame";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(167, 6);
            // 
            // removeFramesetToolStripMenuItem
            // 
            this.removeFramesetToolStripMenuItem.Name = "removeFramesetToolStripMenuItem";
            this.removeFramesetToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeFramesetToolStripMenuItem.Text = "Remove Frameset";
            // 
            // insertFramesetToolStripMenuItem
            // 
            this.insertFramesetToolStripMenuItem.Name = "insertFramesetToolStripMenuItem";
            this.insertFramesetToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.insertFramesetToolStripMenuItem.Text = "Insert Frameset";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 541);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sc_MainContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TISFAT Zero";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.sc_MainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_MainContainer)).EndInit();
            this.sc_MainContainer.ResumeLayout(false);
            this.pnl_ToolboxPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cxtm_Timeline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_MainContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animatedGifgifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private OpenTK.GLControl GLContext;
        private System.Windows.Forms.Panel pnl_ToolboxPanel;
        private System.Windows.Forms.Button btn_PlayPause;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Rewind;
        private System.Windows.Forms.Button btn_FastForward;
        private System.Windows.Forms.HScrollBar scrl_HTimeline;
        private System.Windows.Forms.VScrollBar scrl_VTimeline;
        private System.Windows.Forms.Panel pnl_ScrollSquare;
        private System.Windows.Forms.ContextMenuStrip cxtm_Timeline;
        private System.Windows.Forms.ToolStripMenuItem insertKeyframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeKeyframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLayerUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLayerDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem gotoFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertFramesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFramesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

