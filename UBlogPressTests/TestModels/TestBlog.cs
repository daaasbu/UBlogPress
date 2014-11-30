using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
    public class TestBlog
    {
        private Blog _blog;

        [SetUp]
        public void Init()
        {
            _blog = new Blog()
            {
                Id = 123,
                Name = "Marty McFly",
                OffsetTmz = new DateTimeOffset(1985,10,26,1,21,0,new TimeSpan(10,5,3,1)),
                ApplicationUserId = "1776",
                IsPublished = true,
                DtCreated = new DateTime(2014, 2, 3),
                DtUpdated = new DateTime(2014, 11, 26)
            };
        }

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(_blog.Id, 123);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(_blog.Name, "Marty McFly");
        }

        [TestMethod]
        public void OffsetTmzTest()
        {
            Assert.AreEqual(_blog.OffsetTmz, new DateTimeOffset(1985,10,26,1,21,0,new TimeSpan(10,5,3,1)));
        }
               
        [TestMethod]
        public void ApplicationUserIdTest()
        {
            Assert.AreEqual(_blog.ApplicationUserId, "1776");
        }

        [TestMethod]
        public void IsPublishedTest()
        {
            Assert.AreEqual(_blog.IsPublished, true);
        }

        [TestMethod]
        public void DtCreatedTest()
        {
            Assert.AreEqual(_blog.DtCreated, new DateTime(2014, 2, 3));
        }

        [TestMethod]
        public void DtUpdatedTest()
        {
            Assert.AreEqual(_blog.DtCreated, new DateTime(2014, 11, 26));
        } 
    }
}
