using System;
using System.Dynamic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

// Commit test 

namespace UBlogPress.Test
{


    [TestFixture]
    public class TestIdentityModels
    {
        private ApplicationUser _applicationUser;
        private ApplicationDbContext _applicationDbContext;
      

        [SetUp] 
        public void Init()
        {
            _applicationUser = new ApplicationUser()
            {
                NameLast = "Hoffman",
                NameFirst = "Philip",
                NameMiddle = "Seymour",
                Role = "default",
                NameDisplay = "Phil",
                NameBlog = "lifehacker",
                Email = "psh@gmail.com",
                DtCreated = new DateTime(2014,10,1);
                DtUpdated = new DateTime(2014,1,30);
                Birthday = new DateTime(1991, 7, 21);
                BlogId = 123;
                // public virtual Blog Blog { get; set; }
            };


            //            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
            //{
            //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            //    // Add custom user claims here
            //    return userIdentity;
            //}

            _applicationDbContext = ApplicationDbContext.Create();
    


            //ApplicationDbContext:
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Tag> Tags { get; set; }
        }

        [TestFixture]
        public void ApplicationUserTest()
        {
            Assert.AreEqual(_applicationUser.NameLast, "Hoffman");
            Assert.AreEqual(_applicationUser.NameFirst, "Philip");
            Assert.AreEqual(_applicationUser.NameMiddle, "Seymour");
            Assert.AreEqual(_applicationUser.Role, "default");
            Assert.AreEqual(_applicationUser.NameDisplay, "Phil");
            Assert.AreEqual(_applicationUser.NameBlog, "lifehacer");
            Assert.AreEqual(_applicationUser.Email, "psh@gmail.com");
            Assert.AreEqual(_applicationUser.DtCreated, new DateTime(2014,10,1));
            Assert.AreEqual(_applicationUser.DtUpdated, new DateTime(2014,11,30));
            Assert.AreEqual(_applicationUser.Birthday, new DateTime(1991, 7, 21));
            Assert.AreEqual(_applicationUser.BlogId, 123);
        }


    }
}
