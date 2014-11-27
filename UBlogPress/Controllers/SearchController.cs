using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UBlogPress.Models;
namespace UBlogPress.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;
        public SearchController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }



         [AcceptVerbs(HttpVerbs.Get)]
        public ViewResult SearchUser()
        {
            return View();
        }

         [AcceptVerbs(HttpVerbs.Post)]
         public ActionResult SearchUser(SearchUserModel model)
         {
             if (!ModelState.IsValid)
             {
                 return View(model);
             }
             else
             {
                 //Only user name given
                 if (model.NameDisplay != null && model.Name == null && model.DtCreated == null)
                 {

                     var user = db.Users.FirstOrDefault(x => x.NameDisplay == model.NameDisplay);

                     if (user == null)
                     {
                         ViewBag.StatusMessage = "No user found by that name";
                         return View();
                     }

                     else
                     {
                         return View("DisplayUser", user);
                     }
                 }
                 // User Name and tag given
                 else if (model.NameDisplay != null && model.Name != null && model.DtCreated == null)
                 {
                     var user = db.Users.FirstOrDefault(x => x.NameDisplay == model.NameDisplay);

                     if (user == null)
                     {
                         ViewBag.StatusMessage = "No user found by that name";
                         return View();
                     }

                     else
                     {
                         var tags = db.Tags.Where(tag => tag.Name == model.Name && tag.Post.Blog.User.Id == user.Id).ToList();
                         var posts = tags.Select(tag => tag.Post);


                         if (posts.Count() == 0)
                         {
                             ViewBag.StatusMessage = "No posts were found that match your criterion";
                             return View();
                         }

                         else
                         {
                             return View("DisplayPosts", posts);
                         }
                     }
                 }
                 //User name and date given 
                 else if (model.NameDisplay != null && model.Name == null && model.DtCreated != null)
                 {

                     var user = db.Users.FirstOrDefault(x => x.NameDisplay == model.NameDisplay);

                     if (user == null)
                     {
                         ViewBag.StatusMessage = "No user found by that name";
                         return View();
                     }

                     else
                     {

                         var posts = user.Blog.Posts.Where(post => post.DtCreated.Date == model.DtCreated.Value.Date);


                         if (posts.Count() == 0)
                         {
                             ViewBag.StatusMessage = "No posts were found that match your criterion";
                             return View();
                         }

                         else
                         {
                             return View("DisplayPosts", posts);
                         }
                     }
                 }



                 //all three given
                 else if (model.NameDisplay != null && model.Name != null && model.DtCreated != null)
                 {
                     var user = db.Users.FirstOrDefault(x => x.NameDisplay == model.NameDisplay);

                     if (user == null)
                     {
                         ViewBag.StatusMessage = "No user found by that name";
                         return View();
                     }

                     else
                     {
                         var tags = db.Tags.Where(tag => tag.Name == model.Name && tag.Post.Blog.User.Id == user.Id).ToList();
                         var posts = tags.Select(tag => tag.Post).Where(post => post.DtCreated.Date == model.DtCreated.Value.Date);



                         if (posts.Count() == 0 || posts == null)
                         {
                             ViewBag.StatusMessage = "No posts were found that match your criterion";
                             return View();
                         }

                         else
                         {
                             return View("DisplayPosts", posts);
                         }
                     }
                 }
                 //Tag and date given
                 else if (model.NameDisplay == null && model.Name != null && model.DtCreated != null)
                 {

                     var tags = db.Tags.Where(tag => tag.Name == model.Name).ToList();
                     var posts = tags.Select(tag => tag.Post).Where(post => post.DtCreated.Date == model.DtCreated.Value.Date);



                     if (posts.Count() == 0 || posts == null)
                     {
                         ViewBag.StatusMessage = "No posts were found that match your criterion";
                         return View();
                     }

                     else
                     {
                         return View("DisplayPosts", posts);
                     }
                 }
                 //Date given
                 else if (model.NameDisplay == null && model.Name == null && model.DtCreated != null)
                 {


                     var posts = db.Posts.ToList().Where(post => post.DtCreated.Date == model.DtCreated.Value.Date);



                     if (posts.Count() == 0 || posts == null)
                     {
                         ViewBag.StatusMessage = "No posts were found that match your criterion";
                         return View();
                     }

                     else
                     {
                         return View("DisplayPosts", posts);
                     }
                 }
                 //Tag given
                 else if (model.NameDisplay == null && model.Name != null && model.DtCreated == null)
                 {

                     var tags = db.Tags.Where(tag => tag.Name == model.Name).ToList();
                     var posts = tags.Select(tag => tag.Post);



                     if (posts.Count() == 0 || posts == null)
                     {
                         ViewBag.StatusMessage = "No posts were found that match your criterion";
                         return View();
                     }

                     else
                     {
                         return View("DisplayPosts", posts);
                     }
                 }



                 else
                 {
                     return View();
                 }
             }
         }

      //  [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DisplayPosts(IEnumerable<Post> posts)
        {
            return View(posts);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DisplayUser(ApplicationUser user) 
        {
            return View(user);
        }
    }
}