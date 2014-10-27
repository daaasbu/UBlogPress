using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public string NameTag { get; set; }

        public virtual Post Post { get; set; }
    }
}