﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    [Table("tblTags")]
    public class Tag
    {
        [Key]
        public long Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string UrlSlug { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual ICollection<PostTagMap> Connect { get; set; }
    }
}
