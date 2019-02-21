using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using View.Models;

namespace View.Data
{
    public class MyContext : IdentityDbContext<User,IdentityRole,string>
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {          
            builder.Entity<Likes>().HasKey(c => new { c.PostID, c.UserID });
            builder.Entity<UserFriends>().HasKey(c => new { c.FriendUserID, c.OwnerUserID });
            //  builder.Entity<ApplicationUser>(e => { e.HasMany(f => f.UserFriends).WithOne(f => f.ApplicationUsers).HasForeignKey(f => f.Id); });

            builder.Entity<UserFriends>().HasOne(o=>o.OwnerUserPage).WithMany(o=>o.UserFriend1).HasForeignKey(o=>o.OwnerUserID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<UserFriends>().HasOne(o => o.UserFriend).WithMany(o => o.UserFriend2)
                .HasForeignKey(o => o.FriendUserID).OnDelete(DeleteBehavior.Restrict);
          
            
            base.OnModelCreating(builder);
        }
        public DbSet<User> ApplicationUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<UserFriends> UserFriends { get; set; }


    }
  
}
