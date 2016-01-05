using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Post
    {
        private int post_id;
        private int post_author;
        private String poste_date;
        private String poste_date_gmt;
        private String post_content;
        private String post_title;
        private String post_excerpt;
        private String post_status;
        private String comment_status;
        private String ping_status;
        private String post_password;
        private String post_name;
        private String to_ping;
        private String pinged;
        private String post_modified;
        private String post_modified_gmt;
        private String post_content_filtered;
        private String post_parent;
        private String guid;
        private String menu_order;
        private String post_type;
        private String post_mime_type;
        private String comment_count;

        public Post(String line)
        {

        }
        public int get_post_id()
        {
            return post_id;
        }

        public String get_post_title()
        {
            return post_title;
        }

        public String get_post_content()
        {
            return post_content;
        }

        public String get_post_name()
        {
            return post_name;
        }

        public String get_post_type()
        {
            return post_type;
        }
    }
}
