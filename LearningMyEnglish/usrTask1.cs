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
    public partial class usrTask1 : UserControl
    {
        public delegate void ResizeFormDelegate(int width, int height);
        public event ResizeFormDelegate ResizeFormEvent;
        public usrTask1()
        {
            InitializeComponent();
            this.ResizeFormEvent += usrTask1_ResizeFormEvent;
        }

        private void usrTask1_ResizeFormEvent(int width, int height)
        {
            // Встановлює місце після закриття правила
            this.ParentForm.DesktopLocation = new System.Drawing.Point(500, 250);

            // Повертає макс та мін розміри вікна меню
            this.ParentForm.MaximumSize = new Size(610, 355);
            this.ParentForm.MinimumSize = new Size(610, 355);

            // Встановлюємо новий розмір форми
            this.ParentForm.Width = width;
            this.ParentForm.Height = height;
        }

        private void check1_Click(object sender, EventArgs e)
        {

            double vpr1points = 0;
            // Додача балів до правильних відповідей
            if (n1v2.Checked) vpr1points += 12.5;
            if (n2v1.Checked) vpr1points += 12.5;
            if (n3v1.Checked) vpr1points += 12.5;
            if (n4v2.Checked) vpr1points += 12.5;
            if (n5v1.Checked) vpr1points += 12.5;
            if (n6v1.Checked) vpr1points += 12.5;
            if (n7v2.Checked) vpr1points += 12.5;
            if (n8v1.Checked) vpr1points += 12.5;

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = ("Кількість балів: " + vpr1points.ToString());
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            pointscheck1.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {

            double vpr2points = 0;
            // Додача балів до правильних відповідей
            if (ex2n1ans.Text == "saw") vpr2points += 10;
            if (ex2n2ans.Text == "will be recieved") vpr2points += 10;
            if (ex2n3ans.Text == "will give") vpr2points += 10;
            if (ex2n4ans.Text == "be found") vpr2points += 10;
            if (ex2n5ans.Text == "will show" || ex2n5ans.Text == "shall show") vpr2points += 10;
            if (ex2n6ans.Text == "find") vpr2points += 10;
            if (ex2n7ans.Text == "is divided") vpr2points += 10;
            if (ex2n8ans.Text == "reads") vpr2points += 10;
            if (ex2n9ans.Text == "is read") vpr2points += 10;
            if (ex2n10ans.Text == "was built" || ex2n10ans.Text == "is built") vpr2points += 10;

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = ("Кількість балів: " + vpr2points.ToString());
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            pointscheck2.Focus();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            // Змінює розмір вікна на розмір меню
            this.ResizeFormEvent?.Invoke(610, 355);
            // Повертає всі контроли окрім цього
            Form form = this.FindForm();
            form.Text = "Learning My English Menu";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    control.Show();

                    if (control is usrTask1)
                    {
                        control.Hide();
                    }

                }
            }
        }
    }
}
