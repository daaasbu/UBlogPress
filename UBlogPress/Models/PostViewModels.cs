using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;

namespace UBlogPress.Models
{

    public class CreatePostModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Content")]
        public string ContentPost { get; set; }
        [Required]
        [Display(Name = "Display Post to Others")]
        public Boolean Published { get; set; }
        [Required]
        [Display(Name = "Enable User Comments")]
        public Boolean EnabledComment { get; set; }
    }

    public class EditPostModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Content")]
        public string ContentPost { get; set; }
        [Required]
        [Display(Name = "Display Post to Others")]
        public Boolean Published { get; set; }
        [Required]
        [Display(Name = "Enable User Comments")]
        public Boolean EnabledComment { get; set; }
    }

  
}