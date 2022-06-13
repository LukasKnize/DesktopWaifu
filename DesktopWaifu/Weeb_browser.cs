using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace DesktopWaifu
{
    public partial class Weeb_browser : Form
    {
        private string adress;
        private static BrowserHistory WeebBrowserHistory = new BrowserHistory();
        public Weeb_browser(string urlAdress)
        {
            InitializeComponent();
            adress = urlAdress;
        }

        private void Weeb_browser_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl(adress);
        }

        private void ChromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl(URLInput.Text);
        }

        private void URLInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromiumWebBrowser1.LoadUrl(URLInput.Text);
            }
        }

        private void ChromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            adress = e.Address;
            if (URLInput.InvokeRequired)
            {
                URLInput.Invoke(new MethodInvoker(delegate { URLInput.Text = adress; }));
            }
            WeebBrowserHistory.AddToHistory(adress);
            //ChangeURLText();
            //Nevím jak toto vyřešit
        }

        private void ChangeURLText()
        {
            URLInput.Text = adress;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            string backAdress = WeebBrowserHistory.StepBack();
            richTextBox1.Text = WeebBrowserHistory.FullHistory();
            chromiumWebBrowser1.LoadUrl(backAdress);
        }
    }
}
