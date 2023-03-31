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
            // Встановлюємо новий розмір форми
            this.ParentForm.Width = width;
            this.ParentForm.Height = height;
        }
        private void rule1_Click(object sender, EventArgs e)
        {

            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(810, 535);
            this.ParentForm.MinimumSize = new Size(810, 535);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(810, 535);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Rule #1";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrRule1)
                    {
                        control.Show();
                    }
                }
            }
            // Створює новий екземпляр UserControl
            var usrRule1 = new usrRule1();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrRule1);
            usrRule1.Location = new Point(1, 1);
            usrRule1.Size = new Size(795, 495);
        }

        private void rules2_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 150);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(645, 575);
            this.ParentForm.MinimumSize = new Size(645, 575);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(645, 575);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Rule #2";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();
                    if (control is usrRule2)
                    {
                        control.Show();
                    }
                }
            }
            // Створюємо новий екземпляр UserControl
            var usrRule2 = new usrRule2();
            // Додаємо UserControl на форму Form1
            this.ParentForm.Controls.Add(usrRule2);
            usrRule2.Location = new Point(1, 1);
            usrRule2.Size = new Size(630, 535);
        }

        private void rules3_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(400, 50);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(741, 705);
            this.ParentForm.MinimumSize = new Size(741, 705);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(741, 705);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Rule #3";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrRule3)
                    {
                        control.Show();
                    }
                }
            }
            // Створює новий екземпляр UserControl
            var usrRule3 = new usrRule3();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrRule3);
            usrRule3.Location = new Point(1, 1);
            usrRule3.Size = new Size(726, 665);
        }

        private void rules4_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(200, 50);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(945, 745);
            this.ParentForm.MinimumSize = new Size(945, 745);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(945, 745);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Rule #4";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrRule4)
                    {
                        control.Show();
                    }
                }
            }
            // Створює новий екземпляр UserControl
            var usrRule4 = new usrRule4();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrRule4);
            usrRule4.Location = new Point(1, 1);
            usrRule4.Size = new Size(930, 705);
        }

        private void rules5_Click(object sender, EventArgs e)
        {
            // Змінює місце росположення вікна після кліку
            this.ParentForm.DesktopLocation = new System.Drawing.Point(200, 50);
            // Змінює макс та мін розмір вікна
            this.ParentForm.MaximumSize = new Size(755, 670);
            this.ParentForm.MinimumSize = new Size(755, 670);
            // Змінює сам розмір вікна
            this.ResizeFormEvent?.Invoke(755, 670);
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            form.Text = "Learning My English Rule #5";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Hide();

                    if (control is usrRule5)
                    {
                        control.Show();
                    }
                }
            }
            // Створює новий екземпляр UserControl
            var usrRule5 = new usrRule5();
            // Додає UserControl на форму Form1
            this.ParentForm.Controls.Add(usrRule5);
            usrRule5.Location = new Point(1, 1);
            usrRule5.Size = new Size(740, 630);
        }
    }
}
