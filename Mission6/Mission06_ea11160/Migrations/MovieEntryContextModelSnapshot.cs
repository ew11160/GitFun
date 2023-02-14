﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_ea11160.Models;

namespace Mission06_ea11160.Migrations
{
    [DbContext(typeof(MovieEntryContext))]
    partial class MovieEntryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_ea11160.Models.MovieEntryModel", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("MovieEntries");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Rom-Com",
                            Director = "Netflix",
                            Edited = false,
                            LentTo = "",
                            Notes = "Cute, but why can't Ryan Reynolds be in every movie?",
                            Rating = "PG-13",
                            Title = "Your Place Or Mine",
                            Year = 2023
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Action",
                            Director = "John McTiernan",
                            Edited = false,
                            LentTo = "",
                            Notes = "Awesome Movie!",
                            Rating = "PG",
                            Title = "The Hunt for Red October",
                            Year = 1990
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Animated",
                            Director = "Disney",
                            Edited = true,
                            LentTo = "Rosey",
                            Notes = "Jake's pre-church movie this week.",
                            Rating = "G",
                            Title = "Pocahontas",
                            Year = 1995
                        });
                });
#pragma warning restore 612, 618
        }
    }
}