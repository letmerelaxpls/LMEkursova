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
        public pnlRules()
        {
            InitializeComponent();
        }

        private void ShowRule(int taskNumber, Type taskType, Size formSize, Point formLocation, string formTitle)
        {
            // Змінюємо місце розташування вікна
            this.ParentForm.DesktopLocation =formLocation;

            // Змінюємо макс та мін розмір вікна
            this.ParentForm.MaximumSize = formSize;
            this.ParentForm.MinimumSize = formSize;

            // Ховаємо всі інші контроли, окрім потрібного
            Form form = this.FindForm();
            form.Text = formTitle;
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is UserControl userControl && userControl.GetType() == taskType)
                    {
                        // Якщо відповідний UserControl вже додано, то просто показуємо його
                        userControl.Show();
                    }
                    else
                    {
                        // Ховаємо інші UserControl
                        control.Hide();
                    }
                }
            }

            // Створюємо новий екземпляр UserControl
            var taskControl = (UserControl)Activator.CreateInstance(taskType);

            // Додаємо UserControl на форму Form1
            this.ParentForm.Controls.Add(taskControl);
            taskControl.Location = new Point(1, 1);
            taskControl.Size = new Size(formSize.Width - 15, formSize.Height - 40);
        }

        private void rule1_Click(object sender, EventArgs e)
        {
            ShowRule(1, typeof(usrRule1), new Size(810, 535), new Point(400, 150), "Learning My English Task #1");
        }

        private void rules2_Click(object sender, EventArgs e)
        {
            ShowRule(2, typeof(usrRule2), new Size(645, 575), new Point(400, 150), "Learning My English Task #2");
        }

        private void rules3_Click(object sender, EventArgs e)
        {
            ShowRule(3, typeof(usrRule3), new Size(741, 705), new Point(400, 50), "Learning My English Task #2");
        }

        private void rules4_Click(object sender, EventArgs e)
        {
            ShowRule(4, typeof(usrRule4), new Size(945, 745), new Point(300, 50), "Learning My English Task #2");
        }

        private void rules5_Click(object sender, EventArgs e)
        {
            ShowRule(5, typeof(usrRule5), new Size(755, 670), new Point(400, 50), "Learning My English Task #2");
        }
    }
}
