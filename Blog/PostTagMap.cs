using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    [Table("tblPostsTagsMaps")]
    public class PostTagMap
    {
        public long PostId { get; set; }
        public virtual Post post { get; set; }
        public long TagId { get; set; }
        public virtual Tag tag { get; set; }
    }
}
