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
            BackToMenu.GoBack(this);
        }

        private void check1_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, TextBox)> correctAnswers = new Dictionary<string, (string, TextBox)>()
            {
                {"ex1n1", ("he had been watching TV the night before", ex1answers)},
                {"ex1n2", ("she had seen the accident at the corner of High Street", ex1answers)},
                {"ex1n3", ("they had had a wonderful time at Peter's party", ex1answers)},
                {"ex1n4", ("he hadn't seen her", ex1answers)},
                {"ex1n5", ("they had been very happy about the present", ex1answers)},
                {"ex1n6", ("as a young boy he had collected stickers", ex1answers)},
                {"ex1n7", ("they had played a lot of tennis the year before", ex1answers)},
                {"ex1n8", ("she had a headache", ex1answers)},
                {"ex1n9", ("they had driven right down to Athens the summer before", ex1answers)},
                {"ex1n10", ("she was watching the late-night show", ex1answers)},
                {"ex1n11", ("they had been interested in other countries", ex1answers)},
                {"ex1n12", ("he took his medicine regularly", ex1answers)},
                {"ex1n13", ("she didn't feel better then", ex1answers)},
                {"ex1n14", ("her father took her to school every day", ex1answers)},
                {"ex1n15", ("he was a farmer in Cornwall", ex1answers)}
            };

            double points = TaskChecker.CheckTaskV3(this, correctAnswers, 6.66);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = $"Кількість балів: {points}";
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task5ex1a.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, TextBox)> correctAnswers = new Dictionary<string, (string, TextBox)>()
            {
                { "ex2n1", ("her sister worked in Manchester", ex2answers)},
                {"ex2n2", ("he felt terrible", ex2answers)},
                {"ex2n3", ("they didn't know the way to the police station", ex2answers)},
                {"ex2n4", ("she heard strange noises in her garden every night", ex2answers)},
                {"ex2n5", ("he met his friend on the way to school", ex2answers)},
                {"ex2n6", ("her children like fish and chips", ex2answers)},
                {"ex2n7", ("the tickets for the show were very expensive", ex2answers)},
                {"ex2n8", ("Mr O'Connor sells the best meat around there", ex2answers)},
                {"ex2n9", ("they could watch TV every Saturday night", ex2answers)},
                {"ex2n10", ("she had to help her mother in the kitchen every evening", ex2answers)},
                {"ex2n11", ("he was looking for his key", ex2answers)},
                {"ex2n12", ("she liked something to drink", ex2answers)},
                {"ex2n13", ("their car made such a noise", ex2answers)},
                {"ex2n14", ("she was visiting her the following Monday", ex2answers)},
                {"ex2n15", ("he didn't invite her to the party", ex2answers)}
            };

            double points = TaskChecker.CheckTaskV3(this, correctAnswers, 6.66);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = $"Кількість балів: {points}";
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task5ex2a.Focus();
        }

        private void check3_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, TextBox)> correctAnswers = new Dictionary<string, (string, TextBox)>()
            {
                {"ex3n1", ("she likes ice cream", ex3answers)},
                {"ex3n2", ("they were on time", ex3answers)},
                {"ex3n3", ("he was sitting on the table", ex3answers)},
                {"ex3n4", ("Bill always goes to bed early", ex3answers)},
                {"ex3n5", ("she often drove (drives) to London", ex3answers)},
                {"ex3n6", ("he was going to answer the phone", ex3answers)},
                {"ex3n7", ("she wasn't doing her homework then", ex3answers)},
                {"ex3n8", ("he always sells all his flowers", ex3answers)},
                {"ex3n9", ("I could help her with the dishes", ex3answers)},
                {"ex3n10", ("he meets him every Friday", ex3answers)},
                {"ex3n11", ("he left that night", ex3answers)},
                {"ex3n12", ("he was watching TV", ex3answers)},
                {"ex3n13", ("she likes roast beef", ex3answers)},
                {"ex3n14", ("they bought a newspaper every day", ex3answers)},
                {"ex3n15", ("they were flying to New York", ex3answers)}
            };

            double points = TaskChecker.CheckTaskV3(this, correctAnswers, 6.66);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = $"Кількість балів: {points}";
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task5ex3a.Focus();
        }

        private void check4_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, TextBox)> correctAnswers = new Dictionary<string, (string, TextBox)>()
            {
                {"ex4n1", ("he was looking forward to his holidays", ex4answers)},
                {"ex4n2", ("they had had a day away at the beach", ex4answers)},
                {"ex4n3", ("his mum had taken them to an alligator farm", ex4answers)},
                {"ex4n4", ("there was a big pool with lots of alligators", ex4answers)},
                {"ex4n5", ("she didn't like alligator meat", ex4answers)},    
                {"ex4n6", ("they had never seen such a beautiful view", ex4answers)},
                {"ex4n7", ("her dad worked (works) in town", ex4answers)},
                {"ex4n8", ("they spent their holidays on a farm every year", ex4answers)},
                {"ex4n9", ("they had gone for a picnic", ex4answers)},
                {"ex4n10", ("his brother had come home late", ex4answers)},
                {"ex4n11", ("he was looking for his key", ex4answers)},
                {"ex4n12", ("they had bought a farmhouse in the country", ex4answers)},
                {"ex4n13", ("he had been to the top of the Empire State Building", ex4answers)},
                {"ex4n14", ("she had forgotten to give him her address", ex4answers)},
                {"ex4n15", ("he likes science fiction books", ex4answers)}
            };

            double points = TaskChecker.CheckTaskV3(this, correctAnswers, 6.66);

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = $"Кількість балів: {points}";
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task5ex4a.Focus();
        }
    }
}
