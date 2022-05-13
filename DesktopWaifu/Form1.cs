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

namespace DesktopWaifu
{
    public partial class DesktopWaifu : Form
    {
        public DesktopWaifu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading.Visible= false;
            Common.ImgHistory._btn_disable(Next);
            CacheSystem.init();
            Common.theme_manager.Init(this, this.Controls, closeButton, minimizeButton);
            getWaifu("sfw/waifu");
            Input.Focus();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string command = Input.Text; //kamo tohle jako se da dat do jednoho posraneho radku.
            if (command != "") executeCommand(command);
        }

        private void getWaifu(string parameters)
        {
            //TextField.Text += TextField.Text.Length == 0 ? "" : "Loading";
            Loading.Visible = true;
            this.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            string img_url = Getter.getWaifu(parameters);
            Common.ImgHistory.Add(img_url);
            Display.Load(Common.ImgHistory.Current.path);
            //TextField.Text += TextField.Text.Length == 0 ? "" : ", Done\n";
            Loading.Visible = false;
            this.Refresh();
            Cursor.Current = Cursors.Default;
        }
        private void getAnime()
        {
            var apireturn = Getter.getAnime();
            Output.Text += apireturn.Item1 + "\n"; //Item1 accessne prvni item v tuplu takze string
            Output.Text += apireturn.Item2.ToString(); //Item2 accessne druhy item a Item3 by accessnul treti item a tak dale.

        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Down && e.KeyCode != Keys.Up) return;
            /* Tohle bylo na predchozi prikazy ale moc to nefunguje takze to jenom zakomentuju */
            if (e.KeyCode == Keys.Up) {
                Input.Text = Common.CmdHistory.Prev();
                Input.SelectionStart = Input.Text.Length+1;
                return;
            }
            else if (e.KeyCode == Keys.Down) {
                Input.Text = Common.CmdHistory.Next();
                Input.SelectionStart = Input.Text.Length+1;
                return;
            }
            string command = Input.Text; //stejne tady. Jako what the fuck are you doing, guys?
            Input.Text = "";
            if (command != "" || command != " ") executeCommand(command);
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            Display.Load(Common.ImgHistory.Prev().path);
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Display.Load(Common.ImgHistory.Next().path);
        }

        private void save_Click(object sender, EventArgs e) {
            CacheSystem.Save(Common.ImgHistory.Current);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //následující kód umožňuje pohybování aplikace po displeji

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (!Display.IsDisposed) Display.Dispose();
            CacheSystem.Destroy();
        }
        #region Command execution
        private void executeCommand(string command) {
            if (Output.Text.Split('\n').Length > 22) Output.Text = "";
            Common.CmdHistory.Add(command);
            Output.Text += command + "\n";
            string[] splitedCommand = command.Split('/');
            string[] sfwTags = { "waifu", "neko", "shinobu", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" };
            string[] nsfwTags = { "waifu", "neko", "trap" };
            string[] songs = { "https://youtu.be/SoKLSIXccgU", "https://youtu.be/1R_PRloutY8", "https://youtu.be/3NLsyjOH92k", "https://youtu.be/DFGJ8PhjrlM", "https://youtu.be/sSfAuBS54s4", "https://youtu.be/yIfkpbMLLsY", "https://youtu.be/i80OHgDwfZI", "https://youtu.be/QkQ5SfZ0YlM", "https://youtu.be/0oMT_6Zu4a4", "https://youtu.be/nCQ_zZIiGLA", "https://youtu.be/EVg8orAhz4g" };
            string[] animeSites = { "4Anime: https://4anime.gg/", "Crunchyroll: https://www.crunchyroll.com/", "NSFW!!-HeantaiHaven: https://hentaihaven.xxx", "9anime : https://9anime.to/" };
            Random randomIndex = new Random();
            //Common.past_commands.Add(command); Tohle bylo na predchozi prikazy ale moc to nefunguje takze to jenom zakomentuju


            if (command == "?") {
                Output.Text += "List of commands: \n #changeWaifu/category/tag \n ...list of categorys: sfw, nsfw \n ...list of sfw tags: waifu, neko, shinobu, megumin, bully, cuddle, cry, hug, awoo, kiss, lick, pat, smug, bonk, yeet, blush, smile, wave, highfive, handhold, nom, bite, glomp, slap, kill, kick, happy, wink, poke, dance, cringe \n list of nsfw tags: waifu, neko, trap \n #anime \n #song \n #site";
                Output.Text += "\n";
            }
            else if (splitedCommand[0] == "#changeWaifu") {
                if (splitedCommand[1] == "sfw" && sfwTags.Contains(splitedCommand[2])) {
                    getWaifu(splitedCommand[1] + "/" + splitedCommand[2]);
                }
                else if (splitedCommand[1] == "nsfw" && nsfwTags.Contains(splitedCommand[2])) {
                    getWaifu(splitedCommand[1] + "/" + splitedCommand[2]);
                }
                else {
                    Output.Text += "invalid command, try ?" + "\n";
                }
            }
            else if (command == "#song") {
                Nullable<int> index = randomIndex.Next(0, songs.Length - 1);
                System.Diagnostics.Process.Start(songs[index != null ? (int)index : 0]);
            }
            else if (command == "#anime") {
                getAnime();
            }
            else if (command == "#site") {
                Nullable<int> index = randomIndex.Next(0, animeSites.Length - 1);
                Output.Text += animeSites[index != null ? (int)index : 0] + "\n";
            }
            else if (splitedCommand[0] == "#theme") {
                //tady se budou volat ty jednotlivé metody ze třídy Themes
                if (splitedCommand[1] == "dark") {
                    Common.theme_manager.Dark();
                }
                else if (splitedCommand[1] == "light") {
                    Common.theme_manager.Light();
                }
                else if (splitedCommand[1] == "pink") {
                    Common.theme_manager.Pink();
                }
                else {
                    Output.Text += "invalid command, try ?" + "\n";
                }
            }
            else {
                Output.Text += "invalid command, try ?" + "\n";

            }
        }
        #endregion
    }
}
