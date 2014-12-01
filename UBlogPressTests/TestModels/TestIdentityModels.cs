using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Mocks;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
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
                DtCreated = new DateTime(2014, 10, 1),
                DtUpdated = new DateTime(2014, 11, 30),
                Birthday = new DateTime(1991, 7, 21),
                BlogId = 123
            };
        }

        [Test]
        public void ApplicationUserTest()
        {
            Assert.AreEqual(_applicationUser.NameLast, "Hoffman");
            Assert.AreEqual(_applicationUser.NameFirst, "Philip");
            Assert.AreEqual(_applicationUser.NameMiddle, "Seymour");
            Assert.AreEqual(_applicationUser.Role, "default");
            Assert.AreEqual(_applicationUser.NameDisplay, "Phil");
            Assert.AreEqual(_applicationUser.NameBlog, "lifehacker");
            Assert.AreEqual(_applicationUser.Email, "psh@gmail.com");
            Assert.AreEqual(_applicationUser.DtCreated, new DateTime(2014, 10, 1));
            Assert.AreEqual(_applicationUser.DtUpdated, new DateTime(2014, 11, 30));
            Assert.AreEqual(_applicationUser.Birthday, new DateTime(1991, 7, 21));
            Assert.AreEqual(_applicationUser.BlogId, 123);
        }
    }
}
