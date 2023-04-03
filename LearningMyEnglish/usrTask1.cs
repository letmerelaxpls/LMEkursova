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
                    control.Show();

                    if (control is usrTask1)
                    {
                        control.Hide();
                    }

                }
            }
        }

        private void check1_Click(object sender, EventArgs e)
        {

            double vpr1points = 0;
            // Додача балів до правильних відповідей
            if (n1v2.Checked) vpr1points += 12.5;
            else
            {
                n1v2.ForeColor = Color.LimeGreen;
                n1v1.ForeColor = Color.Red;
            }

            if (n2v1.Checked) vpr1points += 12.5;
            else
            {
                n2v1.ForeColor = Color.LimeGreen;
                n2v2.ForeColor = Color.Red;
            }

            if (n3v1.Checked) vpr1points += 12.5;
            else
            {
                n3v1.ForeColor = Color.LimeGreen;
                n3v2.ForeColor = Color.Red;
            }

            if (n4v2.Checked) vpr1points += 12.5;
            else
            {
                n4v2.ForeColor = Color.LimeGreen;
                n4v1.ForeColor = Color.Red;
            }

            if (n5v1.Checked) vpr1points += 12.5;
            else
            {
                n5v1.ForeColor = Color.LimeGreen;
                n5v2.ForeColor = Color.Red;
            }

            if (n6v1.Checked) vpr1points += 12.5;
            else
            {
                n6v1.ForeColor = Color.LimeGreen;
                n6v2.ForeColor = Color.Red;
            }

            if (n7v2.Checked) vpr1points += 12.5;
            else
            {
                n7v2.ForeColor = Color.LimeGreen;
                n7v1.ForeColor = Color.Red;
            }

            if (n8v1.Checked) vpr1points += 12.5;
            else
            {
                n8v1.ForeColor = Color.LimeGreen;
                n8v2.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck1.Text = ("Кількість балів: " + vpr1points.ToString());
            pointscheck1.BorderStyle = BorderStyle.FixedSingle;
            pointscheck1.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check1.Enabled = false;
            task1ex1.Focus();
        }

        private void check2_Click(object sender, EventArgs e)
        {

            int vpr2points = 0;
            // Додача балів до правильних відповідей
            if (ex2n1ans.Text == "saw") vpr2points += 10;
            else
            {
                ex2ans1.Text = "saw";
                ex2ans1.ForeColor = Color.LimeGreen;
                ex2ans1.BorderStyle = BorderStyle.FixedSingle;
                ex2n1ans.ForeColor = Color.Red;
            }

            if (ex2n2ans.Text == "will be recieved") vpr2points += 10;
            else
            {
                ex2ans2.Text = "will be received";
                ex2ans2.ForeColor = Color.LimeGreen;
                ex2ans2.BorderStyle = BorderStyle.FixedSingle;
                ex2n2ans.ForeColor = Color.Red;
            }

            if (ex2n3ans.Text == "will give") vpr2points += 10;
            else
            {
                ex2ans3.Text = "will give";
                ex2ans3.ForeColor = Color.LimeGreen;
                ex2ans3.BorderStyle = BorderStyle.FixedSingle;
                ex2n3ans.ForeColor = Color.Red;
            }

            if (ex2n4ans.Text == "be found") vpr2points += 10;
            else
            {
                ex2ans4.Text = "be found";
                ex2ans4.ForeColor = Color.LimeGreen;
                ex2ans4.BorderStyle = BorderStyle.FixedSingle;
                ex2n4ans.ForeColor = Color.Red;
            }

            if (ex2n5ans.Text == "will show" || ex2n5ans.Text == "shall show") vpr2points += 10;
            else
            {
                ex2ans5.Text = "will show OR shall show";
                ex2ans5.ForeColor = Color.LimeGreen;
                ex2ans5.BorderStyle = BorderStyle.FixedSingle;
                ex2n5ans.ForeColor = Color.Red;
            }

            if (ex2n6ans.Text == "find") vpr2points += 10;
            else
            {
                ex2ans6.Text = "find";
                ex2ans6.ForeColor = Color.LimeGreen;
                ex2ans6.BorderStyle = BorderStyle.FixedSingle;
                ex2n6ans.ForeColor = Color.Red;
            }

            if (ex2n7ans.Text == "is divided") vpr2points += 10;
            else
            {
                ex2ans7.Text = "is divided";
                ex2ans7.ForeColor = Color.LimeGreen;
                ex2ans7.BorderStyle = BorderStyle.FixedSingle;
                ex2n7ans.ForeColor = Color.Red;
            }

            if (ex2n8ans.Text == "reads") vpr2points += 10;
            else
            {
                ex2ans8.Text = "reads";
                ex2ans8.ForeColor = Color.LimeGreen;
                ex2ans8.BorderStyle = BorderStyle.FixedSingle;
                ex2n8ans.ForeColor = Color.Red;
            }

            if (ex2n9ans.Text == "is read") vpr2points += 10;
            else
            {
                ex2ans9.Text = "is read";
                ex2ans9.ForeColor = Color.LimeGreen;
                ex2ans9.BorderStyle = BorderStyle.FixedSingle;
                ex2n9ans.ForeColor = Color.Red;
            }
                
            if (ex2n10ans.Text == "was built" || ex2n10ans.Text == "is built") vpr2points += 10;
            else
            {
                ex2ans10.Text = "was built OR is built";
                ex2ans10.ForeColor = Color.LimeGreen;
                ex2ans10.BorderStyle = BorderStyle.FixedSingle;
                ex2n10ans.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck2.Text = ("Кількість балів: " + vpr2points.ToString());
            pointscheck2.BorderStyle = BorderStyle.FixedSingle;
            pointscheck2.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check2.Enabled = false;
            task1ex2.Focus();
        }

        private void check3_Click(object sender, EventArgs e)
        {

            int vpr3points = 0;
            // Додача балів до правильних відповідей
            if (ex3n1ans.Text == "was answered") vpr3points += 5;
            else
            {
                ex3ans1.Text = "was answered";
                ex3ans1.BorderStyle = BorderStyle.FixedSingle;
                ex3n1ans.ForeColor = Color.Red;
            }

            if (ex3n2ans.Text == "is played") vpr3points += 5;
            else
            {
                ex3ans2.Text = "is played";
                ex3ans2.BorderStyle = BorderStyle.FixedSingle;
                ex3n2ans.ForeColor = Color.Red;
            }

            if (ex3n3ans.Text == "are gathered") vpr3points += 5;
            else
            {
                ex3ans3.Text = "are gathered";
                ex3ans3.BorderStyle = BorderStyle.FixedSingle;
                ex3n3ans.ForeColor = Color.Red;
            }
                
            if (ex3n4ans.Text == "were burnt") vpr3points += 5;
            else
            {
                ex3ans4.Text = "were burnt";
                ex3ans4.BorderStyle = BorderStyle.FixedSingle;
                ex3n4ans.ForeColor = Color.Red;
            }

            if (ex3n5ans.Text == "will be finished") vpr3points += 5;
            else
            {
                ex3ans5.Text = "will be finished";
                ex3ans5.BorderStyle = BorderStyle.FixedSingle;
                ex3n5ans.ForeColor = Color.Red;
            }

            if (ex3n6ans.Text == "are sold") vpr3points += 5;
            else
            {
                ex3ans6.Text = "are sold";
                ex3ans6.BorderStyle = BorderStyle.FixedSingle;
                ex3n6ans.ForeColor = Color.Red;
            }
                
            if (ex3n7ans.Text == "is eaten") vpr3points += 5;
            else
            {
                ex3ans7.Text = "is eaten";
                ex3ans7.BorderStyle = BorderStyle.FixedSingle;
                ex3n7ans.ForeColor = Color.Red;
            }

            if (ex3n8ans.Text == "was received") vpr3points += 5;
            else
            {
                ex3ans8.Text = "was received";
                ex3ans8.BorderStyle = BorderStyle.FixedSingle;
                ex3n8ans.ForeColor = Color.Red;
            }

            if (ex3n9ans.Text == "will be sent") vpr3points += 5;
            else
            {
                ex3ans9.Text = "will be sent";
                ex3ans9.BorderStyle = BorderStyle.FixedSingle;
                ex3n9ans.ForeColor = Color.Red;
            }

            if (ex3n10ans.Text == "was asked") vpr3points += 5;
            else
            {
                ex3ans10.Text = "was asked";
                ex3ans10.BorderStyle = BorderStyle.FixedSingle;
                ex3n10ans.ForeColor = Color.Red;
            }

            if (ex3n11ans.Text == "was given") vpr3points += 5;
            else
            {
                ex3ans11.Text = "was given";
                ex3ans11.BorderStyle = BorderStyle.FixedSingle;
                ex3n11ans.ForeColor = Color.Red;
            }
                
            if (ex3n12ans.Text == "are built") vpr3points += 5;
            else
            {
                ex3ans12.Text = "are built";
                ex3ans12.BorderStyle = BorderStyle.FixedSingle;
                ex3n12ans.ForeColor = Color.Red;
            }
                
            if (ex3n13ans.Text == "will be done") vpr3points += 5;
            else
            {
                ex3ans13.Text = "will be done";
                ex3ans13.BorderStyle = BorderStyle.FixedSingle;
                ex3n13ans.ForeColor = Color.Red;
            }

            if (ex3n14ans.Text == "was translated") vpr3points += 5;
            else
            {
                ex3ans14.Text = "was translated";
                ex3ans14.BorderStyle = BorderStyle.FixedSingle;
                ex3n14ans.ForeColor = Color.Red;
            }

            if (ex3n15ans.Text == "were planted") vpr3points += 5;
            else
            {
                ex3ans15.Text = "were planted";
                ex3ans15.BorderStyle = BorderStyle.FixedSingle;
                ex3n15ans.ForeColor = Color.Red;
            }
                
            if (ex3n16ans.Text == "are always played") vpr3points += 5;
            else
            {
                ex3ans16.Text = "are always played";
                ex3ans16.BorderStyle = BorderStyle.FixedSingle;
                ex3n16ans.ForeColor = Color.Red;
            }
                
            if (ex3n17ans.Text == "will be given") vpr3points += 5;
            else
            {
                ex3ans17.Text = "will be given";
                ex3ans17.BorderStyle = BorderStyle.FixedSingle;
                ex3n17ans.ForeColor = Color.Red;
            }

            if (ex3n18ans.Text == "were invited") vpr3points += 5;
            else
            {
                ex3ans18.Text = "were invited";
                ex3ans18.BorderStyle = BorderStyle.FixedSingle;
                ex3n18ans.ForeColor = Color.Red;
            }

            if (ex3n19ans.Text == "is never found" || ex3n19ans.Text == "was never found") vpr3points += 5;
            else
            {
                ex3ans19.Text = "is never found OR was never found";
                ex3ans19.BorderStyle = BorderStyle.FixedSingle;
                ex3n19ans.ForeColor = Color.Red;
            }

            if (ex3n20ans.Text == "was not built" || ex3n20ans.Text == "wasn`t built") vpr3points += 5;
            else
            {
                ex3ans20.Text = "was not built OR wasn`t built";
                ex3ans20.BorderStyle = BorderStyle.FixedSingle;
                ex3n20ans.ForeColor = Color.Red;
            }

            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck3.Text = ("Кількість балів: " + vpr3points.ToString());
            pointscheck3.BorderStyle = BorderStyle.FixedSingle;
            pointscheck3.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check3.Enabled = false;
            task1ex3.Focus();
        }
        private void check4_Click(object sender, EventArgs e)
        {
            double vpr4points = 0;
            // Додача балів до правильних відповідей
            if (ex4n1ans.Text == "The freshman was laughed at") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "1. The freshman was laughed at\r\n";
                ex4n1ans.ForeColor = Color.Red;
            }

            if (ex4n2ans.Text == "The headmistress was spoken to yesterday" || ex4n2ans.Text == "The headmistress was spoken to") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "2. The headmistress was spoken to yesterday OR The headmistress was spoken to\r\n";
                ex4n2ans.ForeColor = Color.Red;
            }

            if (ex4n3ans.Text == "The babies were looked after" || ex4n3ans.Text == "The babies were looked after with great care") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "3. The babies were looked after OR The babies were looked after with great care\r\n";
                ex4n3ans.ForeColor = Color.Red;
            }

            if (ex4n4ans.Text == "That old house was not lived in") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "4. That old house was not lived in\r\n";
                ex4n4ans.ForeColor = Color.Red;
            }

            if (ex4n5ans.Text == "Jim was sent for and told to prepare a report on that subject") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "5. Jim was sent for and told to prepare a report on that subject\r\n";
                ex4n5ans.ForeColor = Color.Red;
            }
                
            if (ex4n6ans.Text == "Our friend was thought about all the time") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "6. Our friend was thought about all the time\r\n";
                ex4n6ans.ForeColor = Color.Red;
            }

            if (ex4n7ans.Text == "He will be operated on in a week" || ex4n7ans.Text == "He will be operated on") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "7. He will be operated on in a week OR He will be operated on\r\n";
                ex4n7ans.ForeColor = Color.Red;
            }

            if (ex4n8ans.Text == "The pupil`s parents were sent for") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "8. The pupil’s parents were sent for\r\n";
                ex4n8ans.ForeColor = Color.Red;
            }

            if (ex4n9ans.Text == "The newspaper was looked for everywhere" || ex4n9ans.Text == "The newspaper was looked for") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "9. The newspaper was looked for everywhere OR The newspaper was looked for\r\n";
                ex4n9ans.ForeColor = Color.Red;
            }
                
            if (ex4n10ans.Text == "The bed was not slept in") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "10. The bed was not slept in\r\n";
                ex4n10ans.ForeColor = Color.Red;
            }

            if (ex4n11ans.Text == "The telegram was asked for") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "11. The telegram was asked for\r\n";
                ex4n11ans.ForeColor = Color.Red;
            }

            if (ex4n12ans.Text == "The lecturer was listened to with great attention" || ex4n12ans.Text == "The lecturer was listened to") vpr4points += 8.33;
            else
            {
                ex4answers.Text += "12. The lecturer was listened to with great attention OR The lecturer was listened to\r\n";
                ex4n12ans.ForeColor = Color.Red;
            }
                
            // Зміна тексту лейблу на кількість отриманих балів за завдання
            pointscheck4.Text = ("Кількість балів: " + vpr4points.ToString());
            pointscheck4.BorderStyle = BorderStyle.FixedSingle;
            pointscheck4.BackColor = Color.White;
            // Вимикання кнопки, щоб не можна було за її допомогою 'абузити' перевірку правильних відповідей
            check4.Enabled = false;
            task1ex4.Focus();
        }
    }
}
