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
    public partial class usrTask2 : UserControl
    {
        public delegate void ResizeFormDelegate(int width, int height);
        public event ResizeFormDelegate ResizeFormEvent;
        public usrTask2()
        {
            InitializeComponent();
            this.ResizeFormEvent += usrTask2_ResizeFormEvent;
        }
        private void usrTask2_ResizeFormEvent(int width, int height)
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

                    if (control is usrTask2)
                    {
                        control.Hide();
                    }

                }
            }
        }

        private void check1_Click(object sender, EventArgs e)
        {
            int vpr1points = 0;
            // Додача балів до правильних відповідей
            if (p1v1.Checked) vpr1points += 20;
            else
            {
                p1v1.ForeColor = Color.LimeGreen;
                p1v2.ForeColor = Color.Red;
            }

            if (p2v2.Checked) vpr1points += 20;
            else
            {
                p2v2.ForeColor = Color.LimeGreen;
                p2v1.ForeColor = Color.Red;
            }

            if (p3v2.Checked) vpr1points += 20;
            else
            {
                p3v2.ForeColor = Color.LimeGreen;
                p3v1.ForeColor = Color.Red;
            }

            if (p4v1.Checked) vpr1points += 20;
            else
            {
                p4v1.ForeColor = Color.LimeGreen;
                p4v2.ForeColor = Color.Red;
            }

            if (p5v2.Checked) vpr1points += 20;
            else
            {
                p5v2.ForeColor = Color.LimeGreen;
                p5v1.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = ("Кількість балів: " + vpr1points.ToString());
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task2ex1.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            int vpr2points = 0;

            if (ex2n1.Text == "has been driving") vpr2points += 20;
            else
            {
                ex2n1ans.Text = "has been driving";
                ex2n1ans.BorderStyle = BorderStyle.FixedSingle;
                ex2n1.ForeColor = Color.Red;
            }

            if (ex2n2.Text == "hadn`t been watching" || ex2n2.Text == "had not been watching") vpr2points += 20;
            else
            {
                ex2n2ans.Text = "hadn`t been watching OR had not been watching";
                ex2n2ans.BorderStyle = BorderStyle.FixedSingle;
                ex2n2.ForeColor = Color.Red;
            }

            if (ex2n3.Text == "Have you been taking") vpr2points += 20;
            else
            {
                ex2n3ans.Text = "Have you been taking";
                ex2n3ans.BorderStyle = BorderStyle.FixedSingle;
                ex2n3.ForeColor = Color.Red;
            }

            if (ex2n4.Text == "had been looking") vpr2points += 20;
            else
            {
                ex2n4ans.Text = "had been looking";
                ex2n4ans.BorderStyle = BorderStyle.FixedSingle;
                ex2n4.ForeColor = Color.Red;
            }

            if (ex2n51.Text == "had" && ex2n52.Text == "been working") vpr2points += 5;
            else
            {
                if (ex2n51.Text != "had") ex2n51.ForeColor = Color.Red;
                if (ex2n52.Text != "been working") ex2n52.ForeColor = Color.Red;
                ex2n5ans.Text = "had been working";
                ex2n5ans.BorderStyle = BorderStyle.FixedSingle;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = ("Кількість балів: " + vpr2points.ToString());
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task2ex2.Focus();
        }

        private void check3_Click(object sender, EventArgs e)
        {
            int vpr3points = 0;

            if (ex3n1.Text == "since") vpr3points += 20;
            else
            {
                ex3n1ans.Text = "since";
                ex3n1ans.BorderStyle = BorderStyle.FixedSingle;
                ex3n1.ForeColor = Color.Red;
            }

            if (ex3n2.Text == "the week before") vpr3points += 20;
            else
            {
                ex3n2ans.Text = "the week before";
                ex3n2ans.BorderStyle = BorderStyle.FixedSingle;
                ex3n2.ForeColor = Color.Red;
            }

            if (ex3n3.Text == "by tomorrow") vpr3points += 20;
            else
            {
                ex3n3ans.Text = "by tomorrow";
                ex3n3ans.BorderStyle = BorderStyle.FixedSingle;
                ex3n3.ForeColor = Color.Red;
            }

            if (ex3n4.Text == "for") vpr3points += 20;
            else
            {
                ex3n4ans.Text = "for";
                ex3n4ans.BorderStyle = BorderStyle.FixedSingle;
                ex3n4.ForeColor = Color.Red;
            }

            if (ex3n5.Text == "so far") vpr3points += 5;
            else
            {
                ex3n5ans.Text = "so far";
                ex3n5ans.BorderStyle = BorderStyle.FixedSingle;
                ex3n5.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = ("Кількість балів: " + vpr3points.ToString());
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task2ex3.Focus();
        }

        private void check4_Click(object sender, EventArgs e)
        {
            int vpr4points = 0;
            // Додача балів до правильних відповідей
            if (ex4p1v2.Checked) vpr4points += 20;
            else
            {
                ex4p1v2.ForeColor = Color.LimeGreen;
                ex4p1v1.ForeColor = Color.Red;
                ex4p1v3.ForeColor = Color.Red;
            }

            if (ex4p2v1.Checked) vpr4points += 20;
            else
            {
                ex4p2v1.ForeColor = Color.LimeGreen;
                ex4p2v2.ForeColor = Color.Red;
                ex4p2v3.ForeColor = Color.Red;
            }

            if (ex4p3v3.Checked) vpr4points += 20;
            else
            {
                ex4p3v3.ForeColor = Color.LimeGreen;
                ex4p3v1.ForeColor = Color.Red;
                ex4p3v2.ForeColor = Color.Red;
            }

            if (ex4p4v3.Checked) vpr4points += 20;
            else
            {
                ex4p4v3.ForeColor = Color.LimeGreen;
                ex4p4v2.ForeColor = Color.Red;
                ex4p4v1.ForeColor = Color.Red;
            }

            if (ex4p5v2.Checked) vpr4points += 20;
            else
            {
                ex4p5v2.ForeColor = Color.LimeGreen;
                ex4p5v1.ForeColor = Color.Red;
                ex4p5v3.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = ("Кількість балів: " + vpr4points.ToString());
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task2ex4.Focus();
        }

        private void check5_Click(object sender, EventArgs e)
        {
            double vpr5points = 0;
            // Додача балів до правильних відповідей
            if (ex5n1.Text == "Jane has lost weight. She has been dieting for months now") vpr5points += 20;
            else
            {
                ex5answers.Text += "1. Jane has lost weight. She has been dieting for months now\r\n";
                ex5n1.ForeColor = Color.Red;
            }

            if (ex5n2.Text == "Everything was white when we woke up because it had been snowing all night") vpr5points += 20;
            else
            {
                ex5answers.Text += "2. Everything was white when we woke up because it had been snowing all night\r\n";
                ex5n2.ForeColor = Color.Red;
            }

            if (ex5n3.Text == "I was so happy when he asked me to marry him. I have loved him for years") vpr5points += 20;
            else
            {
                ex5answers.Text += "3. I was so happy when he asked me to marry him. I have loved him for years\r\n";
                ex5n3.ForeColor = Color.Red;
            }

            if (ex5n4.Text == "That man is making me nervous. He has been staring at me all evening") vpr5points += 20;
            else
            {
                ex5answers.Text += "4. That man is making me nervous. He has been staring at me all evening\r\n";
                ex5n4.ForeColor = Color.Red;
            }

            if (ex5n5.Text == "Hurry up, or they will have sold all the tickets by the time we get there") vpr5points += 20;
            else
            {
                ex5answers.Text += "5. Hurry up, or they will have sold all the tickets by the time we get there\r\n";
                ex5n5.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck5.Text = ("Кількість балів: " + vpr5points.ToString());
            pointscheck5.BorderStyle = BorderStyle.FixedSingle;
            pointscheck5.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check5.Enabled = false;
            task2ex5.Focus();
        }

       
    }
}
