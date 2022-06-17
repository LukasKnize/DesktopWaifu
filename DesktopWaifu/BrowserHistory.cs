using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu
{
    class BrowserHistory
    {
        private History<string> _history;
        public BrowserHistory(int maxItems) {
            _history = new History<string>(maxItems);
        }
        internal string Current { get { return _history.Current; } }
        internal List<string> ToList() { return _history.ToList(); }
        internal string Prev() {
            (bool _, string address) response = _history.Prev();
            return response.address;
        }
        internal string Next() {
            (bool _, string address) response = _history.Next();
            return response.address;
        }
        internal void Add(string command) {
            _history.Add(command, out _);
        }
    }
}
