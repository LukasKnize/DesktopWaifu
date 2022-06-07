using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace DesktopWaifu {
    public class ExRichTextBox : RichTextBox {
        const int WM_SETCURSOR = 0x0020;
        protected override void WndProc(ref Message m) {
            if (m.Msg == WM_SETCURSOR)
                Cursor.Current = this.Cursor;
            else
                base.WndProc(ref m);
        }
    }
    public class Integrity {
        static private string _newtonsoft = "Newtonsoft.Json";
        static private string[] _extensions = { "dll", "xml" };

        static public void Checker() {
            var state = true;
            foreach (string ext in _extensions) {
                if (!File.Exists($"./{_newtonsoft}.{ext}")) state = false;
            }
            if (!state) _newtonsoft_donwloader();
        }
        static private void _newtonsoft_donwloader() {
            // https://stackoverflow.com/a/18764671
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.github.com/JamesNK/Newtonsoft.Json/releases/latest");
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string apiContent = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            var downloadUrl = "";
            // "browser_download_url" : ""

            Directory.CreateDirectory("tmp");
            (new WebClient()).DownloadFile(downloadUrl, "tmp/json.zip");
            foreach (string ext in _extensions) {
                File.Move($"./tmp/json/Bin/net45/{_newtonsoft}.{ext}", $"./{_newtonsoft}.{ext}");
            }
        }
    }
}
