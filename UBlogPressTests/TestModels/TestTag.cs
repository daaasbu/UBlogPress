using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
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

        [Test]
        public void IdTest()
        {
            Assert.AreEqual(_tag.Id, 123);
        }

        [Test]
        public void NameTest()
        {
            Assert.AreEqual(_tag.Name, "programming");
        }

        [Test]
        public void PostIdTest()
        {
            Assert.AreEqual(_tag.PostId, 456);
        }
    }
}
