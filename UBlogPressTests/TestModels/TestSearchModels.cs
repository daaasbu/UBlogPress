using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
    public class TestSearchModels
    {
        private SearchUserModel _searchUser;

        [SetUp]
        public void Init()
        {
            _searchUser = new SearchUserModel()
            {
                NameDisplay = "Bigfoot",
                Name = "Charles Foot",
                DtCreated = new DateTime(1972,10,1)
            };
        }

        [TestMethod]
        public void SearchUserModelTest()
        {
            Assert.AreEqual(_searchUser.NameDisplay, "Bigfoot");
            Assert.AreEqual(_searchUser.Name, "Charles Foot");
            Assert.AreEqual(_searchUser.DtCreated, new DateTime(1972, 10, 1));
        }
    }
}
