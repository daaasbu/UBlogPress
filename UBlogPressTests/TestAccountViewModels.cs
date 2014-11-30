using System;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

// Commit test 

namespace UBlogPress.Test
{
    [TestFixture]
    public class TestAccountViewModels
    {
        private ExternalLoginConfirmationViewModel externalLoginConfirmation;
        private ExternalLoginListViewModel externalLoginList;
        private SendCodeViewModel sendCode;
        private VerifyCodeViewModel verifyCode;
        private ForgotViewModel forgot;
        private LoginViewModel login;
        private RegisterViewModel register;
        private ResetPasswordViewModel resetPassword;
        private ForgotPasswordViewModel forgotPassword;

        [SetUp] 
        public void Init()
        {

            externalLoginConfirmation = new ExternalLoginConfirmationViewModel()
            {
                Email = "paulmccartney@beatles.com"
            };

            externalLoginList = new ExternalLoginListViewModel()
            {
                ReturnUrl = "google.com"
            };

            sendCode = new SendCodeViewModel()
            {
                SelectedProvider = "provider",
                ReturnUrl = "returnurl.com",
                RememberMe = false,
                //Providers = ICollection<System.Web.Mvc.SelectListItem> 
            };

            verifyCode = new VerifyCodeViewModel()
            {
                Provider = "prov",
                Code = "code1234",
                ReturnUrl = "yahoo.com",
                RememberBrowser = false,
                RememberMe = true
            };

            forgot = new ForgotViewModel()
            {
                Email = "benjaminfranklin@gmail.com"
            };

            login = new LoginViewModel()
            {
                Email = "larrypage@gmail.com",
                Password = "pwd",
                RememberMe = false
            };

            register = new RegisterViewModel()
            {
                Email = "",
                NameDisplay = "",
                NameBlog = "lifehacker",
                Password = "passwd",
                ConfirmPassword = "passwd",
                NameFirst = "Philip",
                NameMiddle = "Seymour",
                NameLast = "Hoffman",
                Birthday = new DateTime(1991, 7, 21)
            };

            resetPassword = new ResetPasswordViewModel()
            {
                Email = "sergeybrin@gmail.com",
                Password = "12345678",
                ConfirmPassword = "1234",
                Code = "code1234"
            };

            forgotPassword = new ForgotPasswordViewModel()
            {
                Email = "johnlennon@beatles.com"
            };

        }



    }
}
