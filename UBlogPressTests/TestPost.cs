using System;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;


namespace UBlogPress.Test
{
    [TestFixture]
    public class TestPost
    {
        private Post p;

        [SetUp] 
        public void Init()
        {
            p = new Post()
            {
                Id = 123,
                Title = "Post1",
                ContentPost = "SomeContent",
                Published = true,
                DtCreated = new DateTime(2014, 2, 3),
                DtUpdated = new DateTime(2014, 11, 26),
                EnabledComment = false,
                BlogId = 456
            };
        }

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(p.Id, 123);
        }

        [TestMethod]
        public void TitleTest()
        {
            Assert.AreEqual(p.Title, "Post1");
        }

        [TestMethod]
        public void ContentPostTest()
        {
            Assert.AreEqual(p.ContentPost, "SomeContent");
        }

        [TestMethod]
        public void PublishedTest()
        {
            Assert.AreEqual(p.Published, true);
        }

        [TestMethod]
        public void DtCreatedTest()
        {
            Assert.AreEqual(p.DtCreated, new DateTime(2014, 2, 3));
        }

        [TestMethod]
        public void DtUpdatedTest()
        {
            Assert.AreEqual(p.DtUpdated, new DateTime(2014, 11, 26));
        }

        [TestMethod]
        public void EnabledCommentTest()
        {
            Assert.AreEqual(p.EnabledComment, false);
        }

        [TestMethod]
        public void BlogIdTest()
        {
            Assert.AreEqual(p.BlogId, 456);
        }
    }
}
