using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UBlogPress.Models;
namespace UBlogPress.DAL
{
    public class initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
           
        }
    }
}