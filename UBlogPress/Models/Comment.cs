using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DtCreated { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int ParentId { get; set; }

        public virtual Post Post { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Post ParentComment { get; set; }
    }
}