using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace View.Models
{
    public class Likes
    {

       
        [ForeignKey("LikedUser")]
        public string UserID { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }

        public virtual User LikedUser { get; set; }
        public virtual Post Post { get; set; }
    }
}
