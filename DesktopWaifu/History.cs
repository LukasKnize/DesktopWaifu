using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;

namespace DesktopWaifu {
    internal class History {
        private int _max; // Maximalni pocet itemu
        private int _curr = 0;
        private string cache = "./cache/";
        private List<string> _history = new List<string>();
        private List<string> _files = new List<string>();
        // _ < - 0 [] [] [] [] 4 < - E
        //       - O   < -   N + (old-new)
        //       - P   < -   N + (prev-next)
        public History(int maxItems) {
            _max = maxItems;
            init();
        }
        private void init() {
            if (Directory.Exists(cache)) {
                var files = Directory.GetFiles(cache);
                foreach (var file in files) {
                    File.Delete(file);
                }
            }
            else Directory.CreateDirectory(cache);
        }
        internal string Current { get { return getfile(_curr); } }
        internal string Next() {
            if (_curr >= _history.Count-1) return getfile(_curr);
            _curr++;
            return getfile(_curr);
        }
        internal string Prev() {
            if (_curr <= 0) return getfile(0);
            _curr--;
            return getfile(_curr);
        }
        private string getfile(int index) {
            if (!File.Exists(cache + _files[index])) download(_history[index], _files[index]);
            return cache+ _files[index];
        }
        internal void Add(string url) {
            var split = url.Split('/');
            var filename = split[split.Length - 1];
            if (!File.Exists(cache+filename)) download(url, filename);

            _history.Add(url);
            _files.Add(filename);

            if (_history.Count > _max) {
                _history.RemoveAt(0);
                File.Delete(cache + _files[0]);
                _files.RemoveAt(0);
            }
            _curr = _history.Count-1;
        }
        internal void Save() {
            var file = getfile(_curr);
            SaveFileDialog savedialog = new SaveFileDialog();
            var ext = file.Split('.').Last();

            savedialog.Filter = $"Image (*.{ext})|*.{ext}|All files (*.*)|*.*";
            savedialog.FilterIndex = 1;
            savedialog.RestoreDirectory = true;
            savedialog.FileName = file.Split('/').Last();
            savedialog.DefaultExt = ext;

            if (savedialog.ShowDialog() == DialogResult.OK) {
                using (var client = new HttpClient()) {
                    using (var s = client.GetStreamAsync(_history[_curr])) {
                        var f = savedialog.OpenFile();
                        s.Result.CopyTo(f);
                        f.Close();
                    }
                }
            }
        }
        private void download(string url, string filename) { //https://stackoverflow.com/a/71949994
            using (var client = new HttpClient()) {
                using (var s = client.GetStreamAsync(url)) {
                    using (var fs = new FileStream(cache+filename, FileMode.OpenOrCreate)) {
                        s.Result.CopyTo(fs);
                        fs.Close();
                    }
                }
            }
        }
    }
}
