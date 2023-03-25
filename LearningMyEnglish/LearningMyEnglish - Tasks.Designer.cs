namespace LearningMyEnglish
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
       
        /// початково було Private void InitializeComponent()
        public void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.Panel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.pnlTasks1 = new LearningMyEnglish.pnlTasks();
            this.pnlRules1 = new LearningMyEnglish.pnlRules();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabs.Controls.Add(this.btnTasks);
            this.tabs.Controls.Add(this.btnRules);
            this.tabs.Location = new System.Drawing.Point(563, 254);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(108, 54);
            this.tabs.TabIndex = 3;
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTasks.BackgroundImage = global::LearningMyEnglish.Properties.Resources.tasks;
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Location = new System.Drawing.Point(4, 3);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(48, 48);
            this.btnTasks.TabIndex = 5;
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            this.btnTasks.MouseEnter += new System.EventHandler(this.btnTasks_MouseEnter);
            this.btnTasks.MouseLeave += new System.EventHandler(this.btnTasks_MouseLeave);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRules.BackgroundImage = global::LearningMyEnglish.Properties.Resources.book;
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRules.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Location = new System.Drawing.Point(57, 3);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(48, 48);
            this.btnRules.TabIndex = 6;
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            this.btnRules.MouseEnter += new System.EventHandler(this.btnRules_MouseEnter);
            this.btnRules.MouseLeave += new System.EventHandler(this.btnRules_MouseLeave);
            // 
            // pnlTasks1
            // 
            this.pnlTasks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTasks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTasks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks1.Location = new System.Drawing.Point(271, 0);
            this.pnlTasks1.Name = "pnlTasks1";
            this.pnlTasks1.Size = new System.Drawing.Size(522, 388);
            this.pnlTasks1.TabIndex = 5;
            // 
            // pnlRules1
            // 
            this.pnlRules1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlRules1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRules1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRules1.Location = new System.Drawing.Point(0, 0);
            this.pnlRules1.Name = "pnlRules1";
            this.pnlRules1.Size = new System.Drawing.Size(271, 388);
            this.pnlRules1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(793, 388);
            this.Controls.Add(this.pnlTasks1);
            this.Controls.Add(this.pnlRules1);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning My English - Tasks";
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel tabs;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnRules;
        private pnlRules pnlRules1;
        private pnlTasks pnlTasks1;
    }
}

