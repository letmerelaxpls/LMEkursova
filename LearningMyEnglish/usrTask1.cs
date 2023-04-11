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
                    if (control is pnlRules || control is pnlTasks)
                        control.Show();

                    if (control is usrTask1)
                        control.Hide();
                }
            }
        }

        private void check1_Click(object sender, EventArgs e)
        {
            double vpr1points = 0;
            Dictionary<string, string> correctAnswers = new Dictionary<string, string>()
            {
                {"num1", "n1v2"},
                {"num2", "n2v1"},
                {"num3", "n3v1"},
                {"num4", "n4v2"},
                {"num5", "n5v1"},
                {"num6", "n6v1"},
                {"num7", "n7v2"},
                {"num8", "n8v1"}
            };

            foreach (var pair in correctAnswers)
            {
                var panel = Controls.Find(pair.Key, true).FirstOrDefault() as Panel;
                var selectedRadioButton = panel?.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (selectedRadioButton != null && selectedRadioButton.Name == pair.Value)
                {
                    vpr1points += 12.5;
                }
                else
                {
                    if (selectedRadioButton != null)
                        selectedRadioButton.BackColor = Color.Red;

                    RadioButton radioButton = panel.Controls.OfType<RadioButton>().Where(r => r.Name == pair.Value).FirstOrDefault();
                    if (radioButton != null)
                        radioButton.BackColor = Color.Green;
                }
            }

            pointscheck1.Text = $"Кількість балів: {vpr1points}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;

            check1.Enabled = false;
            task1ex1.Focus();
        }
        private void check2_Click(object sender, EventArgs e)
        {

            int vpr2points = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex2n1ans", ("saw", ex2ans1)},
                {"ex2n2ans", ("will be received", ex2ans2)},
                {"ex2n3ans", ("will give", ex2ans3)},
                {"ex2n4ans", ("be found", ex2ans4)},
                {"ex2n5ans", ("will show", ex2ans5)},
                {"ex2n6ans", ("find", ex2ans6)},
                {"ex2n7ans", ("is divided", ex2ans7)},
                {"ex2n8ans", ("reads", ex2ans8)},
                {"ex2n9ans", ("is read", ex2ans9)},
                {"ex2n10ans", ("was built", ex2ans10)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    vpr2points += 10;
                else
                {
                    answerLabel.Text = correctAnswer;
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
            task1ex2.Focus();
        }
        private void check3_Click(object sender, EventArgs e)
        {

            int vpr3points = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex3n1ans", ("was answered", ex3ans1)},
                {"ex3n2ans", ("is played", ex3ans2)},
                {"ex3n3ans", ("are gathered", ex3ans3)},
                {"ex3n4ans", ("were burnt", ex3ans4)},
                {"ex3n5ans", ("will be finished", ex3ans5)},
                {"ex3n6ans", ("are sold", ex3ans6)},
                {"ex3n7ans", ("is eaten", ex3ans7)},
                {"ex3n8ans", ("was received", ex3ans8)},
                {"ex3n9ans", ("will be sent", ex3ans9)},
                {"ex3n10ans", ("was asked", ex3ans10)},
                {"ex3n11ans", ("was given", ex3ans11)},
                {"ex3n12ans", ("are built", ex3ans12)},
                {"ex3n13ans", ("will be done", ex3ans13)},
                {"ex3n14ans", ("was translated", ex3ans14)},
                {"ex3n15ans", ("were planted", ex3ans15)},
                {"ex3n16ans", ("are always played", ex3ans16)},
                {"ex3n17ans", ("will be given", ex3ans17)},
                {"ex3n18ans", ("were invited", ex3ans18)},
                {"ex3n19ans", ("is never found", ex3ans19)},
                {"ex3n20ans", ("was not built", ex3ans20)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    vpr3points += 5;
                else
                {
                    answerLabel.Text = correctAnswer;
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
            task1ex3.Focus();
        }
        private void check4_Click(object sender, EventArgs e)
        {
            double vpr4points = 0;
            int i = 0;
            Dictionary<string, string> answers = new Dictionary<string, string>()
            {
                {"ex4n1ans", "The freshman was laughed at"},
                {"ex4n2ans", "The headmistress was spoken to yesterday"},
                {"ex4n3ans", "The babies were looked after with great care"},
                {"ex4n4ans", "That old house wasn`t lived in"},
                {"ex4n5ans", "Jim was sent for and told to prepare a report on that subject"},
                {"ex4n6ans", "Our friend was thought about all the time"},
                {"ex4n7ans", "He will be operated on in a week"},
                {"ex4n8ans", "The pupil`s parents were sent for"},
                {"ex4n9ans", "The newspaper was looked for everywhere"},
                {"ex4n10ans", "The bed wasn`t slept in"},
                {"ex4n11ans", "The telegram was asked for"},
                {"ex4n12ans", "The lecturer was listened to with great attention"}
            };

            foreach (var item in answers)
            {
                i++;
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    vpr4points += 8.33;
                else
                {
                    ex4answers.Text += $"{i}. {correctAnswer}\r\n";
                    userAnswer.ForeColor = Color.Red;
                }
            }
            
            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = $"Кількість балів: {vpr4points}";
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task1ex4.Focus();
        }
    }
}
