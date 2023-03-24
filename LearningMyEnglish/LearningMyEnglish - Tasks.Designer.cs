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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tskBnt1Description = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.Panel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.taskspanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.taskspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tskBnt1Description);
            this.panel1.Location = new System.Drawing.Point(3, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // tskBnt1Description
            // 
            this.tskBnt1Description.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tskBnt1Description.Location = new System.Drawing.Point(3, 68);
            this.tskBnt1Description.Name = "tskBnt1Description";
            this.tskBnt1Description.Size = new System.Drawing.Size(458, 26);
            this.tskBnt1Description.TabIndex = 0;
            this.tskBnt1Description.Text = "Це опис першого завдання";
            this.tskBnt1Description.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(21, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "№1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabs
            // 
            this.tabs.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabs.Controls.Add(this.btnTasks);
            this.tabs.Controls.Add(this.btnRules);
            this.tabs.Location = new System.Drawing.Point(12, 12);
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
            // taskspanel
            // 
            this.taskspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskspanel.Controls.Add(this.button4);
            this.taskspanel.Controls.Add(this.button2);
            this.taskspanel.Controls.Add(this.button3);
            this.taskspanel.Controls.Add(this.button1);
            this.taskspanel.Controls.Add(this.panel1);
            this.taskspanel.Location = new System.Drawing.Point(12, 66);
            this.taskspanel.Name = "taskspanel";
            this.taskspanel.Size = new System.Drawing.Size(1014, 483);
            this.taskspanel.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(326, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "№4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(122, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "№2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(224, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "№3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 554);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.taskspanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning My English - Tasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.taskspanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel tabs;
        private System.Windows.Forms.Label tskBnt1Description;
        private System.Windows.Forms.Panel taskspanel;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

