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
using CefSharp.SchemeHandler;
using System.IO;

namespace DesktopWaifu
{
    public partial class Weeb_browser : Form
    {
        private string address;
        private BrowserHistory _history = new BrowserHistory(10);
        public Weeb_browser(string url_address)
        {
            InitializeComponent();
            InitBrowser();
            Button2_Click(null, null);
            address = url_address;
            panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        }

        public void InitBrowser()
        {
            var settings = new CefSettings();

            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                DomainName = "cefsharp",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                    rootFolder: @"./Resources",
                    hostName: "cefsharp",
                    defaultPage: "newTab.html" // will default to index.html
                )
            });

            settings.CachePath = System.IO.Path.GetFullPath("browserCache");

            try
            {
                Cef.Initialize(settings);
            }
            catch (Exception)
            {

            }

        }

        public List<ChromiumWebBrowser> listOfTabs = new List<ChromiumWebBrowser>();
        public List<Button> tabButtons = new List<Button>();
        public List<Button> closeTabButtons = new List<Button>();
        private int currentBrowser = -1;



        private void Weeb_browser_Load(object sender, EventArgs e)
        {
            listOfTabs[currentBrowser].LoadUrl(address);
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
            listOfTabs[currentBrowser].LoadUrl(URLInput.Text);
        }

        private void URLInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listOfTabs[currentBrowser].LoadUrl(URLInput.Text);
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
            if (listOfTabs[currentBrowser].CanGoBack) listOfTabs[currentBrowser].Back();
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            if (listOfTabs[currentBrowser].CanGoForward) listOfTabs[currentBrowser].Forward();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void DevTools_Click(object sender, EventArgs e)
        {
            listOfTabs[currentBrowser].ShowDevTools();
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
            BrowserSettings bs = new BrowserSettings()
            {
                LocalStorage = CefState.Enabled,
                Databases = CefState.Enabled,

            };
            listOfTabs.Add(new ChromiumWebBrowser("localfolder://cefsharp/"));
            int index = listOfTabs.Count - 1;
            listOfTabs[index].BrowserSettings = bs;
            panel1.Controls.Add(listOfTabs[index]);
            listOfTabs[index].Location = new Point(0, 0);
            listOfTabs[index].Size = new Size(950, 550);
            listOfTabs[index].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            listOfTabs[index].Dock = DockStyle.Fill;
            listOfTabs[index].BringToFront();
            listOfTabs[index].AddressChanged += (s, en) => changeUrl(en);
            tabButtons.Add(new Button());
            int buttonIndex = tabButtons.Count - 1;
            this.Controls.Add(tabButtons[buttonIndex]);
            tabButtons[buttonIndex].Text = "new tab";
            tabButtons[buttonIndex].Location = new Point((buttonIndex) * 106, 3);
            tabButtons[buttonIndex].Size = new Size(100, 26);
            tabButtons[buttonIndex].Click += (s, en) => changeTab(tabButtons.FindIndex(a => a == s));
            tabButtons[buttonIndex].FlatStyle = FlatStyle.Popup;
            foreach (Button item in tabButtons)
            {
                item.BackColor = Color.FromArgb(197, 197, 197);
            }
            tabButtons[buttonIndex].BackColor = Color.FromArgb(46, 51, 73);
            tabButtons[buttonIndex].BringToFront();
            closeTabButtons.Add(new Button());
            this.Controls.Add(closeTabButtons[buttonIndex]);
            closeTabButtons[buttonIndex].Text = "x";
            closeTabButtons[buttonIndex].Location = new Point((buttonIndex) * 106 + 80, 6);
            closeTabButtons[buttonIndex].Size = new Size(20, 20);
            closeTabButtons[buttonIndex].Click += (s, en) => closeTab(closeTabButtons.FindIndex(a => a == s));
            closeTabButtons[buttonIndex].BringToFront();
            button2.Location = new Point((buttonIndex) * 106 + 106, 3);
            currentBrowser++;
        }

        private void changeTab(int indexOfTab)
        {
            listOfTabs[indexOfTab].BringToFront();
            foreach (Button item in tabButtons)
            {
                item.BackColor = Color.FromArgb(197, 197, 197);
            }
            tabButtons[indexOfTab].BackColor = Color.FromArgb(46, 51, 73);
            currentBrowser = indexOfTab;
            if (URLInput.InvokeRequired)
            {
                URLInput.Invoke(new MethodInvoker(delegate { URLInput.Text = listOfTabs[currentBrowser].Address; }));
            }
        }

        private void closeTab(int indexOfTab)
        {
            this.Controls.Remove(listOfTabs[indexOfTab]);
            this.Controls.Remove(tabButtons[indexOfTab]);
            this.Controls.Remove(closeTabButtons[indexOfTab]);
            listOfTabs.RemoveAt(indexOfTab);
            tabButtons.RemoveAt(indexOfTab);
            closeTabButtons.RemoveAt(indexOfTab);
            if (indexOfTab == 0)
            {
                this.Close();
            }
            else
            {
                currentBrowser = indexOfTab - 1;
                listOfTabs[currentBrowser].BringToFront();
                int buttonIndex = tabButtons.Count - 1;
                foreach (Button item in tabButtons)
                {
                    item.Location = new Point((tabButtons.FindIndex(a => a == item)) * 106, 3);
                    item.BackColor = Color.FromArgb(197, 197, 197);
                }
                foreach (Button item in closeTabButtons)
                {
                    item.Location = new Point((closeTabButtons.FindIndex(a => a == item)) * 106 + 80, 6);
                }
                tabButtons[currentBrowser].BackColor = Color.FromArgb(46, 51, 73);
                button2.Location = new Point((buttonIndex) * 106 + 106, 3);
                if (URLInput.InvokeRequired)
                {
                    URLInput.Invoke(new MethodInvoker(delegate { URLInput.Text = listOfTabs[currentBrowser].Address; }));
                }
            }

        }

        private void changeUrl(AddressChangedEventArgs e)
        {
            address = e.Address;
            if (URLInput.InvokeRequired)
            {
                URLInput.Invoke(new MethodInvoker(delegate { URLInput.Text = address; }));
            }
            _history.Add(address);
        }
    }
}