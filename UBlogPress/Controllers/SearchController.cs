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
        public ActionResult SearchUser(string NameDisplay)
        {

            var user = db.Users.FirstOrDefault(x => x.NameDisplay == NameDisplay);
          
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


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DisplayUser(ApplicationUser user) 
        {
            return View(user);
        }
    }
}