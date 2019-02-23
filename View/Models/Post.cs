using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace View.Models
{
    public class Post
    {
        // NO commet
        public Post()
        {
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Likes>();
        }
        [Key]
        public int PostID { get; set; }
        [Required]
        public string Body { get; set; }
        [ForeignKey("PostedUser")]
        public string UserId { get; set; }
        public DateTime CreationTime { get; set; }

     public virtual ICollection<Comment> Comments { set; get; }
     public virtual ICollection<Likes> Likes { get; set; }
     public virtual User PostedUser { get; set; }
    }
}
