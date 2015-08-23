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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.sc_MainContainer = new System.Windows.Forms.SplitContainer();
			this.btn_ExportProject = new TISFAT.Controls.BitmapButtonControl();
			this.btn_Redo = new TISFAT.Controls.BitmapButtonControl();
			this.btn_Undo = new TISFAT.Controls.BitmapButtonControl();
			this.separatorControl2 = new TISFAT.UI.Controls.SeparatorControl();
			this.btn_SaveProject = new TISFAT.Controls.BitmapButtonControl();
			this.btn_OpenProject = new TISFAT.Controls.BitmapButtonControl();
			this.btn_NewProject = new TISFAT.Controls.BitmapButtonControl();
			this.btn_AddLayer = new TISFAT.Controls.BitmapButtonControl();
			this.btn_RemoveLayer = new TISFAT.Controls.BitmapButtonControl();
			this.separatorControl1 = new TISFAT.UI.Controls.SeparatorControl();
			this.btn_EditModePhase = new TISFAT.Controls.BitmapButtonControl();
			this.btn_EditModeOnion = new TISFAT.Controls.BitmapButtonControl();
			this.btn_EditModeDefault = new TISFAT.Controls.BitmapButtonControl();
			this.btn_EditModeDiff = new TISFAT.Controls.BitmapButtonControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.projectPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			((System.ComponentModel.ISupportInitialize)(this.sc_MainContainer)).BeginInit();
			this.sc_MainContainer.Panel1.SuspendLayout();
			this.sc_MainContainer.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// sc_MainContainer
			// 
			this.sc_MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sc_MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sc_MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.sc_MainContainer.IsSplitterFixed = true;
			this.sc_MainContainer.Location = new System.Drawing.Point(0, 24);
			this.sc_MainContainer.Margin = new System.Windows.Forms.Padding(0);
			this.sc_MainContainer.Name = "sc_MainContainer";
			this.sc_MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_MainContainer.Panel1
			// 
			this.sc_MainContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_ExportProject);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_Redo);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_Undo);
			this.sc_MainContainer.Panel1.Controls.Add(this.separatorControl2);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_SaveProject);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_OpenProject);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_NewProject);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_AddLayer);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_RemoveLayer);
			this.sc_MainContainer.Panel1.Controls.Add(this.separatorControl1);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_EditModePhase);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_EditModeOnion);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_EditModeDefault);
			this.sc_MainContainer.Panel1.Controls.Add(this.btn_EditModeDiff);
			this.sc_MainContainer.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.sc_MainContainer.Panel1MinSize = 29;
			// 
			// sc_MainContainer.Panel2
			// 
			this.sc_MainContainer.Panel2.AutoScroll = true;
			this.sc_MainContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.sc_MainContainer.Size = new System.Drawing.Size(784, 577);
			this.sc_MainContainer.SplitterDistance = 29;
			this.sc_MainContainer.SplitterWidth = 2;
			this.sc_MainContainer.TabIndex = 0;
			// 
			// btn_ExportProject
			// 
			this.btn_ExportProject.Checked = false;
			this.btn_ExportProject.ImageDefault = global::TISFAT.Properties.Resources.document_export;
			this.btn_ExportProject.ImageDown = null;
			this.btn_ExportProject.ImageHover = null;
			this.btn_ExportProject.ImageOn = null;
			this.btn_ExportProject.ImageOnDown = null;
			this.btn_ExportProject.ImageOnHover = null;
			this.btn_ExportProject.Location = new System.Drawing.Point(94, 2);
			this.btn_ExportProject.Name = "btn_ExportProject";
			this.btn_ExportProject.Size = new System.Drawing.Size(24, 24);
			this.btn_ExportProject.TabIndex = 13;
			this.btn_ExportProject.ToggleButton = false;
			this.btn_ExportProject.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// btn_Redo
			// 
			this.btn_Redo.Checked = false;
			this.btn_Redo.ImageDefault = global::TISFAT.Properties.Resources.redo_gray;
			this.btn_Redo.ImageDown = null;
			this.btn_Redo.ImageHover = null;
			this.btn_Redo.ImageOn = null;
			this.btn_Redo.ImageOnDown = null;
			this.btn_Redo.ImageOnHover = null;
			this.btn_Redo.Location = new System.Drawing.Point(164, 2);
			this.btn_Redo.Name = "btn_Redo";
			this.btn_Redo.Size = new System.Drawing.Size(24, 24);
			this.btn_Redo.TabIndex = 12;
			this.btn_Redo.ToggleButton = false;
			this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
			// 
			// btn_Undo
			// 
			this.btn_Undo.Checked = false;
			this.btn_Undo.ImageDefault = global::TISFAT.Properties.Resources.undo_gray;
			this.btn_Undo.ImageDown = null;
			this.btn_Undo.ImageHover = null;
			this.btn_Undo.ImageOn = null;
			this.btn_Undo.ImageOnDown = null;
			this.btn_Undo.ImageOnHover = null;
			this.btn_Undo.Location = new System.Drawing.Point(134, 2);
			this.btn_Undo.Name = "btn_Undo";
			this.btn_Undo.Size = new System.Drawing.Size(24, 24);
			this.btn_Undo.TabIndex = 11;
			this.btn_Undo.ToggleButton = false;
			this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
			// 
			// separatorControl2
			// 
			this.separatorControl2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.separatorControl2.Location = new System.Drawing.Point(121, 2);
			this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
			this.separatorControl2.Name = "separatorControl2";
			this.separatorControl2.Size = new System.Drawing.Size(10, 22);
			this.separatorControl2.TabIndex = 10;
			// 
			// btn_SaveProject
			// 
			this.btn_SaveProject.Checked = false;
			this.btn_SaveProject.ImageDefault = global::TISFAT.Properties.Resources.diskette;
			this.btn_SaveProject.ImageDown = null;
			this.btn_SaveProject.ImageHover = null;
			this.btn_SaveProject.ImageOn = null;
			this.btn_SaveProject.ImageOnDown = null;
			this.btn_SaveProject.ImageOnHover = null;
			this.btn_SaveProject.Location = new System.Drawing.Point(64, 2);
			this.btn_SaveProject.Name = "btn_SaveProject";
			this.btn_SaveProject.Size = new System.Drawing.Size(24, 24);
			this.btn_SaveProject.TabIndex = 9;
			this.btn_SaveProject.ToggleButton = false;
			this.btn_SaveProject.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// btn_OpenProject
			// 
			this.btn_OpenProject.Checked = false;
			this.btn_OpenProject.ImageDefault = global::TISFAT.Properties.Resources.folder;
			this.btn_OpenProject.ImageDown = null;
			this.btn_OpenProject.ImageHover = null;
			this.btn_OpenProject.ImageOn = null;
			this.btn_OpenProject.ImageOnDown = null;
			this.btn_OpenProject.ImageOnHover = null;
			this.btn_OpenProject.Location = new System.Drawing.Point(34, 2);
			this.btn_OpenProject.Name = "btn_OpenProject";
			this.btn_OpenProject.Size = new System.Drawing.Size(24, 24);
			this.btn_OpenProject.TabIndex = 8;
			this.btn_OpenProject.ToggleButton = false;
			this.btn_OpenProject.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// btn_NewProject
			// 
			this.btn_NewProject.Checked = false;
			this.btn_NewProject.ImageDefault = global::TISFAT.Properties.Resources.page_white;
			this.btn_NewProject.ImageDown = null;
			this.btn_NewProject.ImageHover = null;
			this.btn_NewProject.ImageOn = null;
			this.btn_NewProject.ImageOnDown = null;
			this.btn_NewProject.ImageOnHover = null;
			this.btn_NewProject.Location = new System.Drawing.Point(4, 2);
			this.btn_NewProject.Name = "btn_NewProject";
			this.btn_NewProject.Size = new System.Drawing.Size(24, 24);
			this.btn_NewProject.TabIndex = 7;
			this.btn_NewProject.ToggleButton = false;
			this.btn_NewProject.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// btn_AddLayer
			// 
			this.btn_AddLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddLayer.Checked = false;
			this.btn_AddLayer.ImageDefault = global::TISFAT.Properties.Resources.layer_add;
			this.btn_AddLayer.ImageDown = null;
			this.btn_AddLayer.ImageHover = null;
			this.btn_AddLayer.ImageOn = null;
			this.btn_AddLayer.ImageOnDown = null;
			this.btn_AddLayer.ImageOnHover = null;
			this.btn_AddLayer.Location = new System.Drawing.Point(594, 2);
			this.btn_AddLayer.Name = "btn_AddLayer";
			this.btn_AddLayer.Size = new System.Drawing.Size(24, 24);
			this.btn_AddLayer.TabIndex = 6;
			this.btn_AddLayer.ToggleButton = false;
			this.btn_AddLayer.Click += new System.EventHandler(this.btn_AddLayer_Click);
			// 
			// btn_RemoveLayer
			// 
			this.btn_RemoveLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveLayer.Checked = false;
			this.btn_RemoveLayer.ImageDefault = global::TISFAT.Properties.Resources.layer_remove;
			this.btn_RemoveLayer.ImageDown = null;
			this.btn_RemoveLayer.ImageHover = null;
			this.btn_RemoveLayer.ImageOn = null;
			this.btn_RemoveLayer.ImageOnDown = null;
			this.btn_RemoveLayer.ImageOnHover = null;
			this.btn_RemoveLayer.Location = new System.Drawing.Point(624, 2);
			this.btn_RemoveLayer.Name = "btn_RemoveLayer";
			this.btn_RemoveLayer.Size = new System.Drawing.Size(24, 24);
			this.btn_RemoveLayer.TabIndex = 5;
			this.btn_RemoveLayer.ToggleButton = false;
			this.btn_RemoveLayer.Click += new System.EventHandler(this.btn_RemoveLayer_Click);
			// 
			// separatorControl1
			// 
			this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.separatorControl1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.separatorControl1.Location = new System.Drawing.Point(651, 2);
			this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
			this.separatorControl1.Name = "separatorControl1";
			this.separatorControl1.Size = new System.Drawing.Size(10, 22);
			this.separatorControl1.TabIndex = 4;
			// 
			// btn_EditModePhase
			// 
			this.btn_EditModePhase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditModePhase.Checked = false;
			this.btn_EditModePhase.ImageDefault = global::TISFAT.Properties.Resources.layer_redraw;
			this.btn_EditModePhase.ImageDown = null;
			this.btn_EditModePhase.ImageHover = null;
			this.btn_EditModePhase.ImageOn = null;
			this.btn_EditModePhase.ImageOnDown = null;
			this.btn_EditModePhase.ImageOnHover = null;
			this.btn_EditModePhase.Location = new System.Drawing.Point(724, 2);
			this.btn_EditModePhase.Name = "btn_EditModePhase";
			this.btn_EditModePhase.Size = new System.Drawing.Size(24, 24);
			this.btn_EditModePhase.TabIndex = 3;
			this.btn_EditModePhase.ToggleButton = false;
			this.btn_EditModePhase.Click += new System.EventHandler(this.btn_EditModePhase_Click);
			// 
			// btn_EditModeOnion
			// 
			this.btn_EditModeOnion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditModeOnion.Checked = false;
			this.btn_EditModeOnion.ImageDefault = global::TISFAT.Properties.Resources.layer_raster_3d;
			this.btn_EditModeOnion.ImageDown = null;
			this.btn_EditModeOnion.ImageHover = null;
			this.btn_EditModeOnion.ImageOn = null;
			this.btn_EditModeOnion.ImageOnDown = null;
			this.btn_EditModeOnion.ImageOnHover = null;
			this.btn_EditModeOnion.Location = new System.Drawing.Point(694, 2);
			this.btn_EditModeOnion.Name = "btn_EditModeOnion";
			this.btn_EditModeOnion.Size = new System.Drawing.Size(24, 24);
			this.btn_EditModeOnion.TabIndex = 2;
			this.btn_EditModeOnion.ToggleButton = false;
			this.btn_EditModeOnion.Click += new System.EventHandler(this.btn_EditModeOnion_Click);
			// 
			// btn_EditModeDefault
			// 
			this.btn_EditModeDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditModeDefault.Checked = true;
			this.btn_EditModeDefault.ImageDefault = global::TISFAT.Properties.Resources.layer_raster;
			this.btn_EditModeDefault.ImageDown = null;
			this.btn_EditModeDefault.ImageHover = null;
			this.btn_EditModeDefault.ImageOn = null;
			this.btn_EditModeDefault.ImageOnDown = null;
			this.btn_EditModeDefault.ImageOnHover = null;
			this.btn_EditModeDefault.Location = new System.Drawing.Point(664, 2);
			this.btn_EditModeDefault.Name = "btn_EditModeDefault";
			this.btn_EditModeDefault.Size = new System.Drawing.Size(24, 24);
			this.btn_EditModeDefault.TabIndex = 1;
			this.btn_EditModeDefault.ToggleButton = false;
			this.btn_EditModeDefault.Click += new System.EventHandler(this.btn_EditModeDefault_Click);
			// 
			// btn_EditModeDiff
			// 
			this.btn_EditModeDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditModeDiff.Checked = false;
			this.btn_EditModeDiff.ImageDefault = global::TISFAT.Properties.Resources.layer_mask;
			this.btn_EditModeDiff.ImageDown = null;
			this.btn_EditModeDiff.ImageHover = null;
			this.btn_EditModeDiff.ImageOn = null;
			this.btn_EditModeDiff.ImageOnDown = null;
			this.btn_EditModeDiff.ImageOnHover = null;
			this.btn_EditModeDiff.Location = new System.Drawing.Point(754, 2);
			this.btn_EditModeDiff.Name = "btn_EditModeDiff";
			this.btn_EditModeDiff.Size = new System.Drawing.Size(24, 24);
			this.btn_EditModeDiff.TabIndex = 0;
			this.btn_EditModeDiff.ToggleButton = false;
			this.btn_EditModeDiff.Click += new System.EventHandler(this.btn_EditModeDiff_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 1;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.projectPropertiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.saveAsToolStripMenuItem.Text = "Save As..";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
			// 
			// projectPropertiesToolStripMenuItem
			// 
			this.projectPropertiesToolStripMenuItem.Name = "projectPropertiesToolStripMenuItem";
			this.projectPropertiesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.projectPropertiesToolStripMenuItem.Text = "Project Properties..";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.exportToolStripMenuItem.Text = "Export..";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
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
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.redoToolStripMenuItem.Text = "Redo";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 601);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.sc_MainContainer);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 580);
			this.Name = "MainForm";
			this.Text = "TISFAT Zero";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.sc_MainContainer.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_MainContainer)).EndInit();
			this.sc_MainContainer.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem projectPropertiesToolStripMenuItem;
		private Controls.BitmapButtonControl btn_EditModePhase;
		private Controls.BitmapButtonControl btn_EditModeOnion;
		private Controls.BitmapButtonControl btn_EditModeDefault;
		private Controls.BitmapButtonControl btn_EditModeDiff;
		private UI.Controls.SeparatorControl separatorControl1;
		private Controls.BitmapButtonControl btn_AddLayer;
		private Controls.BitmapButtonControl btn_RemoveLayer;
		private Controls.BitmapButtonControl btn_OpenProject;
		private Controls.BitmapButtonControl btn_NewProject;
		private Controls.BitmapButtonControl btn_SaveProject;
		private UI.Controls.SeparatorControl separatorControl2;
		private Controls.BitmapButtonControl btn_Redo;
		private Controls.BitmapButtonControl btn_Undo;
		private Controls.BitmapButtonControl btn_ExportProject;
	}
}

