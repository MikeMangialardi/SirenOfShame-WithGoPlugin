namespace GoServices.ServerConfiguration
{
    partial class ConfigureGo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._password = new System.Windows.Forms.TextBox();
            this._userName = new System.Windows.Forms.TextBox();
            this._projects = new SirenOfShame.Lib.Helpers.ThreeStateTreeView();
            this._connect = new SirenOfShame.Lib.SosButton();
            this.label1 = new System.Windows.Forms.Label();
            this._url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "(stored encrypted)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "User Name:";
            // 
            // _password
            // 
            this._password.Location = new System.Drawing.Point(101, 70);
            this._password.Name = "_password";
            this._password.PasswordChar = '*';
            this._password.Size = new System.Drawing.Size(142, 20);
            this._password.TabIndex = 102;
            // 
            // _userName
            // 
            this._userName.Location = new System.Drawing.Point(101, 44);
            this._userName.Name = "_userName";
            this._userName.Size = new System.Drawing.Size(142, 20);
            this._userName.TabIndex = 101;
            // 
            // _projects
            // 
            this._projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._projects.CheckBoxes = true;
            this._projects.Location = new System.Drawing.Point(28, 125);
            this._projects.Name = "_projects";
            this._projects.Size = new System.Drawing.Size(438, 133);
            this._projects.TabIndex = 104;
            this._projects.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.ProjectsAfterCheck);
            // 
            // _connect
            // 
            this._connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._connect.ForeColor = System.Drawing.Color.White;
            this._connect.Location = new System.Drawing.Point(391, 96);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(75, 23);
            this._connect.TabIndex = 103;
            this._connect.Text = "Connect";
            this._connect.UseVisualStyleBackColor = true;
            this._connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "URL:";
            // 
            // _url
            // 
            this._url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._url.Location = new System.Drawing.Point(101, 18);
            this._url.Name = "_url";
            this._url.Size = new System.Drawing.Size(365, 20);
            this._url.TabIndex = 100;
            // 
            // ConfigureGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._password);
            this.Controls.Add(this._userName);
            this.Controls.Add(this._projects);
            this.Controls.Add(this._connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._url);
            this.Name = "ConfigureGo";
            this.Size = new System.Drawing.Size(490, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.TextBox _userName;
        private SirenOfShame.Lib.Helpers.ThreeStateTreeView _projects;
        private SirenOfShame.Lib.SosButton _connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _url;

    }
}
