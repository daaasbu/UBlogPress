using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name_first { get; set; }
        public string Name_last { get; set; }
        public string Name_middle { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DT_created_user { get; set; }
        public DateTime DT_updated_user { get; set; }
        public string Birthday { get; set; }
        
        public virtual Blog Blog { get; set; }

    }
}