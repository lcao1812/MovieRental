// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRentalCRUD.Data;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    [DbContext(typeof(MovieRentalDBContext))]
    [Migration("20220111162459_AddedDateRent")]
    partial class AddedDateRent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("MovieRentalCRUD.Data.Movie", b =>
                {
                    b.Property<Guid>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieSummary")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieRentalCRUD.Data.MovieCopy", b =>
                {
                    b.Property<Guid>("CopyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRent")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("CopyId");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MoviesCopy");
                });

            modelBuilder.Entity("MovieRentalCRUD.Data.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MovieRentalCRUD.Data.MovieCopy", b =>
                {
                    b.HasOne("MovieRentalCRUD.Data.Movie", "Movie")
                        .WithMany("MovieCopies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalCRUD.Data.User", "User")
                        .WithMany("MovieCopies")
                        .HasForeignKey("UserId");

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieRentalCRUD.Data.Movie", b =>
                {
                    b.Navigation("MovieCopies");
                });

            modelBuilder.Entity("MovieRentalCRUD.Data.User", b =>
                {
                    b.Navigation("MovieCopies");
                });
#pragma warning restore 612, 618
        }
    }
}
