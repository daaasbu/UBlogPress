using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string NameLast { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DTcreateduser { get; set; }
        public DateTime DTupdateduser { get; set; }
        public string Birthday { get; set; }
        
        public virtual Blog Blog { get; set; }

        //create_user()

        //delete_user()

    }
}