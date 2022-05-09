using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;

namespace DesktopWaifu {
    internal class History<T> {
        private int _max; // Maximalni pocet itemu
        private int _curr = 0;
        private List<T> _history = new List<T>();
        // _ < - 0 [] [] [] [] 4 < - E
        //       - O   < -   N + (old-new)
        //       - P   < -   N + (prev-next)
        public History(int maxItems) {
            _max = maxItems;
        }
        
        internal T Current { get { return _history[_curr]; } }
        internal T Next() {
            if (_history.Count <= 0) return default(T);
            if (_curr >= _history.Count-1) return _history[_curr];
            _curr++;
            return _history[_curr];
        }
        internal T Prev() {
            if (_history.Count <=0) return default(T);
            if (_curr <= 0) return _history[0];
            _curr--;
            return _history[_curr];
        }
        internal bool Add(T new_item, out T destroyed) {
            var destroy = false;
            _history.Add(new_item);
            destroyed = _history[0];
            if (_history.Count > _max) {
                _history.RemoveAt(0);
                destroy = true;
            }
            _curr = _history.Count-1;
            return destroy;
        }
        internal void Add(T new_item) {
            Add(new_item, out _);
        }
        internal T GetIndex(int index) {
            return _history[index];
        }
    }
}
