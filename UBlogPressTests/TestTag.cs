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
        private Tag t;

        [SetUp]
        public void Init()
        {
            t = new Tag()
            {
                Id = 123,
                Name = "programming",
                PostId = 456
            };
        }

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(t.Id, 123);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(t.Name, "programming");
        }

        [TestMethod]
        public void PostIdTest()
        {
            Assert.AreEqual(t.PostId, 456);
        }
    }
}
