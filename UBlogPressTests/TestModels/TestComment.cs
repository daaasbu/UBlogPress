using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
    public class TestComment
    {
        private Comment _comment;

        [SetUp]
        public void Init()
        {
            _comment = new Comment()
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
            Assert.AreEqual(_comment.Id, 123);
        }

        [TestMethod]
        public void ContentTest()
        {
            Assert.AreEqual(_comment.Content, "SomeContent");
        }

        [TestMethod]
        public void DtCreatedTest()
        {
            Assert.AreEqual(_comment.DtCreated, new DateTime(2014, 2, 3));
        }

        [TestMethod]
        public void NameDisplayTest()
        {
            Assert.AreEqual(_comment.NameDisplay, "name");
        }

        [TestMethod]
        public void ApplicationUserIdTest()
        {
            Assert.AreEqual(_comment.ApplicationUserId, "456");
        }

        [TestMethod]
        public void PostIdTest()
        {
            Assert.AreEqual(_comment.PostId, 789);
        }
    }
}
