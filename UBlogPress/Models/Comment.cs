using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string ContentComment { get; set; }
        public DateTime DTcreatedcomment { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
        public int ParentID { get; set; }

        public virtual Post Post { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Post ParentComment { get; set; }
    }
}