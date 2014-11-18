using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DtCreated { get; set; }
        public string NameDisplay { get; set; }
        public int ApplicationUserId { get; set; } 
        public int PostId { get; set; }
        public int ParentId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Post ParentComment { get; set; }

        [Required]
        public virtual Post Post { get; set; }

    }
}