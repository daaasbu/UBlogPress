using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UBlogPress.Models
{

    public class PostViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Content")]
        [UIHint("tinymce_jquery_full"), AllowHtml]

        public string ContentPost { get; set; }
        [Required]
        [Display(Name = "Display Post to Others")]

        public Boolean Published { get; set; }
        [Required]
        [Display(Name = "Enable User Comments")]
        public Boolean EnabledComment { get; set; }
    }


  
}