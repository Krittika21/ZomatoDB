﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZomatoAPI.Models;

namespace ZomatoAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZomatoAPI.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.HasKey("ID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Dishes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DishesName");

                    b.Property<int?>("RestaurantsID");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantsID");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("ZomatoAPI.Models.DishesOrdered", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DishesID");

                    b.Property<int>("ItemsCount");

                    b.Property<int?>("OrderID");

                    b.HasKey("ID");

                    b.HasIndex("DishesID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderedDishes");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Likes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ReviewsID");

                    b.Property<int?>("UsersID");

                    b.HasKey("ID");

                    b.HasIndex("ReviewsID");

                    b.HasIndex("UsersID");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityID");

                    b.Property<int?>("CountryID");

                    b.Property<string>("Locality");

                    b.Property<int?>("RestaurantsID");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("RestaurantsID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ZomatoAPI.Models.OrderDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int?>("RestaurantID");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Rating", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageRating");

                    b.Property<int?>("RestaurantID");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Restaurants", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RestaurantName");

                    b.HasKey("ID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Reviews", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LikesCount");

                    b.Property<int?>("RestaurantID");

                    b.Property<string>("ReviewTexts");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ZomatoAPI.Models.UserFollow", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FolloweeID");

                    b.Property<int?>("FollowerID");

                    b.HasKey("ID");

                    b.HasIndex("FolloweeID");

                    b.HasIndex("FollowerID");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Dishes", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Restaurants")
                        .WithMany("Dishes")
                        .HasForeignKey("RestaurantsID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.DishesOrdered", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Dishes", "Dishes")
                        .WithMany()
                        .HasForeignKey("DishesID");

                    b.HasOne("ZomatoAPI.Models.OrderDetails", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Likes", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Reviews", "Reviews")
                        .WithMany()
                        .HasForeignKey("ReviewsID");

                    b.HasOne("ZomatoAPI.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Location", b =>
                {
                    b.HasOne("ZomatoAPI.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("ZomatoAPI.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");

                    b.HasOne("ZomatoAPI.Models.Restaurants")
                        .WithMany("Location")
                        .HasForeignKey("RestaurantsID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.OrderDetails", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Restaurants", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ZomatoAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Rating", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Restaurants", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ZomatoAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.Reviews", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Restaurants", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ZomatoAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ZomatoAPI.Models.UserFollow", b =>
                {
                    b.HasOne("ZomatoAPI.Models.Users", "Followee")
                        .WithMany()
                        .HasForeignKey("FolloweeID");

                    b.HasOne("ZomatoAPI.Models.Users", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerID");
                });
#pragma warning restore 612, 618
        }
    }
}
