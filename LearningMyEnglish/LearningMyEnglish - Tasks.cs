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
       
        public Form1()
        {
            InitializeComponent();
            
            btnTasks.BackColor = Color.RoyalBlue;
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

