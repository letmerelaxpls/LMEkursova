using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningMyEnglish
{
    public partial class Form1 : Form
    {
        private Dictionary<Button, Label> buttonLabels = new Dictionary<Button, Label>();


        public Form1()
        {
            InitializeComponent();
            
            btnTasks.BackColor = Color.RoyalBlue;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonLabels.Add(button1, tskBnt1Description);
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
        

        private void btnTasks_Click(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.RoyalBlue;
            btnRules.BackColor = Color.DodgerBlue;
        }

        private void btnTasks_MouseEnter(object sender, EventArgs e)
        {
            if (btnTasks.BackColor == Color.RoyalBlue)
            {
                btnTasks.BackColor = Color.RoyalBlue;
            }
            else
            {
                btnTasks.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btnTasks_MouseLeave(object sender, EventArgs e)
        {
            if (btnTasks.BackColor == Color.RoyalBlue)
            {
                btnTasks.BackColor = Color.RoyalBlue;
            }
            else
            {
                btnTasks.BackColor = Color.DodgerBlue;
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            btnRules.BackColor = Color.RoyalBlue;
            btnTasks.BackColor = Color.DodgerBlue;
        }

        private void btnRules_MouseEnter(object sender, EventArgs e)
        {
            if (btnRules.BackColor == Color.RoyalBlue)
            {
                btnRules.BackColor = Color.RoyalBlue;
            }
            else
            {
                btnRules.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btnRules_MouseLeave(object sender, EventArgs e)
        {
            if (btnRules.BackColor == Color.RoyalBlue)
            {
                btnRules.BackColor = Color.RoyalBlue;
            }
            else
            {
                btnRules.BackColor = Color.DodgerBlue;
            }
        }

        

        
        
    }
}   

