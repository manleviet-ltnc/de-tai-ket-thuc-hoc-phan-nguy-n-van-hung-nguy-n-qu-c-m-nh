﻿namespace flappy_bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ongtren1 = new System.Windows.Forms.PictureBox();
            this.ongduoi1 = new System.Windows.Forms.PictureBox();
            this.ongtren2 = new System.Windows.Forms.PictureBox();
            this.ongduoi2 = new System.Windows.Forms.PictureBox();
            this.conchim = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nutplay = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ongtren1
            // 
            this.ongtren1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ongtren1.BackgroundImage")));
            this.ongtren1.Location = new System.Drawing.Point(70, -729);
            this.ongtren1.Name = "ongtren1";
            this.ongtren1.Size = new System.Drawing.Size(252, 989);
            this.ongtren1.TabIndex = 0;
            this.ongtren1.TabStop = false;
            // 
            // ongduoi1
            // 
            this.ongduoi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ongduoi1.BackgroundImage")));
            this.ongduoi1.Location = new System.Drawing.Point(70, 430);
            this.ongduoi1.Name = "ongduoi1";
            this.ongduoi1.Size = new System.Drawing.Size(277, 1037);
            this.ongduoi1.TabIndex = 1;
            this.ongduoi1.TabStop = false;
            // 
            // ongtren2
            // 
            this.ongtren2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ongtren2.BackgroundImage")));
            this.ongtren2.Location = new System.Drawing.Point(426, -742);
            this.ongtren2.Name = "ongtren2";
            this.ongtren2.Size = new System.Drawing.Size(252, 989);
            this.ongtren2.TabIndex = 2;
            this.ongtren2.TabStop = false;
            // 
            // ongduoi2
            // 
            this.ongduoi2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ongduoi2.BackgroundImage")));
            this.ongduoi2.Location = new System.Drawing.Point(426, 406);
            this.ongduoi2.Name = "ongduoi2";
            this.ongduoi2.Size = new System.Drawing.Size(285, 1003);
            this.ongduoi2.TabIndex = 3;
            this.ongduoi2.TabStop = false;
            // 
            // conchim
            // 
            this.conchim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("conchim.BackgroundImage")));
            this.conchim.Location = new System.Drawing.Point(40, 289);
            this.conchim.Name = "conchim";
            this.conchim.Size = new System.Drawing.Size(124, 98);
            this.conchim.TabIndex = 4;
            this.conchim.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nutplay
            // 
            this.nutplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nutplay.BackgroundImage")));
            this.nutplay.Location = new System.Drawing.Point(12, 34);
            this.nutplay.Name = "nutplay";
            this.nutplay.Size = new System.Drawing.Size(52, 51);
            this.nutplay.TabIndex = 5;
            this.nutplay.TabStop = false;
            this.nutplay.Click += new System.EventHandler(this.nutplay_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.nutplay);
            this.Controls.Add(this.conchim);
            this.Controls.Add(this.ongduoi2);
            this.Controls.Add(this.ongtren2);
            this.Controls.Add(this.ongduoi1);
            this.Controls.Add(this.ongtren1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ongtren1;
        private System.Windows.Forms.PictureBox ongduoi1;
        private System.Windows.Forms.PictureBox ongtren2;
        private System.Windows.Forms.PictureBox ongduoi2;
        private System.Windows.Forms.PictureBox conchim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox nutplay;
        private System.Windows.Forms.Timer timer2;
    }
}

