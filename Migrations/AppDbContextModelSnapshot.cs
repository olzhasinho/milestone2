﻿// <auto-generated />
using System;
using ArtShop3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtShop3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtShop3.Models.Art", b =>
                {
                    b.Property<int>("ArtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtLike")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsArtOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ArtId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Arts");

                    b.HasData(
                        new
                        {
                            ArtId = 1,
                            ArtLike = 0,
                            CategoryId = 1,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/2.jpg",
                            ImageUrl = "/images/1.jpg",
                            InStock = true,
                            IsArtOfTheWeek = true,
                            IsFavorite = false,
                            Name = "Kaneki Ken",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 2,
                            ArtLike = 0,
                            CategoryId = 1,
                            Description = "Deep inside Photo2",
                            ImageThumbnailUrl = "/images/4.png",
                            ImageUrl = "/images/3.jpg",
                            InStock = true,
                            IsArtOfTheWeek = false,
                            IsFavorite = false,
                            Name = "Kaneki Ken2",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 3,
                            ArtLike = 0,
                            CategoryId = 1,
                            Description = "Deep inside Photo3",
                            ImageThumbnailUrl = "/images/6.jpg",
                            ImageUrl = "/images/5.jpg",
                            InStock = false,
                            IsArtOfTheWeek = true,
                            IsFavorite = false,
                            Name = "Kaneki Ken3",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 4,
                            ArtLike = 0,
                            CategoryId = 1,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/8.jpg",
                            ImageUrl = "/images/7.jpg",
                            InStock = false,
                            IsArtOfTheWeek = false,
                            IsFavorite = false,
                            Name = "Kaneki Ken4",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 5,
                            ArtLike = 0,
                            CategoryId = 2,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/naruto2.jpg",
                            ImageUrl = "/images/naruto1.jpg",
                            InStock = false,
                            IsArtOfTheWeek = true,
                            IsFavorite = true,
                            Name = "Naruto",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 6,
                            ArtLike = 0,
                            CategoryId = 2,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/naruto4.jpg",
                            ImageUrl = "/images/naruto3.jpg",
                            InStock = true,
                            IsArtOfTheWeek = false,
                            IsFavorite = false,
                            Name = "Naruto2",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 7,
                            ArtLike = 0,
                            CategoryId = 3,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/kill2.jpg",
                            ImageUrl = "/images/kill1.png",
                            InStock = true,
                            IsArtOfTheWeek = true,
                            IsFavorite = false,
                            Name = "Killing Stalking",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 8,
                            ArtLike = 0,
                            CategoryId = 3,
                            Description = "Deep inside Photo4",
                            ImageThumbnailUrl = "/images/kill4.jpg",
                            ImageUrl = "/images/kill3.jpg",
                            InStock = false,
                            IsArtOfTheWeek = false,
                            IsFavorite = false,
                            Name = "Killing Stalking2",
                            Price = 2000m
                        });
                });

            modelBuilder.Entity("ArtShop3.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Dead Inside Theme"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Naruto Frames"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Manga Frames"
                        });
                });

            modelBuilder.Entity("ArtShop3.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ArtShop3.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ArtId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("ArtId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ArtShop3.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ArtId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ArtId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ArtShop3.Models.Art", b =>
                {
                    b.HasOne("ArtShop3.Models.Category", "Category")
                        .WithMany("Arts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArtShop3.Models.OrderDetail", b =>
                {
                    b.HasOne("ArtShop3.Models.Art", "Art")
                        .WithMany()
                        .HasForeignKey("ArtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtShop3.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArtShop3.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ArtShop3.Models.Art", "Art")
                        .WithMany()
                        .HasForeignKey("ArtId");
                });
#pragma warning restore 612, 618
        }
    }
}
