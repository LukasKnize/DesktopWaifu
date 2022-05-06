using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DesktopWaifu
{
    class Themes
    {
        public void Dark()
        {
            navBar.BackColor = Color.FromArgb(24, 30, 54);
            TextField.BackColor = Color.FromArgb(37, 42, 64);
            Next.BackColor = Color.FromArgb(37, 42, 64);
            Previous.BackColor = Color.FromArgb(37, 42, 64);
            save.BackColor = Color.FromArgb(37, 42, 64);
            EnterField.BackColor = Color.FromArgb(37, 42, 64);
            Submit.BackColor = Color.FromArgb(37, 42, 64);
            this.BackColor = Color.FromArgb(46, 51, 73);

            TextField.ForeColor = Color.FromArgb(226, 227, 230);
            Next.ForeColor = Color.FromArgb(226, 227, 230);
            Previous.ForeColor = Color.FromArgb(226, 227, 230);
            save.ForeColor = Color.FromArgb(226, 227, 230);
            EnterField.ForeColor = Color.FromArgb(226, 227, 230);
            Submit.ForeColor = Color.FromArgb(226, 227, 230);
        }

        public void Light()
        {
            navBar.BackColor = Color.FromArgb(37, 59, 163);
            TextField.BackColor = Color.FromArgb(255, 255, 255);
            Next.BackColor = Color.FromArgb(255, 255, 255);
            Previous.BackColor = Color.FromArgb(255, 255, 255);
            save.BackColor = Color.FromArgb(255, 255, 255);
            EnterField.BackColor = Color.FromArgb(255, 255, 255);
            Submit.BackColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(199, 204, 217);

            TextField.ForeColor = Color.FromArgb(44, 44, 44);
            Next.ForeColor = Color.FromArgb(44, 44, 44);
            Previous.ForeColor = Color.FromArgb(44, 44, 44);
            save.ForeColor = Color.FromArgb(44, 44, 44);
            EnterField.ForeColor = Color.FromArgb(44, 44, 44);
            Submit.ForeColor = Color.FromArgb(44, 44, 44);
        }

        public void Pink()
        {
            navBar.BackColor = Color.FromArgb(149, 16, 105);
            TextField.BackColor = Color.FromArgb(255, 255, 255);
            Next.BackColor = Color.FromArgb(252, 27, 155);
            Previous.BackColor = Color.FromArgb(252, 27, 155);
            save.BackColor = Color.FromArgb(252, 27, 155);
            EnterField.BackColor = Color.FromArgb(255, 255, 255);
            Submit.BackColor = Color.FromArgb(252, 27, 155);
            this.BackColor = Color.FromArgb(253, 159, 212);

            TextField.ForeColor = Color.FromArgb(149, 16, 105);
            Next.ForeColor = Color.FromArgb(149, 16, 105);
            Previous.ForeColor = Color.FromArgb(149, 16, 105);
            save.ForeColor = Color.FromArgb(149, 16, 105);
            EnterField.ForeColor = Color.FromArgb(149, 16, 105);
            Submit.ForeColor = Color.FromArgb(149, 16, 105);
            closeButton.BackColor = Color.FromArgb(255, 46, 0);
            minimizeButton.BackColor = Color.FromArgb(254, 168, 47);
        }
    }
}
