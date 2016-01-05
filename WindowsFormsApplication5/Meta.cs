using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Meta
    {
        private int meta_id;
        private int post_id;
        private String meta_key;
        private String meta_value;

        public Meta(String line)
        {
            String original_line = line;
            meta_id = Int32.Parse(line.Substring(0, line.IndexOf(",")));
            line = line.Substring(line.IndexOf(",")+1);
            post_id = Int32.Parse(line.Substring(0, line.IndexOf(",")));
            line = line.Substring(line.IndexOf(",") + 1);
            meta_key = line.Substring(0, line.IndexOf(","));
            line = line.Substring(line.IndexOf(",") + 1);
            meta_value = line.Substring(0);
        }
        public int get_meta_id()
        {
            return meta_id;
        }

        public int get_post_id()
        {
            return post_id;
        }

        public String get_meta_key()
        {
            return meta_key;
        }

        public String get_meta_value()
        {
            return meta_value;
        }
    }
}
