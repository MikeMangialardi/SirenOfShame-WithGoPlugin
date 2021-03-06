﻿namespace SirenOfShame.Lib
{
    partial class ConfigureSirenDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureSirenDialog));
            this._close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._audioAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._audioPatterns = new System.Windows.Forms.ListView();
            this._audioPatternNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._audioPatternTotalLengthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._ledAdd = new System.Windows.Forms.Button();
            this._ledPatterns = new System.Windows.Forms.ListView();
            this._ledPatternNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ledPatternCountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._upload = new System.Windows.Forms.Button();
            this._progress = new System.Windows.Forms.ProgressBar();
            this._audioContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._audioPlay = new System.Windows.Forms.ToolStripMenuItem();
            this._audioRename = new System.Windows.Forms.ToolStripMenuItem();
            this._audioEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._audioRemove = new System.Windows.Forms.ToolStripMenuItem();
            this._ledContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._ledPlay = new System.Windows.Forms.ToolStripMenuItem();
            this._ledRename = new System.Windows.Forms.ToolStripMenuItem();
            this._ledRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this._audioContextMenu.SuspendLayout();
            this._ledContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _close
            // 
            this._close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._close.Location = new System.Drawing.Point(493, 328);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(75, 23);
            this._close.TabIndex = 5;
            this._close.Text = "OK";
            this._close.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this._audioAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._audioPatterns);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 155);
            this.panel1.TabIndex = 14;
            // 
            // _audioAdd
            // 
            this._audioAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._audioAdd.Location = new System.Drawing.Point(481, 129);
            this._audioAdd.Name = "_audioAdd";
            this._audioAdd.Size = new System.Drawing.Size(75, 23);
            this._audioAdd.TabIndex = 14;
            this._audioAdd.Text = "Add...";
            this._audioAdd.UseVisualStyleBackColor = true;
            this._audioAdd.Click += new System.EventHandler(this._audioAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Audio";
            // 
            // _audioPatterns
            // 
            this._audioPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._audioPatterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._audioPatternNameColumn,
            this._audioPatternTotalLengthColumn});
            this._audioPatterns.FullRowSelect = true;
            this._audioPatterns.HideSelection = false;
            this._audioPatterns.LabelEdit = true;
            this._audioPatterns.Location = new System.Drawing.Point(3, 16);
            this._audioPatterns.Name = "_audioPatterns";
            this._audioPatterns.Size = new System.Drawing.Size(553, 107);
            this._audioPatterns.TabIndex = 12;
            this._audioPatterns.UseCompatibleStateImageBehavior = false;
            this._audioPatterns.View = System.Windows.Forms.View.Details;
            this._audioPatterns.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this._audioPatterns_AfterLabelEdit);
            this._audioPatterns.MouseDown += new System.Windows.Forms.MouseEventHandler(this._audioPatterns_MouseDown);
            this._audioPatterns.MouseUp += new System.Windows.Forms.MouseEventHandler(this._audioPatterns_MouseUp);
            // 
            // _audioPatternNameColumn
            // 
            this._audioPatternNameColumn.Text = "Name";
            this._audioPatternNameColumn.Width = 200;
            // 
            // _audioPatternTotalLengthColumn
            // 
            this._audioPatternTotalLengthColumn.Text = "Total Length";
            this._audioPatternTotalLengthColumn.Width = 80;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this._ledAdd);
            this.panel2.Controls.Add(this._ledPatterns);
            this.panel2.Location = new System.Drawing.Point(12, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 149);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "LEDs";
            // 
            // _ledAdd
            // 
            this._ledAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._ledAdd.Location = new System.Drawing.Point(481, 119);
            this._ledAdd.Name = "_ledAdd";
            this._ledAdd.Size = new System.Drawing.Size(75, 23);
            this._ledAdd.TabIndex = 15;
            this._ledAdd.Text = "Add...";
            this._ledAdd.UseVisualStyleBackColor = true;
            this._ledAdd.Click += new System.EventHandler(this._ledAdd_Click);
            // 
            // _ledPatterns
            // 
            this._ledPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ledPatterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._ledPatternNameColumn,
            this._ledPatternCountColumn});
            this._ledPatterns.FullRowSelect = true;
            this._ledPatterns.HideSelection = false;
            this._ledPatterns.LabelEdit = true;
            this._ledPatterns.Location = new System.Drawing.Point(3, 16);
            this._ledPatterns.Name = "_ledPatterns";
            this._ledPatterns.Size = new System.Drawing.Size(553, 97);
            this._ledPatterns.TabIndex = 14;
            this._ledPatterns.UseCompatibleStateImageBehavior = false;
            this._ledPatterns.View = System.Windows.Forms.View.Details;
            this._ledPatterns.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this._ledPatterns_AfterLabelEdit);
            this._ledPatterns.MouseDown += new System.Windows.Forms.MouseEventHandler(this._ledPatterns_MouseDown);
            this._ledPatterns.MouseUp += new System.Windows.Forms.MouseEventHandler(this._ledPatterns_MouseUp);
            // 
            // _ledPatternNameColumn
            // 
            this._ledPatternNameColumn.Text = "Name";
            this._ledPatternNameColumn.Width = 200;
            // 
            // _ledPatternCountColumn
            // 
            this._ledPatternCountColumn.Text = "Length";
            this._ledPatternCountColumn.Width = 80;
            // 
            // _upload
            // 
            this._upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._upload.Location = new System.Drawing.Point(412, 328);
            this._upload.Name = "_upload";
            this._upload.Size = new System.Drawing.Size(75, 23);
            this._upload.TabIndex = 18;
            this._upload.Text = "Upload";
            this._upload.UseVisualStyleBackColor = true;
            this._upload.Click += new System.EventHandler(this._upload_Click);
            // 
            // _progress
            // 
            this._progress.Location = new System.Drawing.Point(12, 328);
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(394, 23);
            this._progress.TabIndex = 19;
            this._progress.Visible = false;
            // 
            // _audioContextMenu
            // 
            this._audioContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._audioPlay,
            this._audioRename,
            this._audioEdit,
            this._audioRemove});
            this._audioContextMenu.Name = "_audioContextMenu";
            this._audioContextMenu.Size = new System.Drawing.Size(153, 114);
            // 
            // _audioPlay
            // 
            this._audioPlay.Name = "_audioPlay";
            this._audioPlay.Size = new System.Drawing.Size(152, 22);
            this._audioPlay.Text = "&Play";
            this._audioPlay.Click += new System.EventHandler(this._audioPlay_Click);
            // 
            // _audioRename
            // 
            this._audioRename.Name = "_audioRename";
            this._audioRename.Size = new System.Drawing.Size(152, 22);
            this._audioRename.Text = "&Rename";
            this._audioRename.Click += new System.EventHandler(this._audioRename_Click);
            // 
            // _audioEdit
            // 
            this._audioEdit.Name = "_audioEdit";
            this._audioEdit.Size = new System.Drawing.Size(152, 22);
            this._audioEdit.Text = "&Edit...";
            this._audioEdit.Click += new System.EventHandler(this._audioEdit_Click);
            // 
            // _audioRemove
            // 
            this._audioRemove.Name = "_audioRemove";
            this._audioRemove.Size = new System.Drawing.Size(152, 22);
            this._audioRemove.Text = "Remove";
            this._audioRemove.Click += new System.EventHandler(this._audioRemove_Click);
            // 
            // _ledContextMenu
            // 
            this._ledContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ledPlay,
            this._ledRename,
            this._ledRemove});
            this._ledContextMenu.Name = "_audioContextMenu";
            this._ledContextMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // _ledPlay
            // 
            this._ledPlay.Name = "_ledPlay";
            this._ledPlay.Size = new System.Drawing.Size(117, 22);
            this._ledPlay.Text = "&Play";
            this._ledPlay.Click += new System.EventHandler(this._ledPlay_Click);
            // 
            // _ledRename
            // 
            this._ledRename.Name = "_ledRename";
            this._ledRename.Size = new System.Drawing.Size(117, 22);
            this._ledRename.Text = "&Rename";
            this._ledRename.Click += new System.EventHandler(this._ledRename_Click);
            // 
            // _ledRemove
            // 
            this._ledRemove.Name = "_ledRemove";
            this._ledRemove.Size = new System.Drawing.Size(117, 22);
            this._ledRemove.Text = "Remove";
            this._ledRemove.Click += new System.EventHandler(this._ledRemove_Click);
            // 
            // ConfigureSirenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 356);
            this.Controls.Add(this._progress);
            this.Controls.Add(this._upload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._close);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigureSirenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audio Upload";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureSirenDialog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._audioContextMenu.ResumeLayout(false);
            this._ledContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _audioAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView _audioPatterns;
        private System.Windows.Forms.ColumnHeader _audioPatternNameColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _ledAdd;
        private System.Windows.Forms.ListView _ledPatterns;
        private System.Windows.Forms.ColumnHeader _ledPatternNameColumn;
        private System.Windows.Forms.Button _upload;
        private System.Windows.Forms.ProgressBar _progress;
        private System.Windows.Forms.ContextMenuStrip _audioContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _audioRemove;
        private System.Windows.Forms.ColumnHeader _audioPatternTotalLengthColumn;
        private System.Windows.Forms.ToolStripMenuItem _audioRename;
        private System.Windows.Forms.ToolStripMenuItem _audioPlay;
        private System.Windows.Forms.ContextMenuStrip _ledContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _ledPlay;
        private System.Windows.Forms.ToolStripMenuItem _ledRename;
        private System.Windows.Forms.ToolStripMenuItem _ledRemove;
        private System.Windows.Forms.ColumnHeader _ledPatternCountColumn;
        private System.Windows.Forms.ToolStripMenuItem _audioEdit;
    }
}