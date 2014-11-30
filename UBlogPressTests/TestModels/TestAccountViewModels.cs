using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
    public class TestAccountViewModels
    {
        private ExternalLoginConfirmationViewModel _externalLoginConfirmation;
        private ExternalLoginListViewModel _externalLoginList;
        private SendCodeViewModel _sendCode;
        private VerifyCodeViewModel _verifyCode;
        private ForgotViewModel _forgot;
        private LoginViewModel _login;
        private RegisterViewModel _register;
        private ResetPasswordViewModel _resetPassword;
        private ForgotPasswordViewModel _forgotPassword;

        [SetUp] 
        public void Init()
        {
            _externalLoginConfirmation = new ExternalLoginConfirmationViewModel()
            {
                Email = "paulmccartney@beatles.com"
            };

            _externalLoginList = new ExternalLoginListViewModel()
            {
                ReturnUrl = "google.com"
            };

            _sendCode = new SendCodeViewModel()
            {
                SelectedProvider = "provider",
                ReturnUrl = "returnurl.com",
                RememberMe = false
            };

            //_sendCode.Providers = new ICollection<System.Web.Mvc.SelectListItem>
            //{
            //    new SelectListItem()
            //};

            _verifyCode = new VerifyCodeViewModel()
            {
                Provider = "prov",
                Code = "code1234",
                ReturnUrl = "yahoo.com",
                RememberBrowser = false,
                RememberMe = true
            };

            _forgot = new ForgotViewModel()
            {
                Email = "benjaminfranklin@gmail.com"
            };

            _login = new LoginViewModel()
            {
                Email = "larrypage@gmail.com",
                Password = "pwd",
                RememberMe = false
            };

            _register = new RegisterViewModel()
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

            _resetPassword = new ResetPasswordViewModel()
            {
                Email = "sergeybrin@gmail.com",
                Password = "12345678",
                ConfirmPassword = "1234",
                Code = "code1234"
            };

            _forgotPassword = new ForgotPasswordViewModel()
            {
                Email = "johnlennon@beatles.com"
            };

        }

        [Test]
        public void ExternalLoginConfirmationTest()
        {
            Assert.AreEqual(_externalLoginConfirmation.Email, "paulmccartney@beatles.com");
        }

        [Test]
        public void ExternalLoginListTest()
        {
            Assert.AreEqual(_externalLoginList.ReturnUrl, "google.com");
        }

        [Test]
        public void SendCodeTest()
        {
            Assert.AreEqual(_sendCode.SelectedProvider, "provider");
            Assert.AreEqual(_sendCode.ReturnUrl, "returnurl.com");
            Assert.AreEqual(_sendCode.RememberMe, false); ;
            //Assert.AreEqual(_sendCode.Providers.Contains(new SelectListItem()), true);
        }

        [Test]
        public void VerifyCodeTest()
        {
            Assert.AreEqual(_verifyCode.Provider, "prov");
            Assert.AreEqual(_verifyCode.Code, "code1234");
            Assert.AreEqual(_verifyCode.ReturnUrl, "yahoo.com");
            Assert.AreEqual(_verifyCode.RememberBrowser, false);
            Assert.AreEqual(_verifyCode.RememberMe, true);
        }

        [Test]
        public void ForgotTest()
        {
            Assert.AreEqual(_forgot.Email, "benjaminfranklin@gmail.com");
        }

        [Test]
        public void LoginTest()
        {
            Assert.AreEqual(_login.Email, "larrypage@gmail.com");
            Assert.AreEqual(_login.Password, "pwd");
            Assert.AreEqual(_login.RememberMe, false);
        }

        [Test]
        public void RegisterTest()
        {
            Assert.AreEqual(_register.Email,"psh@gmail.com");
            Assert.AreEqual(_register.NameDisplay, "Phil");
            Assert.AreEqual(_register.NameBlog, "lifehacer");
            Assert.AreEqual(_register.Password, "passwd");
            Assert.AreEqual(_register.ConfirmPassword, "passwd");
            Assert.AreEqual(_register.NameFirst, "Philip");
            Assert.AreEqual(_register.NameMiddle, "Seymour");
            Assert.AreEqual(_register.NameLast, "Hoffman");
            Assert.AreEqual(_register.Birthday, new DateTime(1991, 7, 21));
        }
    }
}
