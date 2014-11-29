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
   // [Authorize]
    public class PostsController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;
        public PostsController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }
        // GET: Posts
           [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            var posts = db.Posts.Include(p => p.Blog);
            return View(posts.ToList());
        }

           [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(IEnumerable<Post> posts)
        {
           
            return View(posts.ToList());
        }

        // GET: Posts/Details/5
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(int? id)
        {

             if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

         [AcceptVerbs(HttpVerbs.Post)]
        public async Task<ActionResult> Details(string content, string postid)
        {
            var u = await manager.FindByIdAsync(User.Identity.GetUserId());
            int pid = Convert.ToInt32(postid);
            //var u = db.Users.FirstOrDefault(user => user.Id == userid);
            var p = db.Posts.First(post => post.Id == pid);
            if (u != null)
            {
                
                var comment = new Comment { ApplicationUserId = u.Id, Content = content, DtCreated = DateTime.Now, NameDisplay = u.NameDisplay, Post = p, PostId = p.Id };
                db.Comments.Add(comment);
                await db.SaveChangesAsync();
                return View(p);
            }
            else
            {
               var comment = new Comment { ApplicationUserId = "", Content = content, DtCreated = DateTime.Now, NameDisplay = "Anonymous", Post = p, PostId = p.Id };
                db.Comments.Add(comment);
                await db.SaveChangesAsync();
                return View(p);
            }


        }

       
        // GET: Posts/Create
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
            ([Bind(Include = "Id,Title,ContentPost,Published,EnabledComment")] Post post)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());


            if (ModelState.IsValid)
            {
                
                post.DtCreated = DateTime.Now;
                post.DtUpdated = DateTime.Now;
                
                post.Blog = currentUser.Blog;
                post.BlogId = currentUser.Blog.Id;
                //    currentUser.Blog.Posts.Add(post);
                db.Posts.Add(post);
                //db.Users.
                db.SaveChanges();
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Name", post.BlogId);
            return View(post);
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Name", post.BlogId);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,ContentPost,ExceptPost,Published,DtCreated,DtUpdated,DtAutoPublish,EnabledComment,BlogId,ApplicationUserId")] Post post)
        {
            var blog = db.Blogs.Find(post.BlogId);
            var p = db.Posts.Find(post.Id);
            var tags = p.Tags;
            var comments = p.Comments;

            post.Comments = comments;
            post.Blog = blog;
            post.Tags = tags;
            post.DtUpdated = DateTime.Now;
            if (post.Title != "" && post.ContentPost != "")
            {
                db.Posts.Remove(p);
                db.Posts.Add(post);
                //db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            
            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Name", post.BlogId);
            return View(post);
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
