using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Controllers;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestControllers
{
    [TestClass]
    public class TestAccountController
    {
        private AccountController _accountController;

        [SetUp]
        public void Init()
        {
            _accountController = new AccountController();
        }

        [TestMethod]
        public void TestLoginSuccess()
        {
            
        }

        [TestMethod]
        public void TestLoginFailure()
        {
            
        }
       
    ]
}
}
