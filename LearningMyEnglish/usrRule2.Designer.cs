﻿namespace LearningMyEnglish
{
    partial class usrRule2
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
            this.pagepanel = new System.Windows.Forms.Panel();
            this.backtomenu = new System.Windows.Forms.Button();
            this.rule2text = new System.Windows.Forms.PictureBox();
            this.rule2head = new System.Windows.Forms.PictureBox();
            this.pagepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rule2text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rule2head)).BeginInit();
            this.SuspendLayout();
            // 
            // pagepanel
            // 
            this.pagepanel.AutoScroll = true;
            this.pagepanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pagepanel.Controls.Add(this.backtomenu);
            this.pagepanel.Controls.Add(this.rule2text);
            this.pagepanel.Controls.Add(this.rule2head);
            this.pagepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagepanel.Location = new System.Drawing.Point(0, 0);
            this.pagepanel.Name = "pagepanel";
            this.pagepanel.Size = new System.Drawing.Size(825, 580);
            this.pagepanel.TabIndex = 0;
            // 
            // backtomenu
            // 
            this.backtomenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backtomenu.BackgroundImage = global::LearningMyEnglish.Properties.Resources.back;
            this.backtomenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backtomenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtomenu.Location = new System.Drawing.Point(743, 43);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(48, 48);
            this.backtomenu.TabIndex = 2;
            this.backtomenu.UseVisualStyleBackColor = false;
            this.backtomenu.Click += new System.EventHandler(this.backtomenu_Click);
            // 
            // rule2text
            // 
            this.rule2text.Image = global::LearningMyEnglish.Properties.Resources.rule2text;
            this.rule2text.Location = new System.Drawing.Point(3, 84);
            this.rule2text.Name = "rule2text";
            this.rule2text.Size = new System.Drawing.Size(757, 797);
            this.rule2text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rule2text.TabIndex = 1;
            this.rule2text.TabStop = false;
            // 
            // rule2head
            // 
            this.rule2head.Image = global::LearningMyEnglish.Properties.Resources.rule2head;
            this.rule2head.Location = new System.Drawing.Point(0, 0);
            this.rule2head.Name = "rule2head";
            this.rule2head.Size = new System.Drawing.Size(761, 81);
            this.rule2head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rule2head.TabIndex = 0;
            this.rule2head.TabStop = false;
            // 
            // usrRule2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagepanel);
            this.Name = "usrRule2";
            this.Size = new System.Drawing.Size(825, 580);
            this.pagepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rule2text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rule2head)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pagepanel;
        private System.Windows.Forms.PictureBox rule2head;
        private System.Windows.Forms.PictureBox rule2text;
        private System.Windows.Forms.Button backtomenu;
    }
}
