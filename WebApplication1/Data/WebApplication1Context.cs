using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.ContentModel;
using WebApplication1.Areas.Identity.Data;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : IdentityDbContext<PostUser>
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add seed data

            // Add User Data

            // String for user account ID
            string userID = "d68d3885-4dbb-4ba5-861b-0409a5c2d95a";

            // variable for user

            var user = new PostUser
            {
                Id = userID,
                Email = "meow@meow.com",
                NormalizedEmail = "MEOW@MEOW.COM",
                EmailConfirmed = true,
                UserName = "meow@meow.com",
                NormalizedUserName = "MEOW@MEOW.COM"
            };

            // set password
            PasswordHasher<PostUser> ph = new PasswordHasher<PostUser>();
            user.PasswordHash = ph.HashPassword(user, "Me0wme@w");

            // seed users
            modelBuilder.Entity<PostUser>().HasData(user);

            // Add Category Data
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Cat"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Food"
                }
            );

            // Add Post Data
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostID = 1,
                    Title = "I love cat",
                    Body = "Cat is my favorite animal in the world",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Author = userID,
                    Visibitity = VisibilityStatus.Visible,
                    CategoryId = 1
                },
                new Post
                {
                    PostID = 2,
                    Title = "I love Nacho",
                    Body = "Nacho is delicious",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Author = "Will",
                    Visibitity = VisibilityStatus.Visible,
                    CategoryId = 2
                }
            );

            // Add Feedback data
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback
                {
                    FeedBackId = 1,
                    Name = "",
                    Email = "JohnBrown@abc.com",
                    Comments = "I am loving this",
                    ResponseNeeded = false
                }
             );

            // Add Contact Data
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Email = "AliceGreen@example.com",
                    PhoneNumber = 1112223333,
                    Address = "",
                    SocialMediaLinks = ""
                }
             );
        }

        public DbSet<WebApplication1.Models.Post> Post { get; set; } = default!;
        public DbSet<WebApplication1.Models.Category> Category { get; set; } = default!;
        public DbSet<WebApplication1.Models.Feedback> Feedback { get; set; } = default!;
        public DbSet<WebApplication1.Models.Contact> Contact { get; set; } = default!;
    }
}
