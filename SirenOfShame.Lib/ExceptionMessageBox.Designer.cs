﻿namespace SirenOfShame.Lib
{
    partial class ExceptionMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionMessageBox));
            this._message = new System.Windows.Forms.Label();
            this._ok = new System.Windows.Forms.Button();
            this._showMore = new System.Windows.Forms.Button();
            this._exception = new System.Windows.Forms.TextBox();
            this._cancel = new System.Windows.Forms.Button();
            this._contact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._raisePriority = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _message
            // 
            this._message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._message.Location = new System.Drawing.Point(128, 9);
            this._message.Name = "_message";
            this._message.Size = new System.Drawing.Size(346, 18);
            this._message.TabIndex = 0;
            this._message.Text = "Error Message";
            // 
            // _ok
            // 
            this._ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._ok.Location = new System.Drawing.Point(399, 85);
            this._ok.Name = "_ok";
            this._ok.Size = new System.Drawing.Size(75, 23);
            this._ok.TabIndex = 1;
            this._ok.Text = "Send";
            this._ok.UseVisualStyleBackColor = true;
            this._ok.Click += new System.EventHandler(this.OkClick);
            // 
            // _showMore
            // 
            this._showMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._showMore.Location = new System.Drawing.Point(237, 85);
            this._showMore.Name = "_showMore";
            this._showMore.Size = new System.Drawing.Size(75, 23);
            this._showMore.TabIndex = 2;
            this._showMore.Text = "More...";
            this._showMore.UseVisualStyleBackColor = true;
            this._showMore.Click += new System.EventHandler(this.ShowMoreClick);
            // 
            // _exception
            // 
            this._exception.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._exception.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exception.Location = new System.Drawing.Point(15, 73);
            this._exception.Multiline = true;
            this._exception.Name = "_exception";
            this._exception.ReadOnly = true;
            this._exception.Size = new System.Drawing.Size(459, 6);
            this._exception.TabIndex = 3;
            this._exception.WordWrap = false;
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Location = new System.Drawing.Point(318, 85);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(75, 23);
            this._cancel.TabIndex = 4;
            this._cancel.Text = "Don\'t Send";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // _contact
            // 
            this._contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._contact.Location = new System.Drawing.Point(128, 30);
            this._contact.Name = "_contact";
            this._contact.Size = new System.Drawing.Size(346, 20);
            this._contact.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contact Info (optional):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Error:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Low";
            // 
            // _raisePriority
            // 
            this._raisePriority.AutoSize = true;
            this._raisePriority.Location = new System.Drawing.Point(339, 57);
            this._raisePriority.Name = "_raisePriority";
            this._raisePriority.Size = new System.Drawing.Size(132, 13);
            this._raisePriority.TabIndex = 10;
            this._raisePriority.TabStop = true;
            this._raisePriority.Text = "How do I raise the priority?";
            this._raisePriority.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RaisePriorityLinkClicked);
            // 
            // ExceptionMessageBox
            // 
            this.AcceptButton = this._ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(486, 120);
            this.Controls.Add(this._raisePriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._contact);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._exception);
            this.Controls.Add(this._showMore);
            this.Controls.Add(this._ok);
            this.Controls.Add(this._message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExceptionMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExceptionMessageBox";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _message;
        private System.Windows.Forms.Button _ok;
        private System.Windows.Forms.Button _showMore;
        private System.Windows.Forms.TextBox _exception;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.TextBox _contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel _raisePriority;
    }
}