using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UBlogPress.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTimeOffset OffsetTmz { get; set; }

        public Boolean IsPublished { get; set; }

        public int TemplateChoice { get; set; }

        public DateTime DtCreated { get; set; }

        public DateTime DtUpdated { get; set; }

        public string ApplicationUserId { get; set; }
        [Required]
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}