﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu
{
    /* #########################
 * 
 *   V javascriptu bychom
 *   toto nemuseli řešit
 * 
 * #########################*/
    class WaifuImJSONClasses
    {
        public class Image
        {
            public string file { get; set; }
            public string extension { get; set; }
            public int image_id { get; set; }
            public int favourites { get; set; }
            public string dominant_color { get; set; }
            public string source { get; set; }
            public DateTime uploaded_at { get; set; }
            public bool is_nsfw { get; set; }
            public string width { get; set; }
            public string height { get; set; }
            public string url { get; set; }
            public string preview_url { get; set; }
            public List<Tag> tags { get; set; }
        }

        public class RootImg
        {
            public Image images { get; set; }
        }

        public class Tag
        {
            public int tag_id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public bool is_nsfw { get; set; }
        }


    }
}
