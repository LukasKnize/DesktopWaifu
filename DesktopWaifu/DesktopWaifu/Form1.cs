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
        string[] lastWaifu = new string[5];//0-4
        int lastWaifuIndex = 0;                            

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getWaifu("sfw/waifu");
        }
        public class Jpg
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Webp
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Images
        {
            public Jpg jpg { get; set; }
            public Webp webp { get; set; }
            public object image_url { get; set; }
            public object small_image_url { get; set; }
            public object medium_image_url { get; set; }
            public object large_image_url { get; set; }
            public object maximum_image_url { get; set; }
        }

        public class Trailer
        {
            public object youtube_id { get; set; }
            public object url { get; set; }
            public object embed_url { get; set; }
            public Images images { get; set; }
        }

        public class From
        {
            public Nullable<int> day { get; set; }
            public Nullable<int> month { get; set; }
            public Nullable<int> year { get; set; }
        }

        public class To
        {
            public object day { get; set; }
            public object month { get; set; }
            public object year { get; set; }
        }

        public class Prop
        {
            public From from { get; set; }
            public To to { get; set; }
        }

        public class Aired
        {
            public Nullable<DateTime> from { get; set; }
            public object to { get; set; }
            public Prop prop { get; set; }
            public string @string { get; set; }
        }

        public class Broadcast
        {
            public object day { get; set; }
            public object time { get; set; }
            public object timezone { get; set; }
            public object @string { get; set; }
        }

        public class Studio
        {
            public Nullable<int> mal_id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Genre
        {
            public Nullable<int> mal_id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Data
        {
            public Nullable<int> mal_id { get; set; }
            public string url { get; set; }
            public Images images { get; set; }
            public Trailer trailer { get; set; }
            public string title { get; set; }
            public object title_english { get; set; }
            public string title_japanese { get; set; }
            public List<string> title_synonyms { get; set; }
            public string type { get; set; }
            public string source { get; set; }
            public Nullable<int> episodes { get; set; }
            public string status { get; set; }
            public bool airing { get; set; }
            public Aired aired { get; set; }
            public string duration { get; set; }
            public string rating { get; set; }
            public object score { get; set; }
            public object scored_by { get; set; }
            public Nullable<int> rank { get; set; }
            public Nullable<int> popularity { get; set; }
            public Nullable<int> members { get; set; }
            public Nullable<int> favorites { get; set; }
            public object synopsis { get; set; }
            public object background { get; set; }
            public object season { get; set; }
            public object year { get; set; }
            public Broadcast broadcast { get; set; }
            public List<object> producers { get; set; }
            public List<object> licensors { get; set; }
            public List<Studio> studios { get; set; }
            public List<Genre> genres { get; set; }
            public List<object> explicit_genres { get; set; }
            public List<object> themes { get; set; }
            public List<object> demographics { get; set; }
        }

        public class Root
        {
            public Data data { get; set; }
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
                richTextBox1.Text += animeSites[index != null ? (int)index : 0] + "\n";
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
            if (lastWaifuIndex == 4)
            {
                lastWaifuIndex = 0;
            }
            else
            {
                lastWaifuIndex++;
            }
            shiftWaifu(imgUrl[3]);
            
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
            richTextBox1.Text += myDeserializedClass.data.title + "\n";
            richTextBox1.Text += myDeserializedClass.data.images;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               string command = textBox1.Text;
                if (command != "" || command != " ")
                {
                    executeCommand(command);
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lastWaifuIndex == lastWaifu.Length - 1)
            {
                lastWaifuIndex = 0;
            }
            else {
                if (String.IsNullOrEmpty(lastWaifu[lastWaifuIndex]))
                {
                    lastWaifuIndex = 0;
                }
                else
                {
                    lastWaifuIndex++;
                }
            
            }
            richTextBox1.Text += lastWaifu[lastWaifuIndex] + " " + lastWaifuIndex + "\n";
            try
            {
                pictureBox1.Load(lastWaifu[lastWaifuIndex]);
            }
            catch (Exception x)
            {

                richTextBox1.Text += x.Message;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void shiftWaifu(string waifu)
        {
            string[] oldArray = lastWaifu;
            string[] newArray = new string[5];
            for (int i = 0; i < oldArray.Length-1; i++)
            {
                
                newArray[i+1] = oldArray[i];
                
            }
            newArray[0] = waifu;
            lastWaifu = newArray;
        }
    }
}
