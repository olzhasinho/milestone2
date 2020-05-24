using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser> 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Art> Arts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Dead Inside Theme" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Naruto Frames" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Manga Frames" });
            

            //seed art

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 1,
                Name = "Kaneki Ken",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/1.jpg",
                InStock = true,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/2.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 2,
                Name = "Kaneki Ken2",
                Description = "Deep inside Photo2",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/3.jpg",
                InStock = true,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/4.png",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 3,
                Name = "Kaneki Ken3",
                Description = "Deep inside Photo3",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/5.jpg",
                InStock = false,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/6.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 4,
                Name = "Kaneki Ken4",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/7.jpg",
                InStock = false,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/8.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 5,
                Name = "Naruto",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 2,
                ImageUrl = "/images/naruto1.jpg",
                InStock = false,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/naruto2.jpg",
                ArtLike = 0,
                IsFavorite = true
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 6,
                Name = "Naruto2",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 2,
                ImageUrl = "/images/naruto3.jpg",
                InStock = true,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/naruto4.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 7,
                Name = "Killing Stalking",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 3,
                ImageUrl = "/images/kill1.png",
                InStock = true,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/kill2.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 8,
                Name = "Killing Stalking2",
                Description = "Deep inside Photo4",
                Price = 2000,
                CategoryId = 3,
                ImageUrl = "/images/kill3.jpg",
                InStock = false,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/kill4.jpg",
                ArtLike = 0,
                IsFavorite = false
            });

        }
    }
}
