﻿using System;
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

       

        private void task1_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(905, 535);
            this.ParentForm.MinimumSize = new Size(905, 535);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #1";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if(control is usrTask1)
                        control.Show();
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
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #2";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrTask2)
                        control.Show();
                }
            }
            // Створює новий екземпляр UserControl
            var usrTask2 = new usrTask2();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrTask2);
            usrTask2.Location = new Point(1, 1);
            usrTask2.Size = new Size(1040, 495);
        }

        private void task3_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(785, 545);
            this.ParentForm.MinimumSize = new Size(785, 545);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #3";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrTask3)
                        control.Show();
                }
            }
            // Створює новий екземпляр UserControl
            var usrTask3 = new usrTask3();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrTask3);
            usrTask3.Location = new Point(1, 1);
            usrTask3.Size = new Size(770, 505);
        }

        private void task4_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(935, 575);
            this.ParentForm.MinimumSize = new Size(935, 575);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #4";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrTask4)
                        control.Show();
                }
            }
            // Створює новий екземпляр UserControl
            var usrTask4 = new usrTask4();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrTask4);
            usrTask4.Location = new Point(1, 1);
            usrTask4.Size = new Size(920, 535);
        }

        private void task5_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(735, 575);
            this.ParentForm.MinimumSize = new Size(735, 575);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Task #5";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrTask5)
                        control.Show();
                }
            }
            // Створює новий екземпляр UserControl
            var usrTask5 = new usrTask5();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrTask5);
            usrTask5.Location = new Point(1, 1);
            usrTask5.Size = new Size(720, 535);
        }
    }
}
