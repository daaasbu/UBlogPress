using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
    public class TestManageViewModels
    {
        private IndexViewModel _index;
        private ManageLoginsViewModel _manageLogins;
        private FactorViewModel _factor;
        private SetPasswordViewModel _setPassword;
        private ChangePasswordViewModel _changePassword;
        private ChangeEmailViewModel _changeEmail;
        private AddPhoneNumberViewModel _addPhoneNumber;
        private VerifyPhoneNumberViewModel _verifyPhoneNumber;
        private ConfigureTwoFactorViewModel _configureTwoFactor;

        [SetUp]
        public void Init()
        {
            _index = new IndexViewModel()
            {
                HasPassword = false,
                TwoFactor = true,
                BrowserRemembered = true
            };

            _factor = new FactorViewModel()
            {
                Purpose = "purpose"
            };

            _setPassword = new SetPasswordViewModel()
            {
                NewPassword = "password",
                ConfirmPassword = "password"
            };

            _changePassword = new ChangePasswordViewModel()
            {
                OldPassword = "password1",
                NewPassword = "password2",
                ConfirmPassword = "password2"
            };

            _changeEmail = new ChangeEmailViewModel()
            {
                NewEmail = "blah@gmail.com",
                ConfirmEmail = "differentblah@gmail.com"
            };

            _addPhoneNumber = new AddPhoneNumberViewModel()
            {
                Number = "867-5309"
            };

            _verifyPhoneNumber = new VerifyPhoneNumberViewModel()
            {
                Code = "1234",
                PhoneNumber = "867-5309"
            };

            _configureTwoFactor = new ConfigureTwoFactorViewModel()
            {
                SelectedProvider = "selprov"
            };

        }

        [Test]
        public void IndexViewModelTest()
        {
            Assert.AreEqual(_index.HasPassword, false);
            Assert.AreEqual(_index.TwoFactor, true);
            Assert.AreEqual(_index.BrowserRemembered, true);
        }

        [Test]
        public void FactorViewModelTest()
        {
            Assert.AreEqual(_factor.Purpose, "purpose");
        }

        [Test]
        public void SetPasswordViewModelTest()
        {
            Assert.AreEqual(_setPassword.NewPassword, "password");
            Assert.AreEqual(_setPassword.ConfirmPassword, "password");
        }

        [Test]
        public void ChangePasswordViewModelTest()
        {
            Assert.AreEqual(_changePassword.OldPassword, "password1");
            Assert.AreEqual(_changePassword.NewPassword, "password2");
            Assert.AreEqual(_changePassword.ConfirmPassword, "password2");
        }

        [Test]
        public void ChangeEmailViewModelTest()
        {
            Assert.AreNotEqual(_changeEmail.NewEmail,_changeEmail.ConfirmEmail);
        }

        [Test]
        public void AddPhoneNumberViewModelTest()
        {
            Assert.AreEqual(_addPhoneNumber.Number, "867-5309");
        }

        [Test]
        public void VerifyPhoneNumberViewModelTest()
        {
            Assert.AreEqual(_verifyPhoneNumber.Code, "1234");
            Assert.AreEqual(_verifyPhoneNumber.PhoneNumber, "867-5309");
        }

        [Test]
        public void ConfigureTwoFactorViewModelTest()
        {
            Assert.AreEqual(_configureTwoFactor.SelectedProvider, "selprov");
        }
    }
}