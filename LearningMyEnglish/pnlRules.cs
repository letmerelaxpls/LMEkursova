using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningMyEnglish
{
    public partial class pnlRules : UserControl
    {
        public delegate void ResizeFormDelegate(int width, int height);
        public event ResizeFormDelegate ResizeFormEvent;
        public pnlRules()
        {
            InitializeComponent();
            this.ResizeFormEvent += pnlRules_ResizeFormEvent;
        }
        private void pnlRules_ResizeFormEvent(int width, int height)
        {
            // Збільшуємо максимальну ширину та висоту вікна на 50 пікселів
            this.ParentForm.MaximumSize = new Size(this.ParentForm.MaximumSize.Width + 200, this.ParentForm.MaximumSize.Height + 215);
            this.ParentForm.MinimumSize = new Size(this.ParentForm.MinimumSize.Width + 200, this.ParentForm.MinimumSize.Height + 215);
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Встановлюємо новий розмір форми
            this.ParentForm.Width = width;
            this.ParentForm.Height = height;


        }
        private void rule1_Click(object sender, EventArgs e)
        {
            this.ResizeFormEvent?.Invoke(this.ParentForm.Width + 200, this.ParentForm.Height + 215);
            Form form = this.FindForm();
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is pnlTasks || control is pnlRules)
                    {
                        control.Hide();
                    }
                    if (control is usrRule1)
                    {
                        control.Show();
                    }
                }
            }
            // Створюємо новий екземпляр UserControl
            var usrRule1 = new usrRule1();
            // Додаємо UserControl на форму Form1
            this.ParentForm.Controls.Add(usrRule1);
            usrRule1.Location = new Point(1, 1);
            usrRule1.Size = new Size(795, 535);

        }
    }
}
