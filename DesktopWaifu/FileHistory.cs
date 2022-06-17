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
    internal class FileHistory {
        private History<Img> _history;
        private (Button, Button) buttons;
        public FileHistory(int maxItems, (Button, Button) buttons) {
            _history = new History<Img>(maxItems);
            this.buttons = buttons;
        }
        internal Img Current { get { return _history.Current; } }
        internal Img Prev() {
            var response = _history.Prev();
            if (!response.Item1) _btn_disable(buttons.Item1);
            _btn_enable(buttons.Item2);
            buttons.Item1.Refresh();
            buttons.Item2.Refresh();
            return response.Item2;
        }
        internal Img Next() {
            var response = _history.Next();
            if (!response.Item1) _btn_disable(buttons.Item2);
            _btn_enable(buttons.Item1);
            buttons.Item1.Refresh();
            buttons.Item2.Refresh();
            return response.Item2;
        }
        internal void Add(string url) {
            Img cached_img = CacheSystem.Cache(url);
            var order = _history.Add(cached_img, out Img destroyed);
            if (order) destroyed.Destroy();
        }
        internal void _btn_disable(Button btn) {
            btn.Enabled = false;
            btn.Cursor = Cursors.No;
            //btn.BackColor = Color.FromArgb(196, btn.BackColor);
        }
        internal void _btn_enable(Button btn) {
            btn.Enabled = true;
            btn.Cursor = Cursors.Default;
            //btn.BackColor = Color.FromArgb(255, btn.BackColor);
        }
    }
}
