using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        [Required]
        public virtual Post Post { get; set; }
    }
}