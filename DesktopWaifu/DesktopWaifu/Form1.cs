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

namespace DesktopWaifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getWaifu("sfw/waifu");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string command = textBox1.Text;
            if (command != "")
            {
                executeCommand(command);
            }
        }

        private void executeCommand(string command)
        {
            richTextBox1.Text += command + "\n" ;
            string[] splitedCommand = command.Split('/');
            string[] sfwTags = { "waifu", "neko", "shinobu", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" };
            string[] nsfwTags = { "waifu", "neko", "trap" };
            string[] songs = {"https://youtu.be/SoKLSIXccgU","https://youtu.be/1R_PRloutY8","https://youtu.be/3NLsyjOH92k","https://youtu.be/DFGJ8PhjrlM","https://youtu.be/sSfAuBS54s4","https://youtu.be/yIfkpbMLLsY","https://youtu.be/i80OHgDwfZI","https://youtu.be/QkQ5SfZ0YlM","https://youtu.be/0oMT_6Zu4a4","https://youtu.be/nCQ_zZIiGLA","https://youtu.be/EVg8orAhz4g"};
            string[] animeList = { "Sword Art Online", "Tokyo Ghoul", "Attack on Titan", "Death Note","Seven Deadly Sins", "My Dress-up darling", "Blend S", "Darling in the franxx", "Eromanga-sensei", "Don't Toy with Me, Miss Nagatoro", "Miss Kobayashi's Dragon Maid", "Boku No Pico"};
            string[] animeSites = { "4Anime: https://4anime.gg/", "Crunchyroll: https://www.crunchyroll.com/","NSFW!!-HeantaiHaven: https://hentaihaven.xxx", "9anime : https://9anime.to/" };
            Random randomIndex = new Random();

            if (command == "?")
            {
                richTextBox1.Text += "List of commands: \n #changeWaifu/category/tag \n ...list of categorys: sfw, nsfw \n ...list of sfw tags: waifu, neko, shinobu, megumin, bully, cuddle, cry, hug, awoo, kiss, lick, pat, smug, bonk, yeet, blush, smile, wave, highfive, handhold, nom, bite, glomp, slap, kill, kick, happy, wink, poke, dance, cringe \n list of nsfw tags: waifu, neko, trap \n #anime \n #song \n #site";
                richTextBox1.Text += "\n";
            }else if (splitedCommand[0] == "#changeWaifu")
            {
                if (splitedCommand[1] == "sfw" && sfwTags.Contains(splitedCommand[2]))
                {
                    getWaifu(splitedCommand[1] + "/" + splitedCommand[2]);
                }
                else if (splitedCommand[1] == "nsfw" && nsfwTags.Contains(splitedCommand[2]))
                {
                    getWaifu(splitedCommand[1] + "/" + splitedCommand[2]);
                }
            }
            else if (command == "#song")
            {
                int index = randomIndex.Next(0, songs.Length-1);
                System.Diagnostics.Process.Start(songs[index]);
            }
            else if(command == "#anime")
            {
                int index = randomIndex.Next(0, animeList.Length - 1);
                richTextBox1.Text += animeList[index] + "\n";
            }
            else if(command== "#site")
            {
                int index = randomIndex.Next(0, animeSites.Length - 1);
                richTextBox1.Text += animeSites[index] + "\n";
            }
            else
            {
                richTextBox1.Text += "invalid command, try ?" + "\n";
                
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

            pictureBox1.Load(imgUrl[3]);
        }
    }
}
