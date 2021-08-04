using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    [Table("tblPosts")]
    public class Post
    {
        [Key]
        public long Id { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }

        [StringLength(100)]
        public string ShortDescription { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Meta { get; set; }

        [StringLength(50)]
        public string UrlSlug { get; set; }

        [StringLength(50)]
        public string Categ { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<PostTagMap> Connect { get; set; }
    }
}
