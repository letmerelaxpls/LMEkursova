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
    public partial class usrTask4 : UserControl
    {
        public usrTask4()
        {
            InitializeComponent();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            BackToMenu.GoBack(this);
        }

        private void check1_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> correctAnswers = new Dictionary<string, (string, Label)>()
            {
                {"ex1n1", ("not to be", ex1n1ans)},
                {"ex1n2", ("looking", ex1n2ans)},
                {"ex1n3", ("to stop", ex1n3ans)},
                {"ex1n4", ("being", ex1n4ans)},
                {"ex1n5", ("to take", ex1n5ans)},
                {"ex1n6", ("doing", ex1n6ans)},
                {"ex1n7", ("to leave", ex1n7ans)},
                {"ex1n8", ("not to wait", ex1n8ans)},
                {"ex1n9", ("to finish", ex1n9ans)},
                {"ex1n10", ("to be", ex1n10ans)},
                {"ex1n11", ("not to touch", ex1n11ans)},
                {"ex1n12", ("renting", ex1n12ans)},
                {"ex1n13", ("making", ex1n13ans)},
                {"ex1n14", ("smoke", ex1n14ans)}
            };

            double points = TaskChecker.CheckTaskV2(this, correctAnswers, 7.14);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = $"Кількість балів: {points}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task4ex1.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> correctAnswers = new Dictionary<string, (string, Label)>()
            {
                {"ex2n1", ("leaving", ex2n1ans)},
                {"ex2n2", ("to working", ex2n2ans)},
                {"ex2n3", ("hearing", ex2n3ans)},
                {"ex2n4", ("go", ex2n4ans)},
                {"ex2n5", ("having", ex2n5ans)},
                {"ex2n6", ("cleaning", ex2n6ans)},
                {"ex2n7", ("to pass", ex2n7ans)},
                {"ex2n8", ("not to go", ex2n8ans)},
                {"ex2n9", ("to cook", ex2n9ans)},
                {"ex2n10a", ("listening", ex2n10ans)},
                {"ex2n10b", ("not to believe", ex2n10ans)},
                {"ex2n11", ("asking", ex2n11ans)},
                {"ex2n12", ("to call", ex2n12ans)},
                {"ex2n13", ("to look", ex2n13ans)},
                {"ex2n14", ("to arrive", ex2n14ans)},
                {"ex2n15", ("to play", ex2n15ans)},
            };

            double points = TaskChecker.CheckTaskV2(this, correctAnswers, 6.66);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = $"Кількість балів: {points}";
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task4ex2.Focus();
        }

        private void check3_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> correctAnswers = new Dictionary<string, (string, Label)>()
            {
                {"ex3n1", ("playing", ex3n1ans)},
                {"ex3n2", ("to be", ex3n2ans)},
                {"ex3n3", ("staying", ex3n3ans)},
                {"ex3n4", ("to see", ex3n4ans)},
                {"ex3n5", ("smoking", ex3n5ans)},
                {"ex3n6", ("stealing", ex3n6ans)},
                {"ex3n7", ("waiting", ex3n7ans)},
                {"ex3n8", ("to hold", ex3n8ans)},
                {"ex3n9", ("making", ex3n9ans)},
                {"ex3n10", ("coming", ex3n10ans)},
                {"ex3n11", ("to give", ex3n11ans)},
                {"ex3n12", ("to smoke", ex3n12ans)}
            };

            double points = TaskChecker.CheckTaskV2(this, correctAnswers, 8.33);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = $"Кількість балів: {points}";
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task4ex3.Focus();
        }

        private void check4_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> correctAnswers = new Dictionary<string, (string, Label)>()
            {
                {"ex4n1", ("repairing", ex4n1ans)},
                {"ex4n2", ("to call", ex4n2ans)},
                {"ex4n3", ("going", ex4n3ans)},
                {"ex4n4", ("taking", ex4n4ans)},
                {"ex4n5", ("to give", ex4n5ans)},
                {"ex4n6", ("carrying", ex4n6ans)},
                {"ex4n7", ("to read", ex4n7ans)},
                {"ex4n8", ("understanding", ex4n8ans)},
                {"ex4n9", ("talking", ex4n9ans)},
                {"ex4n10", ("to get", ex4n10ans)},
                {"ex4n11", ("smoking", ex4n11ans)},
                {"ex4n12", ("to enrol", ex4n12ans)},
                {"ex4n13", ("to go", ex4n13ans)},
                {"ex4n14", ("affording", ex4n14ans)},
            };

            double points = TaskChecker.CheckTaskV2(this, correctAnswers, 7.14);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = $"Кількість балів: {points}";
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task4ex4.Focus();
        }
    }
}
