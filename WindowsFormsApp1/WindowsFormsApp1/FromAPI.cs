using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FromAPI
    {
        public FromAPI(string name, string url)
        {
            Url = url;
        }
        //Your Properties are auto-implemented.
        public string Url { get; set; }
    }
}
