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
        private string address;
        private BrowserHistory _history = new BrowserHistory(10);
        public Weeb_browser(string url_address)
        {
            InitializeComponent();
            address = url_address;
        }

        private void Weeb_browser_Load(object sender, EventArgs e)
        {
            WebBrowser.LoadUrl(address);
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
            WebBrowser.LoadUrl(URLInput.Text);
        }

        private void URLInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser.LoadUrl(URLInput.Text);
            }
        }

        private void ChromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            /*
            address = e.Address;
            if (URLInput.InvokeRequired)
            {
                URLInput.Invoke(new MethodInvoker(delegate { URLInput.Text = address; }));
            }
            _history.Add(address);
            //ChangeURLText();
            //Nevím jak toto vyřešit */
        }

        private void ChangeURLText()
        {
            URLInput.Text = address;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoBack) WebBrowser.Back();
        }

        private void Next_Click(object sender, EventArgs e) {
            if (WebBrowser.CanGoForward) WebBrowser.Forward();
        }
    }
}
