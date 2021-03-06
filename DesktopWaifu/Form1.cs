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
    public partial class Form1 : Form
    {
        History history = new History(4); //do zavorky dejte pocet itemu, ktere tam maxialme muzou byt.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getWaifu("sfw/waifu");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string command = EnterField.Text; //kamo tohle jako se da dat do jednoho posraneho radku.
            if (command != "") executeCommand(command);
        }


        private void executeCommand(string command)
        {
            TextField.Text += command + "\n" ;
            string[] splitedCommand = command.Split('/');
            string[] sfwTags = { "waifu", "neko", "shinobu", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" };
            string[] nsfwTags = { "waifu", "neko", "trap" };
            string[] songs = {"https://youtu.be/SoKLSIXccgU","https://youtu.be/1R_PRloutY8","https://youtu.be/3NLsyjOH92k","https://youtu.be/DFGJ8PhjrlM","https://youtu.be/sSfAuBS54s4","https://youtu.be/yIfkpbMLLsY","https://youtu.be/i80OHgDwfZI","https://youtu.be/QkQ5SfZ0YlM","https://youtu.be/0oMT_6Zu4a4","https://youtu.be/nCQ_zZIiGLA","https://youtu.be/EVg8orAhz4g"};
            string[] animeSites = { "4Anime: https://4anime.gg/", "Crunchyroll: https://www.crunchyroll.com/","NSFW!!-HeantaiHaven: https://hentaihaven.xxx", "9anime : https://9anime.to/" };
            Random randomIndex = new Random();
            

            if (command == "?")
            {
                TextField.Text += "List of commands: \n #changeWaifu/category/tag \n ...list of categorys: sfw, nsfw \n ...list of sfw tags: waifu, neko, shinobu, megumin, bully, cuddle, cry, hug, awoo, kiss, lick, pat, smug, bonk, yeet, blush, smile, wave, highfive, handhold, nom, bite, glomp, slap, kill, kick, happy, wink, poke, dance, cringe \n list of nsfw tags: waifu, neko, trap \n #anime \n #song \n #site";
                TextField.Text += "\n";
            }
            else if (splitedCommand[0] == "#changeWaifu")
            {
                if (splitedCommand[1] == "sfw" && sfwTags.Contains(splitedCommand[2]))
                {
                    getWaifu(splitedCommand[1] + "/" + splitedCommand[2]);
                }
                else if (splitedCommand[1] == "nsfw" && nsfwTags.Contains(splitedCommand[2]))
                {
                    getWaifu(splitedCommand[1] + "/" + splitedCommand[2]);
                }
                else
                {
                    TextField.Text += "invalid command, try ?" + "\n";
                }
            }
            else if (command == "#song")
            {
                Nullable<int> index = randomIndex.Next(0, songs.Length-1);
                System.Diagnostics.Process.Start(songs[index != null? (int)index:0]);
            }
            else if(command == "#anime")
            {
                getAnime();
            }
            else if(command== "#site")
            {
                Nullable<int> index = randomIndex.Next(0, animeSites.Length - 1);
                TextField.Text += animeSites[index != null ? (int)index : 0] + "\n";
            }
            else if (splitedCommand[0] == "#theme")
            {
                //tady se budou volat ty jednotlivé metody ze třídy Themes
                if (splitedCommand[1] == "dark")
                {
                    DarkMode();
                }else if (splitedCommand[1] == "light")
                {
                    LightMode();
                }
                else if (splitedCommand[1] == "pink")
                {
                    PinkMode();
                }
                else
                {
                    TextField.Text += "invalid command, try ?" + "\n";
                }
            }
            else
            {
                TextField.Text += "invalid command, try ?" + "\n";
                
            }
        }

        private void getWaifu(string parameters)
        {
            string apiContent;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.waifu.pics/" + parameters);

            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format.
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);


            apiContent = readStream.ReadToEnd();
            response.Close();
            readStream.Close();
            string[] imgUrl = apiContent.Split('"');
            //richTextBox1.Text = subs[3];

            history.Add(imgUrl[3]);
            DisplayField.Load(history.Current);
            
        }
        private void getAnime()
        {
            
            string apiContent;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.jikan.moe/v4/random/anime");

            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format.
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            
            apiContent = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(apiContent);
            TextField.Text += myDeserializedClass.data.title + "\n";
            TextField.Text += myDeserializedClass.data.images;

        }
        private void EnterField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            string command = EnterField.Text; //stejne tady. Jako what the fuck are you doing, guys?
            if (command != "" || command != " ") executeCommand(command);
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            DisplayField.Load(history.Prev());
        }
        private void Next_Click(object sender, EventArgs e)
        {
            DisplayField.Load(history.Next());
        }

        private void save_Click(object sender, EventArgs e) {
            history.Save();
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

    }
}
