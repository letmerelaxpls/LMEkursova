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
    public partial class usrTask3 : UserControl
    {
        public delegate void ResizeFormDelegate(int width, int height);
        public event ResizeFormDelegate ResizeFormEvent;
        public usrTask3()
        {
            InitializeComponent();
            this.ResizeFormEvent += usrTask3_ResizeFormEvent;
        }
        private void usrTask3_ResizeFormEvent(int width, int height)
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

                    if (control is usrTask3)
                        control.Hide();
                }
            }
        }

        private void check1_Click(object sender, EventArgs e)
        {
            double exPoints = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex1n1", ("have", ex1n1ans)},
                {"ex1n2", ("will be", ex1n2ans)},
                {"ex1n3", ("helps", ex1n3ans)},
                {"ex1n4", ("don`t tell", ex1n4ans)},
                {"ex1n5", ("miss", ex1n5ans)},
                {"ex1n6", ("will watch", ex1n6ans)},
                {"ex1n7", ("will sleep", ex1n7ans)},
                {"ex1n8", ("will see", ex1n8ans)},
                {"ex1n9", ("will go", ex1n9ans)},
                {"ex1n10", ("will not get", ex1n10ans)},
                {"ex1n11", ("buy", ex1n11ans)},
                {"ex1n12", ("buy", ex1n12ans)},
                {"ex1n13", ("will pass", ex1n13ans)},
                {"ex1n14", ("sells", ex1n14ans)},
                {"ex1n15", ("will be", ex1n15ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    exPoints += 6.66;
                else
                {
                    answerLabel.Text = correctAnswer;
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = $"Кількість балів: {exPoints}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task3ex1.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            double exPoints = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex2n1", ("would take", ex2n1ans)},
                {"ex2n2", ("was", ex2n2ans)},
                {"ex2n3", ("would pass", ex2n3ans)},
                {"ex2n4", ("would send", ex2n4ans)},
                {"ex2n5", ("would happen", ex2n5ans)},
                {"ex2n6", ("will buy", ex2n6ans)},
                {"ex2n7", ("doesn`t get", ex2n7ans)},
                {"ex2n8", ("lost", ex2n8ans)},
                {"ex2n9", ("closed", ex2n9ans)},
                {"ex2n10", ("were", ex2n10ans)},
                {"ex2n11", ("would catch", ex2n11ans)},
                {"ex2n12", ("has", ex2n12ans)},
                {"ex2n13", ("rag", ex2n13ans)},
                {"ex2n14", ("will buy", ex2n14ans)},
                {"ex2n15", ("work", ex2n15ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    exPoints += 6.66;
                else
                {
                    answerLabel.Text = correctAnswer;
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = $"Кількість балів: {exPoints}";
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task3ex2.Focus();
        }

        private void check3_Click(object sender, EventArgs e)
        {
            double exPoints = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex3n1", ("will not oversleep", ex3n1ans)},
                {"ex3n2", ("would go", ex3n2ans)},
                {"ex3n3", ("will be", ex3n3ans)},
                {"ex3n4", ("would come", ex3n4ans)},
                {"ex3n5", ("was", ex3n5ans)},
                {"ex3n6", ("had", ex3n6ans)},
                {"ex3n7", ("would write", ex3n7ans)},
                {"ex3n8", ("was", ex3n8ans)},
                {"ex3n9", ("were", ex3n9ans)},
                {"ex3n10", ("will go", ex3n10ans)},
                {"ex3n11", ("will be", ex3n11ans)},
                {"ex3n12", ("lose", ex3n12ans)},
                {"ex3n13", ("would look", ex3n13ans)},
                {"ex3n14", ("stopped", ex3n14ans)},
                {"ex3n15", ("would help", ex3n15ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    exPoints += 6.66;
                else
                {
                    answerLabel.Text = correctAnswer;
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = $"Кількість балів: {exPoints}";
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task3ex3.Focus();
        }

        private void check4_Click(object sender, EventArgs e)
        {
            double exPoints = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex4n1", ("had sold", ex4n1ans)},
                {"ex4n2", ("will pass", ex4n2ans)},
                {"ex4n3", ("watched", ex4n3ans)},
                {"ex4n4", ("doesn't stop", ex4n4ans)},
                {"ex4n5", ("would have helped", ex4n5ans)},
                {"ex4n6", ("would call", ex4n6ans)},
                {"ex4n7", ("had had", ex4n7ans)},
                {"ex4n8", ("were", ex4n8ans)},
                {"ex4n9", ("could", ex4n9ans)},
                {"ex4n10", ("makes", ex4n10ans)},
                {"ex4n11", ("didn't leave", ex4n11ans)},
                {"ex4n12", ("would take", ex4n12ans)},
                {"ex4n13", ("wins", ex4n13ans)},
                {"ex4n14", ("will not come", ex4n14ans)},
                {"ex4n15", ("would play", ex4n15ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    exPoints += 6.66;
                else
                {
                    answerLabel.Text = correctAnswer;
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = $"Кількість балів: {exPoints}";
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task3ex4.Focus();
        }

        private void check5_Click(object sender, EventArgs e)
        {
            double exPoints = 0;
            Dictionary<string, (string, Label)> answers = new Dictionary<string, (string, Label)>()
            {
                {"ex5n1", ("will catch", ex5n1ans)},
                {"ex5n2", ("had", ex5n2ans)},
                {"ex5n3", ("would phone", ex5n3ans)},
                {"ex5n4", ("would stay", ex5n4ans)},
                {"ex5n5", ("had visited", ex5n5ans)},
                {"ex5n6", ("studied", ex5n6ans)},
                {"ex5n7", ("will understand", ex5n7ans)},
                {"ex5n8", ("would have seen", ex5n8ans)},
                {"ex5n9", ("invite", ex5n9ans)},
                {"ex5n10", ("would be", ex5n10ans)},
                {"ex5n11", ("would have taken", ex5n11ans)},
                {"ex5n12", ("stops", ex5n12ans)},
                {"ex5n13", ("have", ex5n13ans)},
                {"ex5n14", ("will take", ex5n14ans)},
                {"ex5n15", ("drove", ex5n15ans)}
            };

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    exPoints += 6.66;
                else
                {
                    answerLabel.Text = correctAnswer;
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck5.Text = $"Кількість балів: {exPoints}";
            pointscheck5.BorderStyle = BorderStyle.FixedSingle;
            pointscheck5.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check5.Enabled = false;
            task3ex5.Focus();
        }
    }
}
