﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoTapeNS;

namespace MoreVideotapesGalore.Migrations
{
    [DbContext(typeof(VideoTapeContext))]
    partial class VideoTapeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity("MoreVideotapesGalore.Models.Entities.Borrow", b =>
                {
                    b.Property<int>("borrowId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("borrow_date");

                    b.Property<bool>("isRented");

                    b.Property<string>("return_date");

                    b.Property<int>("userId");

                    b.Property<int>("videotapeId");

                    b.HasKey("borrowId");

                    b.ToTable("Borrows");
                });

            modelBuilder.Entity("MoreVideotapesGalore.Models.Entities.Review", b =>
                {
                    b.Property<int>("reviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("rating");

                    b.Property<int>("userId");

                    b.Property<int>("videotapeId");

                    b.HasKey("reviewId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MoreVideotapesGalore.Models.Entities.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<string>("email");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.Property<string>("phone_number");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MoreVideotapesGalore.Models.Entities.Videotape", b =>
                {
                    b.Property<int>("videotapeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("director_first_name");

                    b.Property<string>("director_last_name");

                    b.Property<string>("eidr");

                    b.Property<string>("release_date");

                    b.Property<string>("title");

                    b.Property<string>("type");

                    b.HasKey("videotapeId");

                    b.ToTable("Videotapes");
                });
#pragma warning restore 612, 618
        }
    }
}
