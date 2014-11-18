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
    [Authorize]
    public class MakePostsController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;
        public MakePostsController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }
        // GET: MakePosts
        public ActionResult Index()
        {
            return View();
        }

        // GET: MakePosts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Name");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create
            ([Bind(Include = "Title,ContentPost,Published,EnabledComment")] CreatePostModel model)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());
          
            if (ModelState.IsValid)
            {
                
                var post = new Post { DtCreated = DateTime.Now, DtUpdated = DateTime.Now, Blog = currentUser.Blog, BlogId = currentUser.Blog.Id, Title = model.Title, ContentPost = model.ContentPost, Published = model.Published };
               

                db.Posts.Add(post);
      
                db.SaveChanges();
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

      //      ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Name", post.BlogId);
            return View(model);
        }

        // GET: MakePosts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MakePosts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MakePosts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MakePosts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
