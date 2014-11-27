using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using UBlogPress.Models;
using System.ComponentModel.DataAnnotations;


namespace UBlogPress.Models
{
    public class SearchUserModel
    {
        [Display(Name="User Name")]
        public string NameDisplay {get; set;}
        [Display(Name = "Tag")]
        public string Name { get; set; }
        [Display(Name = "Date")]
        public DateTime? DtCreated { get; set; }
     
     
    }

}