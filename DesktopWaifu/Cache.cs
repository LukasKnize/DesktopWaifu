using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;

namespace DesktopWaifu {
    internal class CacheSystem {

        static internal string cache = "./cache/";

        static internal Img Cache(string url) {
            var split = url.Split('/');
            var filename = split[split.Length - 1];
            if (!File.Exists(cache + filename)) download(url, filename);
            return new Img(url, filename);
        }
        static internal void Destroy() {
            if (Directory.Exists(cache)) Directory.Delete(cache, true);
        }
        static internal void init() {
            if (Directory.Exists(cache)) {
                var files = Directory.GetFiles(cache);
                foreach (var file in files) {
                    File.Delete(file);
                }
            }
            else Directory.CreateDirectory(cache);
        }

        static private void download(string url, string filename) { //https://stackoverflow.com/a/71949994
            using (var client = new HttpClient()) {
                using (var s = client.GetStreamAsync(url)) {
                    using (var fs = new FileStream(cache + filename, FileMode.OpenOrCreate)) {
                        s.Result.CopyTo(fs);
                        fs.Close();
                    }
                }
            }
        }
        static internal void Save(Img image) {
            SaveFileDialog savedialog = new SaveFileDialog();
            var ext = image.filename.Split('.').Last();

            savedialog.Filter = $"Image (*.{ext})|*.{ext}|All files (*.*)|*.*";
            savedialog.FilterIndex = 1;
            savedialog.RestoreDirectory = true;
            savedialog.FileName = image.path.Split('/').Last();
            savedialog.DefaultExt = ext;

            if (savedialog.ShowDialog() == DialogResult.OK) {
                using (var client = new HttpClient()) {
                    using (var s = client.GetStreamAsync(image.url)) {
                        var f = savedialog.OpenFile();
                        s.Result.CopyTo(f);
                        f.Close();
                    }
                }
            }
        }
    }
    internal class Img {
        internal string url;
        internal string filename;
        internal string path;
        internal Img(string url, string filename) {
            this.url = url;
            this.filename = filename;
            this.path = CacheSystem.cache + filename;
        }
        internal void Destroy() {
            File.Delete(path);
        }
    }
}
