using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Controllers;
using UBlogPress.Models;
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

        [Test]
        public void TestRegisterLoginSuccess()
        {
            var register = new RegisterViewModel()
            {
                Email = "psh@gmail.com",
                NameDisplay = "Phil",
                NameBlog = "lifehacker",
                Password = "passwd",
                ConfirmPassword = "passwd",
                NameFirst = "Philip",
                NameMiddle = "Seymour",
                NameLast = "Hoffman",
                Birthday = new DateTime(1991, 7, 21)
            };
            var task = _accountController.Register(register);

            var login = new LoginViewModel()
            {
                Email = "psh@gmail.com",
                Password = "passwd",
                RememberMe = false
            };
            var result = _accountController.Login(login, "returnUrl.com");
   
            Assert.IsNotNull(result, "Action result is null");
            Assert.IsInstanceOf(typeof (Task<ActionResult>), result, "Action result of wrong type");
        }

        [Test]
        public void TestLoginSimple()
        {
            var result = _accountController.Login("google.com") as ViewResult;
            Assert.IsInstanceOf(typeof(ViewResult), result);
        }
    }
}
