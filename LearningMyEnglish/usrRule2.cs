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
    public partial class usrRule2 : UserControl
    {
        public usrRule2()
        {
            InitializeComponent();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            BackToMenu.GoBack(this);
        }
    }
}
