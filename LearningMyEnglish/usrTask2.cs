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
        public usrTask2()
        {
            InitializeComponent();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            // Встановлює місце після закриття правила
            this.ParentForm.DesktopLocation = new System.Drawing.Point(500, 250);
            // Повертає макс та мін розміри вікна меню
            this.ParentForm.MaximumSize = new Size(610, 355);
            this.ParentForm.MinimumSize = new Size(610, 355);
            // Повертає всі контроли окрім цього
            Form form = this.FindForm();
            form.Text = "Learning My English Menu";
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is pnlRules || control is pnlTasks)
                        control.Show();

                    if (control is usrTask2)
                        control.Hide();
                }
            }
        }

        private void check1_Click(object sender, EventArgs e)
        {
            int vpr1points = 0;
            Dictionary<string, string> correctAnswers = new Dictionary<string, string>()
            {
                {"ex1p1", "p1v1"},
                {"ex1p2", "p2v2"},
                {"ex1p3", "p3v2"},
                {"ex1p4", "p4v1"},
                {"ex1p5", "p5v2"}
            };

            foreach (var pair in correctAnswers)
            {
                var panel = Controls.Find(pair.Key, true).FirstOrDefault() as Panel;
                var selectedRadioButton = panel?.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (selectedRadioButton != null && selectedRadioButton.Name == pair.Value)
                    vpr1points += 20;
                else
                {
                    if (selectedRadioButton != null)
                        selectedRadioButton.BackColor = Color.Red;

                    RadioButton radioButton = panel.Controls.OfType<RadioButton>().Where(r => r.Name == pair.Value).FirstOrDefault();
                    if (radioButton != null)
                        radioButton.BackColor = Color.Green;
                }
            }

            
            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = $"Кількість балів: {vpr1points}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task2ex1.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            int vpr2points = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex2n1", ("has been driving", ex2n1ans)},
                {"ex2n2", ("hadn`t been watching", ex2n2ans)},
                {"ex2n3", ("Have you been taking", ex2n3ans)},
                {"ex2n4", ("had been looking", ex2n4ans)},
                {"ex2n51", ("had", ex2n5ans)},
                {"ex2n52", ("been working",  ex2n5ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    vpr2points += 20;
                else
                {
                    answerLabel.Text += $" {correctAnswer}";
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = $"Кількість балів: {vpr2points}";
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task2ex2.Focus();
        }

        private void check3_Click(object sender, EventArgs e)
        {
            int vpr3points = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex3n1", ("since", ex3n1ans)},
                {"ex3n2", ("the week before", ex3n2ans)},
                {"ex3n3", ("by tomorrow", ex3n3ans)},
                {"ex3n4", ("for", ex3n4ans)},
                {"ex3n5", ("so far", ex3n5ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    vpr3points += 20;
                else
                {
                    answerLabel.Text =  correctAnswer;
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = $"Кількість балів: {vpr3points}";
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task2ex3.Focus();
        }

        private void check4_Click(object sender, EventArgs e)
        {
            int vpr4points = 0;
            Dictionary<string, string> correctAnswers = new Dictionary<string, string>()
            {
                {"ex4p1", "ex4p1v2"},
                {"ex4p2", "ex4p2v1"},
                {"ex4p3", "ex4p3v3"},
                {"ex4p4", "ex4p4v3"},
                {"ex4p5", "ex4p5v2"}
            };

            foreach (var pair in correctAnswers)
            {
                var panel = Controls.Find(pair.Key, true).FirstOrDefault() as Panel;
                var selectedRadioButton = panel?.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (selectedRadioButton != null && selectedRadioButton.Name == pair.Value)
                    vpr4points += 20;
                else
                {
                    if (selectedRadioButton != null)
                        selectedRadioButton.BackColor = Color.Red;

                    RadioButton radioButton = panel.Controls.OfType<RadioButton>().Where(r => r.Name == pair.Value).FirstOrDefault();
                    if (radioButton != null)
                        radioButton.BackColor = Color.Green;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = $"Кількість балів: {vpr4points}";
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task2ex4.Focus();
        }

        private void check5_Click(object sender, EventArgs e)
        {
            double vpr5points = 0;
            int i = 0;
            Dictionary<string, string> answers = new Dictionary<string, string>()
            {
                {"ex5n1", "Jane has lost weight. She has been dieting for months now"},
                {"ex5n2", "Everything was white when we woke up because it had been snowing all night"},
                {"ex5n3", "I was so happy when he asked me to marry him. I have loved him for years"},
                {"ex5n4", "That man is making me nervous. He has been staring at me all evening"},
                {"ex5n5", "Hurry up, or they will have sold all the tickets by the time we get there"} 
            };

            foreach (var item in answers)
            {
                i++;
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    vpr5points += 20;
                else
                {
                    ex5answers.Text += $"{i}. {correctAnswer}\r\n";
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck5.Text = $"Кількість балів: {vpr5points}";
            pointscheck5.BorderStyle = BorderStyle.FixedSingle;
            pointscheck5.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check5.Enabled = false;
            task2ex5.Focus();
        }
    }
}
