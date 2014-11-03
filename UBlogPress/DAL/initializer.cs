using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UBlogPress.Models;
namespace UBlogPress.DAL
{
    public class initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var s1 = new User { Id = 1, NameLast = "Asbury", NameFirst = "Dana", NameMiddle = "Andrew", Role = "User", Email = "daaasbu@indiana.edu", Login = "daaasbu", Password = "password", DtCreated = DateTime.Today, DtUpdated = DateTime.Today, Birthday = DateTime.Today };
            var b1 = new Blog { Id = 1, Name = "Blah", DtCreated = DateTime.Now, DtUpdated = DateTime.Now, IsPublished = true, User = s1, UserId = 1, OffsetTmz = DateTimeOffset.Parse("+1:00") };
            s1.BlogId = b1.Id;
            s1.Blog = b1;
            context.Users.Add(s1);
            context.Blogs.Add(b1);
        }
    }
}