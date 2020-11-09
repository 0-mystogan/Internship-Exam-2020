﻿// <auto-generated />
using System;
using InternshipExam2020JasirBuric.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternshipExam2020JasirBuric.Dal.Migrations
{
    [DbContext(typeof(InternshipJasirBuricDbContext))]
    [Migration("20201109120739_seedProfile")]
    partial class seedProfile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternshipExam2020JasirBuric.Dal.Domain.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(3500)")
                        .HasMaxLength(3500);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Published")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)")
                        .HasMaxLength(350);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("InternshipExam2020JasirBuric.Dal.Domain.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 990, DateTimeKind.Utc).AddTicks(7711),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("InternshipExam2020JasirBuric.Dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBlogs")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(4408),
                            Email = "gwannop0@hud.gov",
                            Name = "Garvin Wannop",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 24,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(7960),
                            Email = "cvines1@xinhuanet.com",
                            Name = "Cherin Vines",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 26,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8009),
                            Email = "mivashnikov2@wikimedia.org",
                            Name = "Myer Ivashnikov",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 29,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8014),
                            Email = "vmcclure3@usgs.gov",
                            Name = "Vern McClure",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 40,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8016),
                            Email = "sferenczy4@hugedomains.com",
                            Name = "Sheridan Ferenczy",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 36,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8023),
                            Email = "gwannop0@hud.gov",
                            Name = "Garvin Wannop",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 27,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8025),
                            Email = "xdewdeny5@china.com.cn",
                            Name = "Xenos Dewdeny",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 20,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8028),
                            Email = "lbloxsum6@sina.com.cn",
                            Name = "Leela Bloxsum",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 21,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8030),
                            Email = "rnoteyoung7@thetimes.co.uk",
                            Name = "Rocky Noteyoung",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 20,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8034),
                            Email = "gwannop0@hud.gov",
                            Name = "Garvin Wannop",
                            NumberOfBlogs = 0,
                            ProfileId = 0
                        });
                });

            modelBuilder.Entity("InternshipExam2020JasirBuric.Dal.Domain.Blog", b =>
                {
                    b.HasOne("InternshipExam2020JasirBuric.Dal.Domain.Profile", "Profile")
                        .WithMany("Blogs")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternshipExam2020JasirBuric.Dal.Domain.Profile", b =>
                {
                    b.HasOne("InternshipExam2020JasirBuric.Dal.Domain.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("InternshipExam2020JasirBuric.Dal.Domain.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}