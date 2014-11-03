using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentPost { get; set; }
        public string ExceptPost { get; set; }
        public Boolean Published { get; set; }
  
        public DateTime DtCreated { get; set; }
        public DateTime DtUpdated { get; set; }
        public DateTime DtAutoPublish { get; set; }
        public Boolean EnabledComment { get; set; }
        public int BlogId { get; set; }
        public int UserId { get; set; }
        [Required]
        public virtual Blog Blog { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}