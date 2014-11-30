using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UBlogPress.Models;
using Assert = NUnit.Framework.Assert;

namespace UBlogPress.Test.TestModels
{
    [TestClass]
    public class TestPostViewModels
    {
        private PostViewModel _postViewModel;

        [SetUp] 
        public void Init()
        {
            _postViewModel = new PostViewModel()
            {
                Title = "title",
                ContentPost = "somecontent",
                Published = true,
                EnabledComment = false
            };
        }

        [Test]
        public void PostViewModelTest()
        {
            Assert.AreEqual(_postViewModel.Title, "title");
            Assert.AreEqual(_postViewModel.ContentPost, "somecontent");
            Assert.AreEqual(_postViewModel.Published, true);
            Assert.AreNotEqual(_postViewModel.EnabledComment, true);
        }
    }
}
