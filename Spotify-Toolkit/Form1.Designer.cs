﻿namespace Spotify_Toolkit
{
    partial class Form1
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
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewPlaylistConfig = new System.Windows.Forms.Button();
            this.gbxSectionReverse = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.pbrReverse = new System.Windows.Forms.ProgressBar();
            this.cbxNewPlaylist = new System.Windows.Forms.CheckBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.cobxReverse = new System.Windows.Forms.ComboBox();
            this.lblProfileDisplayName = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.pnlProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxSectionReverse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfile.Controls.Add(this.groupBox1);
            this.pnlProfile.Controls.Add(this.gbxSectionReverse);
            this.pnlProfile.Controls.Add(this.lblProfileDisplayName);
            this.pnlProfile.Controls.Add(this.lblProfile);
            this.pnlProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProfile.Location = new System.Drawing.Point(2, 5);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(595, 512);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewPlaylistConfig);
            this.groupBox1.Location = new System.Drawing.Point(6, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbxSync";
            // 
            // btnNewPlaylistConfig
            // 
            this.btnNewPlaylistConfig.Location = new System.Drawing.Point(4, 19);
            this.btnNewPlaylistConfig.Name = "btnNewPlaylistConfig";
            this.btnNewPlaylistConfig.Size = new System.Drawing.Size(575, 23);
            this.btnNewPlaylistConfig.TabIndex = 2;
            this.btnNewPlaylistConfig.Text = "new Playlist Config";
            this.btnNewPlaylistConfig.UseVisualStyleBackColor = true;
            this.btnNewPlaylistConfig.Click += new System.EventHandler(this.btnNewPlaylistConfig_Click);
            // 
            // gbxSectionReverse
            // 
            this.gbxSectionReverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSectionReverse.Controls.Add(this.lblName);
            this.gbxSectionReverse.Controls.Add(this.tbxNewName);
            this.gbxSectionReverse.Controls.Add(this.pbrReverse);
            this.gbxSectionReverse.Controls.Add(this.cbxNewPlaylist);
            this.gbxSectionReverse.Controls.Add(this.btnReverse);
            this.gbxSectionReverse.Controls.Add(this.cobxReverse);
            this.gbxSectionReverse.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSectionReverse.Location = new System.Drawing.Point(6, 16);
            this.gbxSectionReverse.Name = "gbxSectionReverse";
            this.gbxSectionReverse.Size = new System.Drawing.Size(583, 207);
            this.gbxSectionReverse.TabIndex = 3;
            this.gbxSectionReverse.TabStop = false;
            this.gbxSectionReverse.Text = "Reverse Playlist";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // tbxNewName
            // 
            this.tbxNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbxNewName.Location = new System.Drawing.Point(68, 69);
            this.tbxNewName.Multiline = true;
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(509, 18);
            this.tbxNewName.TabIndex = 6;
            this.tbxNewName.Text = "...type Name";
            this.tbxNewName.TextChanged += new System.EventHandler(this.tbxNewName_TextChanged);
            this.tbxNewName.Enter += new System.EventHandler(this.tbxNewName_Enter);
            this.tbxNewName.Leave += new System.EventHandler(this.tbxNewName_Leave);
            // 
            // pbrReverse
            // 
            this.pbrReverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrReverse.Location = new System.Drawing.Point(6, 191);
            this.pbrReverse.Name = "pbrReverse";
            this.pbrReverse.Size = new System.Drawing.Size(570, 10);
            this.pbrReverse.TabIndex = 5;
            this.pbrReverse.Visible = false;
            // 
            // cbxNewPlaylist
            // 
            this.cbxNewPlaylist.AutoSize = true;
            this.cbxNewPlaylist.Checked = true;
            this.cbxNewPlaylist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNewPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNewPlaylist.Location = new System.Drawing.Point(7, 47);
            this.cbxNewPlaylist.Name = "cbxNewPlaylist";
            this.cbxNewPlaylist.Size = new System.Drawing.Size(245, 17);
            this.cbxNewPlaylist.TabIndex = 4;
            this.cbxNewPlaylist.Text = "create new Playlist ( local Files will be ignored )";
            this.cbxNewPlaylist.UseVisualStyleBackColor = true;
            this.cbxNewPlaylist.CheckedChanged += new System.EventHandler(this.cbxNewPlaylist_CheckedChanged);
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(6, 162);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // cobxReverse
            // 
            this.cobxReverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cobxReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobxReverse.FormattingEnabled = true;
            this.cobxReverse.Location = new System.Drawing.Point(6, 19);
            this.cobxReverse.Name = "cobxReverse";
            this.cobxReverse.Size = new System.Drawing.Size(570, 21);
            this.cobxReverse.TabIndex = 2;
            this.cobxReverse.SelectionChangeCommitted += new System.EventHandler(this.cobxReverse_SelectionChangeCommitted);
            // 
            // lblProfileDisplayName
            // 
            this.lblProfileDisplayName.AutoSize = true;
            this.lblProfileDisplayName.Location = new System.Drawing.Point(62, 0);
            this.lblProfileDisplayName.Name = "lblProfileDisplayName";
            this.lblProfileDisplayName.Size = new System.Drawing.Size(35, 13);
            this.lblProfileDisplayName.TabIndex = 1;
            this.lblProfileDisplayName.Text = "label1";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(3, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(39, 13);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Profile:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 519);
            this.Controls.Add(this.pnlProfile);
            this.Name = "Form1";
            this.Text = "Spotify Toolkit";
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbxSectionReverse.ResumeLayout(false);
            this.gbxSectionReverse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblProfileDisplayName;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.GroupBox gbxSectionReverse;
        private System.Windows.Forms.ComboBox cobxReverse;
        private System.Windows.Forms.CheckBox cbxNewPlaylist;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.ProgressBar pbrReverse;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewPlaylistConfig;
    }
}

