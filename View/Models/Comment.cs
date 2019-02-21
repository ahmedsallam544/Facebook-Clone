using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace View.Models
{
    public class Comment
    {
         
        [Key]
        public int CommentID { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentBody { get; set; }
        [ForeignKey("CommentedUser")]
        public string UserID { get; set; }
        [ForeignKey("Post")]
        public int PostID { set; get; }



        public virtual  User CommentedUser { get; set; }
        public virtual Post Post { get; set; }
    }
}
