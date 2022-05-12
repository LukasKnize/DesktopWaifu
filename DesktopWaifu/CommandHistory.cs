using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu {
    internal class CommandHistory {
        private History<string> _history;
        private int maxreached = 0;
        public CommandHistory(int maxItems) {
            _history = new History<string>(maxItems);
        }
        internal string Current { get { return _history.Current; } }
        internal string Prev() {
            (bool state, string cmd) response = _history.Prev();
            if (maxreached > 0) {
                maxreached = 0;
                response.cmd = _history.Last;
            }
            return response.cmd;
        }
        internal string Next(){
            (bool state, string cmd) response = _history.Next();
            maxreached = !response.state?maxreached+1:0;
            if (maxreached > 0) {
                maxreached = 1;
                response.cmd = "";
            }
            return response.cmd;
        }
        internal void Add(string command) {
            _history.Add(command, out _);
            maxreached = 1;
        }
    }
}
