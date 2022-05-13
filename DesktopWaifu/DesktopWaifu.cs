using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWaifu {
    public class ExRichTextBox : RichTextBox {
        const int WM_SETCURSOR = 0x0020;
        protected override void WndProc(ref Message m) {
            if (m.Msg == WM_SETCURSOR)
                Cursor.Current = this.Cursor;
            else
                base.WndProc(ref m);
        }
    }
}
