using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningMyEnglish
{
    public static class TaskChecker
    {
        public static double CheckTaskV1 (Control parentControl, Dictionary<string, string> correctAnswers, double pointsPerAnswer)
        {
            double points = 0;
            foreach (var pair in correctAnswers)
            {
                var panel = parentControl.Controls.Find(pair.Key, true).FirstOrDefault() as Panel;
                var selectedRadioButton = panel?.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (selectedRadioButton != null && selectedRadioButton.Name == pair.Value) 
                {
                    points += pointsPerAnswer;
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
            if (points > 99)
                points = 100;
            return points;
        }

        public static double CheckTaskV2(Control parentControl, Dictionary<string, (string, Label)> answers, double pointsPerAnswer)
        {
            double points = 0;

            foreach (var item in answers)
            {
                var key = item.Key;
                var userAnswer = parentControl.Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerLabel = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(),correctAnswer, StringComparison.OrdinalIgnoreCase))
                    points += pointsPerAnswer;
                else
                {
                    answerLabel.Text += $"{correctAnswer} ";
                    answerLabel.BorderStyle = BorderStyle.FixedSingle;
                    userAnswer.ForeColor = Color.Red;
                }
            }
            if (points > 99)
                points = 100;
            return points;
        }

        public static double CheckTaskV3(Control parentControl, Dictionary<string, (string, TextBox)> answers, double pointsPerAnswer)
        {
            int i = 0;
            double points = 0;

            foreach (var item in answers)
            {
                i++;
                var key = item.Key;
                var userAnswer = parentControl.Controls.Find(key, true).FirstOrDefault() as TextBox;
                var correctAnswer = item.Value.Item1;
                var answerTextBox = item.Value.Item2;

                if (userAnswer != null && string.Equals(userAnswer.Text.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase))
                    points += pointsPerAnswer;
                else
                {
                    answerTextBox.Text += $"{i}. {correctAnswer}\r\n";
                    userAnswer.ForeColor = Color.Red;
                }
            }
            if (points > 99)
                points = 100;
            return points;
        }

    }
}
