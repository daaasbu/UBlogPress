using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string ContentPost { get; set; }
        public Boolean Published { get; set; }
  
        public DateTime DTcreatedpost { get; set; }
        public DateTime DTupdatedpost { get; set; }
        public Boolean EnabledComment { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}