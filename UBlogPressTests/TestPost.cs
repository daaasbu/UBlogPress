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
        private Post _post;

        [SetUp] 
        public void Init()
        {
            _post = new Post()
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
            Assert.AreEqual(_post.Id, 123);
        }

        [TestMethod]
        public void TitleTest()
        {
            Assert.AreEqual(_post.Title, "Post1");
        }

        [TestMethod]
        public void ContentPostTest()
        {
            Assert.AreEqual(_post.ContentPost, "SomeContent");
        }

        [TestMethod]
        public void PublishedTest()
        {
            Assert.AreEqual(_post.Published, true);
        }

        [TestMethod]
        public void DtCreatedTest()
        {
            Assert.AreEqual(_post.DtCreated, new DateTime(2014, 2, 3));
        }

        [TestMethod]
        public void DtUpdatedTest()
        {
            Assert.AreEqual(_post.DtUpdated, new DateTime(2014, 11, 26));
        }

        [TestMethod]
        public void EnabledCommentTest()
        {
            Assert.AreEqual(_post.EnabledComment, false);
        }

        [TestMethod]
        public void BlogIdTest()
        {
            Assert.AreEqual(_post.BlogId, 456);
        }
    }
}
