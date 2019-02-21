using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace View.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            Posts = new HashSet<Post>();
            Comments = new HashSet<Comment>();
          
        }

        public int first_name { get; set; }
        public int lastname { get; set; }
        public string email { set; get; }
        public int Birthday { get; set; }
        public string Image { get; set; }
        public string About { set; get; }
        public bool Active { get; set; } = true;
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public int password { get; set; }
        public string religion { set; get; }



        //public virtual ICollection<Request> RequestTo { set; get; }
        //public virtual ICollection<Request> RequestFrom { set; get; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


        public virtual ICollection<UserFriends> UserFriend1 { get; set; }
        public virtual ICollection<UserFriends> UserFriend2 { get; set; }


    }
}
