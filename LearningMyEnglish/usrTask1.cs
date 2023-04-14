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
        public usrTask1()
        {
            InitializeComponent();

        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            BackToMenu.GoBack(this);
        }

        private void check1_Click(object sender, EventArgs e)
        {
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
            double points = TaskChecker.CheckTaskV1(this, correctAnswers, 12.5);

            pointscheck1.Text = $"Кількість балів: {points}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;

            check1.Enabled = false;
            task1ex1.Focus();
        }
        private void check2_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> correctAnswers = new Dictionary<string, (string, Label)>()
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

            double points = TaskChecker.CheckTaskV2(this, correctAnswers, 10);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = $"Кількість балів: {points}";
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task1ex2.Focus();
        }
        private void check3_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> correctAnswers = new Dictionary<string, (string, Label)>()
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

            double points = TaskChecker.CheckTaskV2(this, correctAnswers, 5);
            
            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = $"Кількість балів: {points}";
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task1ex3.Focus();
        }
        private void check4_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, TextBox)> correctAnswers = new Dictionary<string, (string, TextBox)>()
            {
                {"ex4n1ans", ("The freshman was laughed at", ex4answers)},
                {"ex4n2ans", ("The headmistress was spoken to yesterday", ex4answers)},
                {"ex4n3ans", ("The babies were looked after with great care", ex4answers)},
                {"ex4n4ans", ("That old house wasn`t lived in", ex4answers)},
                { "ex4n5ans", ("Jim was sent for and told to prepare a report on that subject", ex4answers)},
                { "ex4n6ans", ("Our friend was thought about all the time", ex4answers)},
                { "ex4n7ans", ("He will be operated on in a week", ex4answers)},
                { "ex4n8ans", ("The pupil`s parents were sent for", ex4answers)},
                { "ex4n9ans", ("The newspaper was looked for everywhere", ex4answers)},
                { "ex4n10ans", ("The bed wasn`t slept in", ex4answers)},
                { "ex4n11ans", ("The telegram was asked for", ex4answers)},
                { "ex4n12ans", ("The lecturer was listened to with great attention", ex4answers)}
            };

            double points = TaskChecker.CheckTaskV3(this, correctAnswers, 8.33);
            
            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = $"Кількість балів: {points}";
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task1ex4.Focus();
        }
    }
}
