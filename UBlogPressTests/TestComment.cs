using System;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;


namespace UBlogPress.Test
{
    [TestFixture]
    public class TestComment
    {
        private Comment c;

        [SetUp]
        public void Init()
        {
            c = new Comment()
            {
                Id = 123,
                Content = "SomeContent",
                DtCreated = new DateTime(2014, 2, 3),
                NameDisplay = "name",
                ApplicationUserId = "456",
                PostId = 789
            };
        }

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(c.Id, 123);
        }

        [TestMethod]
        public void ContentTest()
        {
            Assert.AreEqual(c.Content, "SomeContent");
        }

        [TestMethod]
        public void DtCreatedTest()
        {
            Assert.AreEqual(c.DtCreated, new DateTime(2014, 2, 3));
        }

        [TestMethod]
        public void NameDisplayTest()
        {
            Assert.AreEqual(c.NameDisplay, "name");
        }

        [TestMethod]
        public void ApplicationUserIdTest()
        {
            Assert.AreEqual(c.ApplicationUserId, "456");
        }

        [TestMethod]
        public void PostIdTest()
        {
            Assert.AreEqual(c.PostId, 789);
        }
    }
}
