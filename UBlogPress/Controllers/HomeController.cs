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
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public HomeController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

         [AcceptVerbs(HttpVerbs.Get)]
        public async Task<ActionResult> Index()
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());
            if (currentUser == null)
            {
                return View();
            }
            else
            {
                return View(currentUser);
            }
        }

         [AcceptVerbs(HttpVerbs.Post)]
        public async Task<ActionResult> Index(string name,string postid)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());
            if (currentUser == null)
            {
                return View();
            }
            else if (name == null || name.Trim() == "" || name == "")
            {
                return View(currentUser);
            }
            else
            {
                var post = db.Posts.Find(Convert.ToInt32(postid));
                var tag = new Tag {Post=post,PostId=post.Id,Name=name};
                db.Tags.Add(tag);
                db.SaveChanges();
                await db.SaveChangesAsync();
                return View(currentUser);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}