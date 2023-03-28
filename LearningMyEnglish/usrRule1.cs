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
    public partial class usrRule1 : UserControl
    {
        public delegate void ResizeFormDelegate(int width, int height);
        public event ResizeFormDelegate ResizeFormEvent;
        public usrRule1()
        {
            InitializeComponent();
            this.ResizeFormEvent += pnlRules_ResizeFormEvent;
        }
        private void pnlRules_ResizeFormEvent(int width, int height)
        {
            // Зменшуємо максимальну ширину та висоту вікна на (200; 215) пікселів
            this.ParentForm.MaximumSize = new Size(this.ParentForm.MaximumSize.Width - 200, this.ParentForm.MaximumSize.Height - 215);
            this.ParentForm.MinimumSize = new Size(this.ParentForm.MinimumSize.Width - 200, this.ParentForm.MinimumSize.Height - 215);
            
            // Встановлюємо новий розмір форми
            this.ParentForm.Width = width;
            this.ParentForm.Height = height;


        }
        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    int y = e.NewValue;
        //    if (y < 0)
        //        y = 0;
        //    if (y + panel1.Height > rule1part1.Height)
        //        y = rule1part1.Height - panel1.Height;

        //    panel1.Location = new Point(0, -y);
        //}

        private void backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ResizeFormEvent?.Invoke(this.ParentForm.Width - 200, this.ParentForm.Height - 215);
            Form form = this.FindForm();
            if (form != null && form is Form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is pnlTasks || control is pnlRules)
                    {
                        control.Show();
                    }
                    
                }
            }
        }
    }
}
