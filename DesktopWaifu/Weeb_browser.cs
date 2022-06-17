﻿using System;
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
            panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        }

        public List<ChromiumWebBrowser> listOfTabs = new List<ChromiumWebBrowser>();
        public List<Button> tabButtons = new List<Button>();

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
            
            address = e.Address;
            if (URLInput.InvokeRequired)
            {
                URLInput.Invoke(new MethodInvoker(delegate { URLInput.Text = address; }));
            }
            _history.Add(address);
            //ChangeURLText();
            //Nevím jak toto vyřešit 
        }

        private void ChangeURLText()
        {
            URLInput.Text = address;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoBack) WebBrowser.Back();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoForward) WebBrowser.Forward();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void DevTools_Click(object sender, EventArgs e)
        {
            WebBrowser.ShowDevTools();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void NavBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listOfTabs.Add(new ChromiumWebBrowser());
            int index = listOfTabs.Count - 1;
            panel1.Controls.Add(listOfTabs[index]);
            listOfTabs[index].LoadUrl("google.com");
            listOfTabs[index].Location = new Point(0, 0);
            listOfTabs[index].Size = new Size(950, 550);
            listOfTabs[index].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            listOfTabs[index].BringToFront();
            tabButtons.Add(new Button());
            int buttonIndex = tabButtons.Count - 1;
            this.Controls.Add(tabButtons[buttonIndex]);
            tabButtons[buttonIndex].Text = "new tab";
            tabButtons[buttonIndex].Location = new Point((buttonIndex + 1) * 106, 3);
            tabButtons[buttonIndex].Size = new Size(100, 26);
            tabButtons[buttonIndex].BringToFront();
            button2.Location = new Point((buttonIndex + 1) * 106 + 106, 3);
        }
    }
}