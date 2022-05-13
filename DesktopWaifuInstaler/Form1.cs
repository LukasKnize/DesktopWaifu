using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace DesktopWaifuInstaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int loaderSteps = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingBarTimer.Enabled = true;
            string path = "./DesktopWaifu.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/LukasKnize/DesktopWaifu/productionForInstaler/DesktopWaifu.exe", "DesktopWaifu.exe");
                }
            }
            else
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/LukasKnize/DesktopWaifu/productionForInstaler/DesktopWaifu.exe", "DesktopWaifu.exe");
                }
            }
            
        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            if (loaderSteps < 98)
            {
                loaderSteps++;
            }
            else
            {
                if (File.Exists("./DesktopWaifu.exe"))
                {
                    loaderSteps = 100;
                    loaderBar.Value = loaderSteps;
                    this.Close();
                }
            }
            
            loaderBar.Value = loaderSteps;
        }
    }
}
