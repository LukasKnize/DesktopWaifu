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
            if (_curr >= _history.Count-1) return _history[_curr];
            _curr++;
            return _history[_curr];
        }
        internal T Prev() {
            if (_curr <= 0) return _history[0];
            _curr--;
            return _history[_curr];
        }
        internal void Add(T new_item, out T destroyed) {
            destroyed = null;
            _history.Add(new_item);
            if (_history.Count > _max) {

                _history.RemoveAt(0);
            }
            _curr = _history.Count-1;
        }
        internal T GetIndex(int index) {
            return _history[index];
        }
    }
}
