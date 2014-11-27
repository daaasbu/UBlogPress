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
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string NameDisplay {get; set;}

        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [Display(Name = "Tag")]
        public string Name { get; set; }

         [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime? DtCreated { get; set; }
     
     
    }

}