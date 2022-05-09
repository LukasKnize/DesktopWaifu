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
        private Dictionary<string, Control> controls = new Dictionary<string, Control>();
        private Form form;
        public void Init(Form form, Control.ControlCollection controls) {
            foreach (var item in controls) { //tady je to bez this a tak to bere parametr ze zavorky metody
                this.controls[(item as Control).Name] = item as Control; //this.controls rekne ze chceme pouzit "atribut" teto tridy coz je ten Dictionary.
                // bez toho this by to vzalo parametr ze zavorky u metody
            }
            this.form = form; 
        }
        public void Dark()
        {
            controls["navBar"].BackColor = Color.FromArgb(24, 30, 54);
            controls["TextField"].BackColor = Color.FromArgb(37, 42, 64);
            controls["Next"].BackColor = Color.FromArgb(37, 42, 64);
            controls["Previous"].BackColor = Color.FromArgb(37, 42, 64);
            controls["save"].BackColor = Color.FromArgb(37, 42, 64);
            controls["EnterField"].BackColor = Color.FromArgb(37, 42, 64);
            controls["Submit"].BackColor = Color.FromArgb(37, 42, 64);
            form.BackColor = Color.FromArgb(46, 51, 73);

            controls["TextField"].ForeColor = Color.FromArgb(226, 227, 230);
            controls["Next"].ForeColor = Color.FromArgb(226, 227, 230);
            controls["Previous"].ForeColor = Color.FromArgb(226, 227, 230);
            controls["save"].ForeColor = Color.FromArgb(226, 227, 230);
            controls["EnterField"].ForeColor = Color.FromArgb(226, 227, 230);
            controls["Submit"].ForeColor = Color.FromArgb(226, 227, 230);
        }

        public void Light()
        {
            controls["navBar"].BackColor = Color.FromArgb(37, 59, 163);
            controls["TextField"].BackColor = Color.FromArgb(255, 255, 255);
            controls["Next"].BackColor = Color.FromArgb(255, 255, 255);
            controls["Previous"].BackColor = Color.FromArgb(255, 255, 255);
            controls["save"].BackColor = Color.FromArgb(255, 255, 255);
            controls["EnterField"].BackColor = Color.FromArgb(255, 255, 255);
            controls["Submit"].BackColor = Color.FromArgb(255, 255, 255);
            form.BackColor = Color.FromArgb(199, 204, 217);

            controls["TextField"].ForeColor = Color.FromArgb(44, 44, 44);
            controls["Next"].ForeColor = Color.FromArgb(44, 44, 44);
            controls["Previous"].ForeColor = Color.FromArgb(44, 44, 44);
            controls["save"].ForeColor = Color.FromArgb(44, 44, 44);
            controls["EnterField"].ForeColor = Color.FromArgb(44, 44, 44);
            controls["Submit"].ForeColor = Color.FromArgb(44, 44, 44);
        }

        public void Pink()
        {
            controls["navBar"].BackColor = Color.FromArgb(149, 16, 105);
            controls["TextField"].BackColor = Color.FromArgb(255, 255, 255);
            controls["Next"].BackColor = Color.FromArgb(252, 27, 155);
            controls["Previous"].BackColor = Color.FromArgb(252, 27, 155);
            controls["save"].BackColor = Color.FromArgb(252, 27, 155);
            controls["EnterField"].BackColor = Color.FromArgb(255, 255, 255);
            controls["Submit"].BackColor = Color.FromArgb(252, 27, 155);
            form.BackColor = Color.FromArgb(253, 159, 212);

            controls["TextField"].ForeColor = Color.FromArgb(149, 16, 105);
            controls["Next"].ForeColor = Color.FromArgb(149, 16, 105);
            controls["Previous"].ForeColor = Color.FromArgb(149, 16, 105);
            controls["save"].ForeColor = Color.FromArgb(149, 16, 105);
            controls["EnterField"].ForeColor = Color.FromArgb(149, 16, 105);
            controls["Submit"].ForeColor = Color.FromArgb(149, 16, 105);
            controls["closeButton"].BackColor = Color.FromArgb(255, 46, 0);
            controls["minimizeButton"].BackColor = Color.FromArgb(254, 168, 47);
        }
    }
}
