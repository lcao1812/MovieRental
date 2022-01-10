﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRentalCRUD.Data;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    [DbContext(typeof(MovieRentalDBContext))]
    [Migration("20220108220554_AddedMovieStock_&&_AddedUserRenting")]
    partial class AddedMovieStock__AddedUserRenting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("MovieRentalCRUD.Data.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieStock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieSummary")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            MovieName = "Example Movie 0 Title",
                            MovieStock = 3,
                            MovieSummary = "Example Movie 0 Content"
                        },
                        new
                        {
                            MovieId = 2,
                            MovieName = "Example Movie 1 Title",
                            MovieStock = 3,
                            MovieSummary = "Example Movie 1 Content"
                        },
                        new
                        {
                            MovieId = 3,
                            MovieName = "Example Movie 2 Title",
                            MovieStock = 3,
                            MovieSummary = "Example Movie 2 Content"
                        },
                        new
                        {
                            MovieId = 4,
                            MovieName = "Example Movie 3 Title",
                            MovieStock = 3,
                            MovieSummary = "Example Movie 3 Content"
                        },
                        new
                        {
                            MovieId = 5,
                            MovieName = "Example Movie 4 Title",
                            MovieStock = 3,
                            MovieSummary = "Example Movie 4 Content"
                        },
                        new
                        {
                            MovieId = 6,
                            MovieName = "Example Movie 5 Title",
                            MovieStock = 3,
                            MovieSummary = "Example Movie 5 Content"
                        });
                });

            modelBuilder.Entity("MovieRentalCRUD.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            UserName = "User 0 Name"
                        },
                        new
                        {
                            UserId = 2,
                            UserName = "User 1 Name"
                        },
                        new
                        {
                            UserId = 3,
                            UserName = "User 2 Name"
                        },
                        new
                        {
                            UserId = 4,
                            UserName = "User 3 Name"
                        },
                        new
                        {
                            UserId = 5,
                            UserName = "User 4 Name"
                        },
                        new
                        {
                            UserId = 6,
                            UserName = "User 5 Name"
                        },
                        new
                        {
                            UserId = 7,
                            UserName = "User 6 Name"
                        },
                        new
                        {
                            UserId = 8,
                            UserName = "User 7 Name"
                        },
                        new
                        {
                            UserId = 9,
                            UserName = "User 8 Name"
                        },
                        new
                        {
                            UserId = 10,
                            UserName = "User 9 Name"
                        });
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.Property<int>("UserRentalsMovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsersRentingUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserRentalsMovieId", "UsersRentingUserId");

                    b.HasIndex("UsersRentingUserId");

                    b.ToTable("MovieUser");
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.HasOne("MovieRentalCRUD.Data.Movie", null)
                        .WithMany()
                        .HasForeignKey("UserRentalsMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalCRUD.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UsersRentingUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}