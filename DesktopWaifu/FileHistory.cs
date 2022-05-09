using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu {
    internal class FileHistory {
        private History<Img> _history;
        public FileHistory(int maxItems) {
            _history = new History<Img>(maxItems);
        }
        internal Img Current { get { return _history.Current; } }
        internal Img Prev() {
            return _history.Prev();
        }
        internal Img Next() {
            return _history.Next();
        }
        internal void Add(string url) {
            Img cached_img = CacheSystem.Cache(url);
            _history.Add(cached_img);
        }
    }
}
