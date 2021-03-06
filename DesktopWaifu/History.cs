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
        internal int _max; // Maximalni pocet itemu
        internal int _curr = 0;
        private List<T> _history = new List<T>();
        // _ < - 0 [] [] [] [] 4 < - E
        //       - O   < -   N + (old-new)
        //       - P   < -   N + (prev-next)
        public History(int maxItems) {
            _max = maxItems;
        }
        
        internal T Current { get { return _history[_curr]; } }
        internal int Count { get { return _history.Count; } }
        internal T First { get { return _history[0]; } }
        internal T Last { get { return _history[_history.Count-1]; } }
        internal List<T> ToList() { return _history; }
        internal (bool,T) Next() {
            if (_history.Count <= 0) return (false, default(T));
            if (_curr >= _history.Count-1) return (false, _history[_curr]);
            _curr++;
            var ret = _curr >=_max-1 ? false : true;
            return (ret,_history[_curr]);
        }
        internal (bool, T) Prev() {
            if (_history.Count <=0) return (false, default(T));
            if (_curr <= 0) return (false,_history[0]);
            _curr--;
            var ret = _curr >= _max - 1 ? false : true;
            return (ret, _history[_curr]);
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
