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



        public ActionResult SearchUser(SearchUserModel model)
        {
            var user = db.Users.FirstOrDefault(x => x.NameDisplay == model.NameDisplay);
            if (user == null)
            {
                ViewBag.StatusMessage = "No user found by that name";
                return View(model);
            }

            else
            {
                return View();
            }
        }

    }
}