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
    internal class CommandExecution {
        static private Random rng = new Random();
        static internal void Execute(string command, ref string url) {
                if (Program.form.Output.Text.Split('\n').Length > 22) Program.form.Output.Text = "";
                command = command.Trim().ToLower();
                Program.form.Output.Text += $"[~] command >> {(command != "" ? command : "---")}\n";
                Common.CmdHistory.Add(command);
                string[] args = command.Split(new char[] { '/', ' ', '.' });
                string[] Tags1 = { "waifu", "neko", "shinobu", "trap", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" };
                string[] Tags2 = { "uniform", "maid", "marin-kitagawa", "mori-calliope", "raiden-shogun", "oppai", "selfies", "ass", "hentai", "milf", "oral", "paizuri", "ecchi", "ero" };
                string[] songs = { "https://youtu.be/SoKLSIXccgU", "https://youtu.be/1R_PRloutY8", "https://youtu.be/3NLsyjOH92k", "https://youtu.be/DFGJ8PhjrlM", "https://youtu.be/sSfAuBS54s4", "https://youtu.be/yIfkpbMLLsY", "https://youtu.be/i80OHgDwfZI", "https://youtu.be/QkQ5SfZ0YlM", "https://youtu.be/0oMT_6Zu4a4", "https://youtu.be/nCQ_zZIiGLA", "https://youtu.be/EVg8orAhz4g" };
                string[] animeSites = { "4Anime: https://4anime.gg/", "Crunchyroll: https://www.crunchyroll.com/", "[!]NSFW[!]-HeantaiHaven: https://hentaihaven.xxx", "9anime : https://9anime.to/" };


                if (command == "?") {
                    Program.form.Output.Text += $@"[?] List of commands:
{'"'}[change] [category] [tag]{'"'}
...list of categorys: sfw, nsfw
...list of sfw tags: waifu, neko, shinobu, megumin, bully, cuddle, cry, hug, awoo, kiss, lick, pat, smug, bonk, yeet, blush, smile, wave, highfive, handhold, nom, bite, glomp, slap, kill, kick, happy, wink, poke, dance, cringe
...list of nsfw tags: n_waifu, n_neko, trap, ass, hentai, milf, oral, paizuri, ecchi, ero
Other Possible Commands:
{'"'}anime{'"'} - 
{'"'}song{'"'} - opens a random song on YT in a browser
{'"'}site{'"'} - gives you a link to a random anime website";
                    Program.form.Output.Text += "\n";
                }
                else if (args[0] == "change") {
                    if (Tags1.Contains(args[1]) || Tags2.Contains(args[1])) {
                        GetWaifu(args[1], Tags2.Contains(args[1]));
                    }
                    else {
                        Program.form.Output.Text += "[!] Invalid command, try ?\n";
                    }
                }
                else if (command == "song") {
                    Nullable<int> index = rng.Next(0, songs.Length - 1);
                (new Weeb_browser(songs[index != null ? (int)index : 0])).Show();
                //System.Diagnostics.Process.Start("\"" + songs[index != null ? (int)index : 0] + "\"");
                }
                else if (command == "anime") {
                    var apireturn = Getter.getAnime();
                    Program.form.Output.Text += apireturn.url + "\n"; //Item1 accessne prvni item v tuplu takze string
                    Program.form.Output.Text += apireturn.img.ToString(); //Item2 accessne druhy item a Item3 by accessnul treti item a tak dale.
                    url = apireturn.url;
                }
                else if (command == "site") {
                    Nullable<int> index = rng.Next(0, animeSites.Length - 1);
                    Program.form.Output.Text += animeSites[index != null ? (int)index : 0] + "\n";
                    url = animeSites[index != null ? (int)index : 0];
                }
                else if (args[0] == "theme") {
                    //tady se budou volat ty jednotlivé metody ze třídy Themes
                    if (args[1] == "dark") {
                        Common.theme_manager.Dark();
                    }
                    else if (args[1] == "light") {
                        Common.theme_manager.Light();
                    }
                    else if (args[1] == "pink") {
                        Common.theme_manager.Pink();
                    }
                    else {
                        Program.form.Output.Text += "[!] Invalid command, try ?\n";
                    }
                }
                else {
                    Program.form.Output.Text += "[!] Invalid command, try ?\n";

                }

        }
        static internal void GetWaifu(string tag, bool sw_tch = false) {
            //TextField.Text += TextField.Text.Length == 0 ? "" : "Program.form.Loading";
            Program.form.Loading.Visible = true;
            Program.form.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            string img_url = sw_tch ? Getter.getWaifu2(tag) : Getter.getWaifu(tag);
            Common.ImgHistory.Add(img_url);
            Program.form.Display.Load(Common.ImgHistory.Current.path);
            //TextField.Text += TextField.Text.Length == 0 ? "" : ", Done\n";
            Program.form.Loading.Visible = false;
            Program.form.Refresh();
            Cursor.Current = Cursors.Default;
        }
    }
}
