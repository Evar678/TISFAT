﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TISFAT_ZERO
{
	public partial class MainF : Form
	{

		#region Variables
		public Toolbox theToolbox;
		private Canvas theCanvas;
		public Timeline tline;
		bool bChanged;
		bool bOld;

		public int layersCount = 1; 
		#endregion

		#region Form/Class Events
		public MainF()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			Toolbox t = new Toolbox(this);
			t.TopLevel = false;
			t.Parent = this.splitContainer1.Panel2;
			splitContainer1.Panel2.Controls.Add(t);
			t.Show();

			Canvas f = new Canvas(this, t);
			f.Size = Properties.User.Default.CanvasSize;
			f.BackColor = Properties.User.Default.CanvasColor;

			f.TopLevel = false;
			f.Parent = this.splitContainer1.Panel2;
			f.StartPosition = FormStartPosition.Manual;
			f.Location = new Point(200, 10);
			splitContainer1.Panel2.Controls.Add(f);

			tline = new Timeline(this, f);
			tline.TopLevel = false;
			tline.Parent = this.splitContainer1.Panel1;
			tline.Size = new Size(this.splitContainer1.Width - 2, splitContainer1.Panel1.Height);
			tline.StartPosition = FormStartPosition.Manual;
			tline.Location = new Point(0, 0);
			splitContainer1.Panel1.Controls.Add(tline);

			int timelineLength = 1024;

			framesPanel.Location = new Point(timelineLength * 9, 0);

			tline.Show();

			f.Show();

			theToolbox = t;
			theCanvas = f;


			if (Program.loadFile != "")
			{
				Loader.loadProjectFile(Program.loadFile);
			}
		} 
		

		public void resetTimeline(bool loading)
		{
			splitContainer1.Panel1.Controls.RemoveAt(0);
			tline.Dispose();
			splitContainer1.Panel2.Controls.RemoveAt(1);
			theCanvas.Dispose();

			Canvas.figureList.Clear();

			Canvas f = new Canvas(this, theToolbox);
			theCanvas = f;
			f.Size = Properties.User.Default.CanvasSize;
			f.BackColor = Properties.User.Default.CanvasColor;
			f.TopLevel = false;
			f.StartPosition = FormStartPosition.Manual;
			f.Location = new Point(200, 10);
			splitContainer1.Panel2.Controls.Add(f);
			f.Show();

			tline = new Timeline(this, theCanvas);
			tline.TopLevel = false;
			tline.Parent = this.splitContainer1.Panel1;
			tline.Size = new Size(this.splitContainer1.Width - 2, splitContainer1.Panel1.Height);
			tline.StartPosition = FormStartPosition.Manual;
			tline.Location = new Point(0, 0);
			splitContainer1.Panel1.Controls.Add(tline);
			tline.Show();

			if(loading)
				Canvas.figureList.Clear();
		}

		public void doneLoading()
		{
			tline.setFrame(0);
			theCanvas.Refresh();
		}
		#endregion

		#region Functions
		private void onFrameSelected()
		{
			//Do stuff here
		}

		//Outline for loading files.
		public void LoadFile(string strFileName)
		{
			/*int f, g, h, i, nFrameSetCount, nFramesCount, x, y, nWide, nHigh, nType, nActionCount, misc, nSkip;
			Layer pLayer;
			//SingleFrame pFrameSet
			KeyFrame pFrame;
			String[] strInfo, strLayerName = new string[255];
			FileStream fs;
			bool bRead, bLoadNew, bTrans, bFirstLayer, bMore, bNewFormat;
			//ActionObj pAction;

			Bitmap bitty;
			MemoryStream ms;

			fs = new FileStream(strFileName, FileMode.Open);*/

		} 
		#endregion

		#region Form Controls
		private void MainF_Resize(object sender, EventArgs e)
		{
			int height = layersCount * 16;

			tline.Size = new Size(this.splitContainer1.Width - 2, height);
		}

		private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
		{
			if (splitContainer1.Panel1.Height < 51)
				splitContainer1.SplitterDistance = 51;

			if(tline != null)
				tline.Size = new Size(this.Width, splitContainer1.SplitterDistance - 20);
		}

		private void splitContainer1_Panel1_Scroll(object sender, ScrollEventArgs e)
		{
			tline.Location = new Point(0, 0);
			tline.Refresh();
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(Color.White);
		}
		#endregion

		#region Menu Bar
		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Preferences f = new Preferences();
			f.ShowDialog();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About f = new About();
			f.ShowDialog();
		}

		private void exitTISFATToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void removeLayerCallback(object sender, EventArgs e)
		{
			if (Timeline.layer_cnt < 2)
				return;

			Layer toRemove = Timeline.layers[Timeline.layer_sel];

			Canvas.figureList.Remove(toRemove.fig);
			Canvas.tweenFigs.Remove(toRemove.tweenFig);

			Timeline.layers.RemoveAt(Timeline.layer_sel);
			Timeline.layer_cnt--;
			if (Timeline.layer_sel == Timeline.layer_cnt)
				Timeline.layer_sel--;

			tline.Refresh();
		}
		#endregion

		private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
		{
			lbl_selectionDummy.Focus();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dlg_saveFile.ShowDialog();
		}

		private void dlg_saveFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Saver.saveProject(dlg_saveFile.FileName, Timeline.layers);
		}

		private void openMovieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dlg_openFile.ShowDialog();
		}

		private void dlg_openFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Loader.loadProjectFile(dlg_openFile.FileName);
		}

		private void newMovieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Timeline.resetEverything(false);
		}

		private void dlThingyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Downloader f = new Downloader();
			f.ShowDialog();
		}

		private void stickEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StickEditor f = new StickEditor();
			f.ShowDialog();
		}

		public void updateByLayers(int layercount)
		{
			layersCount = layercount;
			panel1.Location = new Point(0, layersCount * 16 + 17);
		}
	}
}