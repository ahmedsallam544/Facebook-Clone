using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace View.Models
{
    public class UserFriends
    {

        [ForeignKey("OwnerUserPage")]
        public string OwnerUserID { get; set; }
        [ForeignKey("UserFriend")]
        public string FriendUserID { get; set; }



        public virtual User OwnerUserPage { get; set; }
        public virtual User UserFriend { get; set; }
    }
}
