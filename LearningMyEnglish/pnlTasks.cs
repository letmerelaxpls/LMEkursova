using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public delegate void ResizeFormDelegate(int width, int height);
        public event ResizeFormDelegate ResizeFormEvent;

        // Список кнопок та лейблів
        private Dictionary<Button, Label> buttonLabels = new Dictionary<Button, Label>();

        public pnlTasks()
        {
            InitializeComponent();
            this.ResizeFormEvent += pnlTasks_ResizeFormEvent;
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

        private void pnlTasks_ResizeFormEvent(int width, int height)
        {
            // Встановлюємо новий розмір форми
            this.ParentForm.Width = width;
            this.ParentForm.Height = height;
        }

        private void task1_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(905, 535);
            this.ParentForm.MinimumSize = new Size(905, 535);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(905, 535);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #1";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();
                    if(control is usrTask1)
                    {
                        control.Show();
                    }
                }
            }
            // Створює новий екземпляр UserControl
            var usrTask1 = new usrTask1();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrTask1);
            usrTask1.Location = new Point(1, 1);
            usrTask1.Size = new Size(890, 495);
        }

        private void task2_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(1055, 535);
            this.ParentForm.MinimumSize = new Size(1055, 535);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(1055, 535);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #2";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();
                    if (control is usrTask2)
                    {
                        control.Show();
                    }
                }
            }
            // Створює новий екземпляр UserControl
            var usrTask2 = new usrTask2();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrTask2);
            usrTask2.Location = new Point(1, 1);
            usrTask2.Size = new Size(1040, 495);
        }
    }
}
