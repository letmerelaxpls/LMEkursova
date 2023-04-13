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
    public partial class usrTask5 : UserControl
    {
        public usrTask5()
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

                    if (control is usrTask4)
                        control.Hide();
                }
            }
        }

        private void check1_Click(object sender, EventArgs e)
        {
            int i = 0;
            double exPoints = 0;
            Dictionary<string, string> answers = new Dictionary<string, string>()
            {
                {"ex1n1", "he had been watching TV the night before"},
                {"ex1n2", "she had seen the accident at the corner of High Street"},
                {"ex1n3", "they had had a wonderful time at Peter's party"},
                {"ex1n4", "he hadn't seen her"},
                {"ex1n5", "they had been very happy about the present"},
                {"ex1n6", "as a young boy he had collected stickers"},
                {"ex1n7", "they had played a lot of tennis the year before"},
                {"ex1n8", "she had a headache"},
                {"ex1n9", "they had driven right down to Athens the summer before"},
                {"ex1n10", "she was watching the late-night show"},
                {"ex1n11", "they had been interested in other countries"},
                {"ex1n12", "he took his medicine regularly"},
                {"ex1n13", "she didn't feel better then"},
                {"ex1n14", "her father took her to school every day"},
                {"ex1n15", "he was a farmer in Cornwall"}
            };

            foreach (var item in answers)
            {
                i++;
                var key = item.Key;
                var userAnswer = Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    exPoints += 8.33;
                else
                {
                    ex1answers.Text += $"{i}. {correctAnswer}\r\n";
                    userAnswer.ForeColor = Color.Red;
                }
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = $"Кількість балів: {exPoints}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task5ex1a.Focus();
        }
    }
}
