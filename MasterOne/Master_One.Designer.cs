﻿namespace MasterOne
{
    partial class Master_One
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.appsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.app1ToolStripMenuItem,
            this.app2ToolStripMenuItem,
            this.app3ToolStripMenuItem});
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.appsToolStripMenuItem.Text = "Apps";
            // 
            // app1ToolStripMenuItem
            // 
            this.app1ToolStripMenuItem.Name = "app1ToolStripMenuItem";
            this.app1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.app1ToolStripMenuItem.Text = "Radio Buttons";
            this.app1ToolStripMenuItem.Click += new System.EventHandler(this.app1ToolStripMenuItem_Click);
            // 
            // app2ToolStripMenuItem
            // 
            this.app2ToolStripMenuItem.Name = "app2ToolStripMenuItem";
            this.app2ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.app2ToolStripMenuItem.Text = "App2";
            this.app2ToolStripMenuItem.Click += new System.EventHandler(this.app2ToolStripMenuItem_Click);
            // 
            // app3ToolStripMenuItem
            // 
            this.app3ToolStripMenuItem.Name = "app3ToolStripMenuItem";
            this.app3ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.app3ToolStripMenuItem.Text = "App3";
            this.app3ToolStripMenuItem.Click += new System.EventHandler(this.app3ToolStripMenuItem_Click);
            // 
            // Master_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 598);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Master_One";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app3ToolStripMenuItem;
    }
}

