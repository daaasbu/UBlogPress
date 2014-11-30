using System;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;


namespace UBlogPress.Test
{
    [TestFixture]
    public class TestTag
    {
        private Tag _tag;

        [SetUp]
        public void Init()
        {
            _tag = new Tag()
            {
                Id = 123,
                Name = "programming",
                PostId = 456
            };
        }

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(_tag.Id, 123);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(_tag.Name, "programming");
        }

        [TestMethod]
        public void PostIdTest()
        {
            Assert.AreEqual(_tag.PostId, 456);
        }
    }
}
