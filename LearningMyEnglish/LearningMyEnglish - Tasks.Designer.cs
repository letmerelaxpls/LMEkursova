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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTasks1 = new LearningMyEnglish.pnlTasks();
            this.pnlRules1 = new LearningMyEnglish.pnlRules();
            this.SuspendLayout();
            // 
            // pnlTasks1
            // 
            this.pnlTasks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTasks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnlTasks1, "pnlTasks1");
            this.pnlTasks1.Name = "pnlTasks1";
            // 
            // pnlRules1
            // 
            this.pnlRules1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlRules1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnlRules1, "pnlRules1");
            this.pnlRules1.Name = "pnlRules1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlTasks1);
            this.Controls.Add(this.pnlRules1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private pnlRules pnlRules1;
        private pnlTasks pnlTasks1;
    }
}

