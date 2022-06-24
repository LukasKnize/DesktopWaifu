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
    public partial class DesktopWaifu : Form {
        private string url = "";
        public DesktopWaifu() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Loading.Visible = false;
            Common.ImgHistory._btn_disable(Next);
            CacheSystem.init();
            Common.theme_manager.Init(this, this.Controls, closeButton, minimizeButton);
            CommandExecution.GetWaifu("waifu");
            Input.Focus();
        }

        private void Submit_Click(object sender, EventArgs e) {
            string command = Input.Text; //kamo tohle jako se da dat do jednoho posraneho radku.
            if (command != "") CommandExecution.Execute(command,  ref url);
        }

        private void Input_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Down && e.KeyCode != Keys.Up) return;
            /* Tohle bylo na predchozi prikazy ale moc to nefunguje takze to jenom zakomentuju */
            if (e.KeyCode == Keys.Up) {
                Input.Text = Common.CmdHistory.Prev();
                Input.SelectionStart = Input.Text.Length + 1;
                return;
            }
            else if (e.KeyCode == Keys.Down) {
                Input.Text = Common.CmdHistory.Next();
                Input.SelectionStart = Input.Text.Length + 1;
                return;
            }
            string command = Input.Text; //stejne tady. Jako what the fuck are you doing, guys? What's wrong with that?
            Input.Text = "";
            if (command != "" || command != " ") CommandExecution.Execute(command, ref url);
        }
        private void Previous_Click(object sender, EventArgs e) {
            Display.Load(Common.ImgHistory.Prev().path);
        }
        private void Next_Click(object sender, EventArgs e) {
            Display.Load(Common.ImgHistory.Next().path);
        }

        private void save_Click(object sender, EventArgs e) {
            CacheSystem.Save(Common.ImgHistory.Current);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        //následující kód umožňuje pohybování aplikace po displeji

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void NavBar_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (!Display.IsDisposed) Display.Dispose();
            CacheSystem.Destroy();
        }
        #region Command execution
//        private void executeCommand(string command) {
//            if (Output.Text.Split('\n').Length > 22) Output.Text = "";
//            command = command.Trim().ToLower();
//            Output.Text += $"[~] command >> {(command!=""?command:"---")}\n";
//            Common.CmdHistory.Add(command);
//            string[] args = command.Split(new char[] { '/', ' ' , '.'});
//            string[] Tags1 = { "waifu", "neko", "shinobu", "trap", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" };
//            string[] Tags2 = { "uniform", "maid", "marin-kitagawa", "mori-calliope", "raiden-shogun", "oppai", "selfies", "ass", "hentai", "milf", "oral", "paizuri", "ecchi", "ero" };
//            string[] songs = { "https://youtu.be/SoKLSIXccgU", "https://youtu.be/1R_PRloutY8", "https://youtu.be/3NLsyjOH92k", "https://youtu.be/DFGJ8PhjrlM", "https://youtu.be/sSfAuBS54s4", "https://youtu.be/yIfkpbMLLsY", "https://youtu.be/i80OHgDwfZI", "https://youtu.be/QkQ5SfZ0YlM", "https://youtu.be/0oMT_6Zu4a4", "https://youtu.be/nCQ_zZIiGLA", "https://youtu.be/EVg8orAhz4g" };
//            string[] animeSites = { "4Anime: https://4anime.gg/", "Crunchyroll: https://www.crunchyroll.com/", "[!]NSFW[!]-HeantaiHaven: https://hentaihaven.xxx", "9anime : https://9anime.to/" };


//            if (command == "?") {
//                Output.Text += $@"[?] List of commands:
//{'"'}[change] [category] [tag]{'"'}
//...list of categorys: sfw, nsfw
//...list of sfw tags: waifu, neko, shinobu, megumin, bully, cuddle, cry, hug, awoo, kiss, lick, pat, smug, bonk, yeet, blush, smile, wave, highfive, handhold, nom, bite, glomp, slap, kill, kick, happy, wink, poke, dance, cringe
//...list of nsfw tags: waifu, neko, trap, ass, hentai, milf, oral, paizuri, ecchi, ero
//Other Possible Commands:
//{'"'}anime{'"'} - 
//{'"'}song{'"'} - opens a random song on YT in a browser
//{'"'}site{'"'} - gives you a link to a random anime website";
//                Output.Text += "\n";
//            }
//            else if (args[0] == "change") {
//                if (Tags1.Contains(args[2]) || Tags2.Contains(args[2])) {
//                    getWaifu(args[1] == "nsfw", args[2], Tags2.Contains(args[2]));
//                }
//                else {
//                    Output.Text += "[!] Invalid command, try ?\n";
//                }
//            }
//            else if (command == "song") {
//                Nullable<int> index = rng.Next(0, songs.Length - 1);
//                System.Diagnostics.Process.Start("\""+songs[index != null ? (int)index : 0]+"\"");
//            }
//            else if (command == "anime") {
//                var apireturn = Getter.getAnime();
//                Output.Text += apireturn.url + "\n"; //Item1 accessne prvni item v tuplu takze string
//                Output.Text += apireturn.img.ToString(); //Item2 accessne druhy item a Item3 by accessnul treti item a tak dale.
//                url = apireturn.url;
//            }
//            else if (command == "site") {
//                Nullable<int> index = rng.Next(0, animeSites.Length - 1);
//                Output.Text += animeSites[index != null ? (int)index : 0] + "\n";
//                url = animeSites[index != null ? (int)index : 0];
//            }
//            else if (args[0] == "theme") {
//                //tady se budou volat ty jednotlivé metody ze třídy Themes
//                if (args[1] == "dark") {
//                    Common.theme_manager.Dark();
//                }
//                else if (args[1] == "light") {
//                    Common.theme_manager.Light();
//                }
//                else if (args[1] == "pink") {
//                    Common.theme_manager.Pink();
//                }
//                else {
//                    Output.Text += "[!] Invalid command, try ?\n";
//                }
//            }
//            else {
//                Output.Text += "[!] Invalid command, try ?\n";

//            }
//        }
        #endregion

        private void Output_LinkClicked(object sender, LinkClickedEventArgs e) {
            var result = MessageBox.Show("Do you wish to open the link in a browser?", "Open a link?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                System.Diagnostics.Process.Start(url);   
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            (new Weeb_browser("https://github.com/")).Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            (new Weeb_browser("https://github.com/")).Show();
        }
    }
}