using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningMyEnglish
{
    public static class BackToMenu
{
        public static void GoBack(Control control)
        {
            // Встановлює місце після закриття правила
            control.FindForm().DesktopLocation = new System.Drawing.Point(500, 250);
            // Повертає макс та мін розміри вікна меню
            control.FindForm().MaximumSize = new Size(610, 355);
            control.FindForm().MinimumSize = new Size(610, 355);
            // Повертає всі контроли окрім цього
            Form form = control.FindForm();
            form.Text = "Learning My English Menu";
            if (form != null && form is Form)
            {
                foreach (Control c in form.Controls)
                {
                    if (c is pnlRules || c is pnlTasks)
                    c.Show();

                    if (c is usrTask1)
                    c.Hide();
                }
            }
        }
}
}
