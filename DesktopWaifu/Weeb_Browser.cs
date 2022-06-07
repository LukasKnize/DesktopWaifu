using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWaifu {
    public partial class Weeb_Browser : Form {
        public Weeb_Browser(string url) {
            InitializeComponent();
            Uri.TryCreate(url, UriKind.Absolute, out var uri);
            WBCore.Url = uri;
            WBCore.Refresh();
        }

        private void open_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(WBCore.Url.ToString());
        }
    }
}