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
            richTextBox1.Text += command;
            richTextBox1.Text += "\n";
            string[] splitedCommand = command.Split('/');
            string[] sfwTags = { "waifu", "neko", "shinobu", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" };
            string[] nsfwTags = { "waifu", "neko", "trap" };
            
            if (command == "?")
            {
                richTextBox1.Text += "List of commands: \n #changeWaifu/category/tag \n ...list of categorys: sfw, nsfw \n ...list of sfw tags: waifu, neko, shinobu, megumin, bully, cuddle, cry, hug, awoo, kiss, lick, pat, smug, bonk, yeet, blush, smile, wave, highfive, handhold, nom, bite, glomp, slap, kill, kick, happy, wink, poke, dance, cringe \n list of nsfw tags: waifu, neko, trap";
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
            else if (command == "song")
            {
                //do budoucna
                //System.Diagnostics.Process.Start("http://google.com");
            }
            else
            {
                richTextBox1.Text += "invalid command, try ?";
                richTextBox1.Text += "\n";
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
