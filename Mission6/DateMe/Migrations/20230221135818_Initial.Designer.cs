// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    [Migration("20230221135818_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CreeperStalker")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("MajorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationID");

                    b.HasIndex("MajorId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            Age = (byte)45,
                            CreeperStalker = false,
                            FirstName = "Michael",
                            LastName = "Scott",
                            MajorId = 4,
                            Phone = "555-555-1234"
                        },
                        new
                        {
                            ApplicationID = 2,
                            Age = (byte)90,
                            CreeperStalker = true,
                            FirstName = "Creed",
                            LastName = "Bratton",
                            MajorId = 5,
                            Phone = "555-123-555"
                        });
                });

            modelBuilder.Entity("DateMe.Models.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MajorName")
                        .HasColumnType("TEXT");

                    b.HasKey("MajorId");

                    b.ToTable("Majors");

                    b.HasData(
                        new
                        {
                            MajorId = 1,
                            MajorName = "Information Systems"
                        },
                        new
                        {
                            MajorId = 2,
                            MajorName = "Ancient Near Eastern Studies: Greek New Testament"
                        },
                        new
                        {
                            MajorId = 3,
                            MajorName = "Accounting"
                        },
                        new
                        {
                            MajorId = 4,
                            MajorName = "Actuarial Science"
                        },
                        new
                        {
                            MajorId = 5,
                            MajorName = "Undeclared"
                        });
                });

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.HasOne("DateMe.Models.Major", "Major")
                        .WithMany()
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
