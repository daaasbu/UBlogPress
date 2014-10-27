using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string NameBlog { get; set; }
        public DateTimeOffset OffsetTMZ { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}