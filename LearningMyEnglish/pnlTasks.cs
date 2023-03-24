using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace LearningMyEnglish
{
    public partial class pnlTasks : UserControl
    {

        private Dictionary<Button, Label> buttonLabels = new Dictionary<Button, Label>();

        public pnlTasks()
        {
            InitializeComponent();
        }

        private void pnlTasks_Load(object sender, EventArgs e)
        {
            buttonLabels.Add(button1, label1);
            buttonLabels.Add(button2, label2);
            buttonLabels.Add(button3, label3);


            foreach (var buttonLabel in buttonLabels)
            {
                buttonLabel.Key.MouseEnter += Button_MouseEnter;
                buttonLabel.Key.MouseLeave += Button_MouseLeave;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Отримати мітку для відповідної кнопки та зробити її видимою
            var button = (Button)sender;
            var label = buttonLabels[button];
            label.Visible = true;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Отримати мітку для відповідної кнопки та зробити її невидимою
            var button = (Button)sender;
            var label = buttonLabels[button];
            label.Visible = false;
        }
    }
}
