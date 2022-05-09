using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu {
    internal class Common { //aby vsechno mohlo to accessovat
        static internal FileHistory history = new FileHistory(4); //do zavorky dejte pocet itemu, ktere tam maxialme muzou byt.
        static internal Themes theme_manager = new Themes();
        //static internal History<string> past_commands = new History<string>(1000); Tohle bylo na predchozi prikazy ale moc to nefunguje takze to jenom zakomentuju
    }
}
