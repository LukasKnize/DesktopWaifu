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
    internal class Getter {
        static internal string getWaifu(string parameters) {
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

            return imgUrl[3];
        }
        //https://api.waifu.im/random/?is_nsfw=false&selected_tags=maid&full=false

        //další api 
        static internal string getWaifu2(bool nsfw, string tag)
        {
            string apiContent;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.waifu.im/random/?is_nsfw=" + nsfw + "&selected_tags=" + tag + "&full=false");

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
            WaifuImJSONClasses.RootImg img = JsonConvert.DeserializeObject<WaifuImJSONClasses.RootImg>(apiContent);
            //string[] imgUrl = apiContent.Split('"');
            //richTextBox1.Text = subs[3];


            return img.images.url;
        }

        static internal (string,Images) getAnime() { // (string,Images) je tzv tuple. Je to slouceni dvou nebo vic hodnot do jedne.
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

            Root apireturn = JsonConvert.DeserializeObject<Root>(apiContent);
            return (apireturn.data.title, apireturn.data.images); // takhle se dela tuple

        }
    }
}
