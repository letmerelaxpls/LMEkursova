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
        // Список кнопок та лейблів
        private Dictionary<Button, Label> buttonLabels = new Dictionary<Button, Label>();

        public pnlTasks()
        {
            InitializeComponent();
        }

        private void pnlTasks_Load(object sender, EventArgs e)
        {
            // Додає у список кнопки на лейбли
            buttonLabels.Add(task1, thmdesc1);
            buttonLabels.Add(task2, thmdesc2);
            buttonLabels.Add(task3, thmdesc3);
            buttonLabels.Add(task4, thmdesc4);
            buttonLabels.Add(task5, thmdesc5);

            // Присвоює дії до всіх кнопок та лейблів у списку
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

        private void task1_Click(object sender, EventArgs e)
        {
            // Ховає всі інші контроли окрім потрібного
            Form form = this.FindForm();
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is pnlTasks || control is pnlRules)
                    {
                        control.Hide();
                    }
                }
            }
        }
    }
}
