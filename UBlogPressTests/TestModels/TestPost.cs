using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
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

        [Test]
        public void IdTest()
        {
            Assert.AreEqual(_post.Id, 123);
        }

        [Test]
        public void TitleTest()
        {
            Assert.AreEqual(_post.Title, "Post1");
        }

        [Test]
        public void ContentPostTest()
        {
            Assert.AreEqual(_post.ContentPost, "SomeContent");
        }

        [Test]
        public void PublishedTest()
        {
            Assert.AreEqual(_post.Published, true);
        }

        [Test]
        public void DtCreatedTest()
        {
            Assert.AreEqual(_post.DtCreated, new DateTime(2014, 2, 3));
        }

        [Test]
        public void DtUpdatedTest()
        {
            Assert.AreEqual(_post.DtUpdated, new DateTime(2014, 11, 26));
        }

        [Test]
        public void EnabledCommentTest()
        {
            Assert.AreEqual(_post.EnabledComment, false);
        }

        [Test]
        public void BlogIdTest()
        {
            Assert.AreEqual(_post.BlogId, 456);
        }
    }
}
