namespace MasterOne
{
    partial class App1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Appy = new System.Windows.Forms.RadioButton();
            this.rdb_Sad = new System.Windows.Forms.RadioButton();
            this.pic_Sad = new System.Windows.Forms.PictureBox();
            this.pic_Happy = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Happy)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Sad);
            this.groupBox1.Controls.Add(this.rdb_Appy);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdb_Appy
            // 
            this.rdb_Appy.AutoSize = true;
            this.rdb_Appy.Location = new System.Drawing.Point(24, 67);
            this.rdb_Appy.Name = "rdb_Appy";
            this.rdb_Appy.Size = new System.Drawing.Size(56, 17);
            this.rdb_Appy.TabIndex = 0;
            this.rdb_Appy.TabStop = true;
            this.rdb_Appy.Text = "Happy";
            this.rdb_Appy.UseVisualStyleBackColor = true;
            this.rdb_Appy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_Sad
            // 
            this.rdb_Sad.AutoSize = true;
            this.rdb_Sad.Location = new System.Drawing.Point(24, 154);
            this.rdb_Sad.Name = "rdb_Sad";
            this.rdb_Sad.Size = new System.Drawing.Size(44, 17);
            this.rdb_Sad.TabIndex = 1;
            this.rdb_Sad.TabStop = true;
            this.rdb_Sad.Text = "Sad";
            this.rdb_Sad.UseVisualStyleBackColor = true;
            this.rdb_Sad.CheckedChanged += new System.EventHandler(this.rdb_Sad_CheckedChanged);
            // 
            // pic_Sad
            // 
            this.pic_Sad.Image = global::MasterOne.Properties.Resources.sad;
            this.pic_Sad.Location = new System.Drawing.Point(165, 59);
            this.pic_Sad.Name = "pic_Sad";
            this.pic_Sad.Size = new System.Drawing.Size(191, 194);
            this.pic_Sad.TabIndex = 3;
            this.pic_Sad.TabStop = false;
            // 
            // pic_Happy
            // 
            this.pic_Happy.Image = global::MasterOne.Properties.Resources.happy;
            this.pic_Happy.Location = new System.Drawing.Point(165, 59);
            this.pic_Happy.Name = "pic_Happy";
            this.pic_Happy.Size = new System.Drawing.Size(196, 189);
            this.pic_Happy.TabIndex = 2;
            this.pic_Happy.TabStop = false;
            // 
            // App1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 364);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Sad);
            this.Controls.Add(this.pic_Happy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "App1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons  - Exercice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Happy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_Sad;
        private System.Windows.Forms.RadioButton rdb_Appy;
        private System.Windows.Forms.PictureBox pic_Happy;
        private System.Windows.Forms.PictureBox pic_Sad;
    }
}