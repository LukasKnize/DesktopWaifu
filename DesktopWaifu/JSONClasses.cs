using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu {
    /* #########################
     * 
     *   JESTLI TOHLE FUNGUJE
     *   NEZAHEJTE NA TO
     * 
     * #########################*/


    public class Jpg {
        public string image_url { get; set; }
        public string small_image_url { get; set; }
        public string large_image_url { get; set; }
    }

    public class Webp {
        public string image_url { get; set; }
        public string small_image_url { get; set; }
        public string large_image_url { get; set; }
    }

    public class Images {
        public Jpg jpg { get; set; }
        public Webp webp { get; set; }
        public object image_url { get; set; }
        public object small_image_url { get; set; }
        public object medium_image_url { get; set; }
        public object large_image_url { get; set; }
        public object maximum_image_url { get; set; }
    }

    public class Trailer {
        public object youtube_id { get; set; }
        public object url { get; set; }
        public object embed_url { get; set; }
        public Images images { get; set; }
    }

    public class From {
        public Nullable<int> day { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> year { get; set; }
    }

    public class To {
        public object day { get; set; }
        public object month { get; set; }
        public object year { get; set; }
    }

    public class Prop {
        public From from { get; set; }
        public To to { get; set; }
    }

    public class Aired {
        public Nullable<DateTime> from { get; set; }
        public object to { get; set; }
        public Prop prop { get; set; }
        public string @string { get; set; }
    }

    public class Broadcast {
        public object day { get; set; }
        public object time { get; set; }
        public object timezone { get; set; }
        public object @string { get; set; }
    }

    public class Studio {
        public Nullable<int> mal_id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Genre {
        public Nullable<int> mal_id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Data {
        public Nullable<int> mal_id { get; set; }
        public string url { get; set; }
        public Images images { get; set; }
        public Trailer trailer { get; set; }
        public string title { get; set; }
        public object title_english { get; set; }
        public string title_japanese { get; set; }
        public List<string> title_synonyms { get; set; }
        public string type { get; set; }
        public string source { get; set; }
        public Nullable<int> episodes { get; set; }
        public string status { get; set; }
        public bool airing { get; set; }
        public Aired aired { get; set; }
        public string duration { get; set; }
        public string rating { get; set; }
        public object score { get; set; }
        public object scored_by { get; set; }
        public Nullable<int> rank { get; set; }
        public Nullable<int> popularity { get; set; }
        public Nullable<int> members { get; set; }
        public Nullable<int> favorites { get; set; }
        public object synopsis { get; set; }
        public object background { get; set; }
        public object season { get; set; }
        public object year { get; set; }
        public Broadcast broadcast { get; set; }
        public List<object> producers { get; set; }
        public List<object> licensors { get; set; }
        public List<Studio> studios { get; set; }
        public List<Genre> genres { get; set; }
        public List<object> explicit_genres { get; set; }
        public List<object> themes { get; set; }
        public List<object> demographics { get; set; }
    }

    public class Root {
        public Data data { get; set; }
    }
}
