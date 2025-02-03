using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuGet.ContentModel;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostID = 1,
                    Title = "I love cat",
                    Body = "Cat is my favorite animal in the world",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Author = "Will",
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
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback
                {
                    FeedBackId = 1,
                    Email = "JohnBrown@abc.com",
                    Comments = "I am loving this",
                    ResponseNeeded = false
                }
             );
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
