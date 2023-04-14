using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace LearningMyEnglish
{
    public partial class pnlTasks : UserControl
    {
        // Список кнопок та лейблів
        private Dictionary<Button, Label> buttonLabels = new Dictionary<Button, Label>();

        public pnlTasks()
        {
            InitializeComponent();
        }

        private void pnlTasks_Load(object sender, EventArgs e)
        {
            // Додає у список кнопки на лейбли
            buttonLabels.Add(task1, thmdesc1);
            buttonLabels.Add(task2, thmdesc2);
            buttonLabels.Add(task3, thmdesc3);
            buttonLabels.Add(task4, thmdesc4);
            buttonLabels.Add(task5, thmdesc5);

            // Присвоює дії до всіх кнопок та лейблів у списку
            foreach (var buttonLabel in buttonLabels)
            {
                buttonLabel.Key.MouseEnter += Button_MouseEnter;
                buttonLabel.Key.MouseLeave += Button_MouseLeave;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Отримати мітку для відповідної кнопки та зробити її видимою
            var button = (Button)sender;
            var label = buttonLabels[button];
            label.Visible = true;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Отримати мітку для відповідної кнопки та зробити її невидимою
            var button = (Button)sender;
            var label = buttonLabels[button];
            label.Visible = false;
        }

        private void ShowTask(int taskNumber, Type taskType, Size formSize, string formTitle)
        {
            // Змінюємо місце розташування вікна
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);

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
            taskControl.Size = new Size(formSize.Width - 15, formSize.Height - 45);
        }

        private void task1_Click(object sender, EventArgs e)
        {
            ShowTask(1, typeof(usrTask1), new Size(815, 535), "Learning My English Task #1");
        }

        private void task2_Click(object sender, EventArgs e)
        {
            ShowTask(2, typeof(usrTask2), new Size(1055, 535), "Learning My English Task #2");
        }

        private void task3_Click(object sender, EventArgs e)
        {
            ShowTask(3, typeof(usrTask3), new Size(735, 545), "Learning My English Task #3");
        }

        private void task4_Click(object sender, EventArgs e)
        {
            ShowTask(4, typeof(usrTask4), new Size(935, 575), "Learning My English Task #4");
        }

        private void task5_Click(object sender, EventArgs e)
        {
            ShowTask(5, typeof(usrTask5), new Size(705, 575), "Learning My English Task #5");
        }
    }
}
