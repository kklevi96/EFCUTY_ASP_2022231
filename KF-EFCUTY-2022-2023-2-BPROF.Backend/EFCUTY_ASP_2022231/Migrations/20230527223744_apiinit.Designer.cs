﻿// <auto-generated />
using System;
using EFCUTY_ASP_2022231.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230527223744_apiinit")]
    partial class apiinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c22192a2-5083-40a1-af8e-fb652a0914bd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "59485fe1-96b5-4239-a673-05c3d8a963f8",
                            EmailConfirmed = false,
                            FirstName = "Béla",
                            LastName = "Kovács",
                            LockoutEnabled = false,
                            NormalizedUserName = "BELA.KOVACS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFO6jAjt/hxwUQxW1q3RpsvTCq27f4x470ikuCg6xdeXxGaIVvoi5D1ECuZmn15U2Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0aace00b-b8d8-4983-9348-286e14dc5d89",
                            TwoFactorEnabled = false,
                            UserName = "bela.kovacs@gmail.com"
                        },
                        new
                        {
                            Id = "f90bda35-d092-4bb8-84cd-a611aeab470a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "21e99639-a160-4065-9adf-4be9630f39b1",
                            EmailConfirmed = false,
                            FirstName = "József",
                            LastName = "Kiss",
                            LockoutEnabled = false,
                            NormalizedUserName = "JOZSEFKISS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPPqcEALuOKPBH0vbsxA9E+BAvzpq6jdUPy93tG5Urfa65vV2hDVmMH8esdG+QAB5A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "98eed380-77a0-4425-871e-ea9f89a9dd07",
                            TwoFactorEnabled = false,
                            UserName = "jozsefkiss@gmail.com"
                        },
                        new
                        {
                            Id = "5aa3e82c-3e7b-4cc4-804e-1ea6f8922f8b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ec5c1f8d-392d-40d4-8663-5695c9ab1b78",
                            EmailConfirmed = false,
                            FirstName = "Ferenc",
                            LastName = "Kovács",
                            LockoutEnabled = false,
                            NormalizedUserName = "ISTVANTAKACS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH09JHyfWPLnG7KHq3vX8oB2VlG+pZdfbFJJXtjY96RyDSwswPG3GcEAJcrurkH5WQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c8696ec3-ca52-4627-b5db-ad2073dc6e99",
                            TwoFactorEnabled = false,
                            UserName = "istvantakacs@gmail.com"
                        },
                        new
                        {
                            Id = "6656bbe9-66c7-4069-be44-a1e368d4669d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ab013e34-6d08-42e3-ae60-322b5a31f6a1",
                            EmailConfirmed = false,
                            FirstName = "Mariann",
                            LastName = "Kiss",
                            LockoutEnabled = false,
                            NormalizedUserName = "MARIANNKISS@UNI-OBUDA.HU",
                            PasswordHash = "AQAAAAEAACcQAAAAEGluqJqm59iQwRkrH+pfQBvsmPbQhpjLnyDtdIdCKUpYq7ztNacc7MHvoApXOkjZjg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "77895e66-afeb-4c3a-aa01-d4973e14f93a",
                            TwoFactorEnabled = false,
                            UserName = "mariannkiss@uni-obuda.hu"
                        },
                        new
                        {
                            Id = "921df54a-d1ba-47fc-af44-8ac65b786883",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "997b8879-1b87-434c-99b9-9d04272e578c",
                            EmailConfirmed = false,
                            FirstName = "Júlia",
                            LastName = "Horváth",
                            LockoutEnabled = false,
                            NormalizedUserName = "JULIAHORVATH@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEELg7hzSs98j7cxzdr+3FtIbZKBwD+j7/gfagqz3yHOzwFpUQDc9TvR4EfEkArLT4A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd37a41d-0f5e-40a4-b701-efa54340188d",
                            TwoFactorEnabled = false,
                            UserName = "juliahorvath@yahoo.com"
                        });
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SiteUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("SiteUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("SiteUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SiteUserId");

                    b.HasIndex("SubjectCode");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Subject", b =>
                {
                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CreditValue")
                        .HasColumnType("int");

                    b.Property<bool>("ExamSubject")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.HasKey("SubjectCode");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectCode = "NIXMN1HBNE",
                            CreditValue = 7,
                            ExamSubject = true,
                            Name = "Analízis 1",
                            Semester = 1
                        },
                        new
                        {
                            SubjectCode = "NIXSF1HBNE",
                            CreditValue = 7,
                            ExamSubject = true,
                            Name = "Szoftvertervezés és -fejlesztés 1.",
                            Semester = 1
                        },
                        new
                        {
                            SubjectCode = "NIXSF2HBNE",
                            CreditValue = 7,
                            ExamSubject = true,
                            Name = "Szoftvertervezés és -fejlesztés 2.",
                            Semester = 2
                        },
                        new
                        {
                            SubjectCode = "NIXBE1PBNE",
                            CreditValue = 3,
                            ExamSubject = true,
                            Name = "Beágyazott és érzékelőalapú rendszerek",
                            Semester = 2
                        },
                        new
                        {
                            SubjectCode = "KGK666BUKO",
                            CreditValue = 15,
                            ExamSubject = false,
                            Name = "Mikro- és makroökonómia",
                            Semester = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Comment", b =>
                {
                    b.HasOne("EFCUTY_ASP_2022231.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCUTY_ASP_2022231.Models.ApiUser", "Author")
                        .WithMany()
                        .HasForeignKey("SiteUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Post", b =>
                {
                    b.HasOne("EFCUTY_ASP_2022231.Models.ApiUser", "Author")
                        .WithMany()
                        .HasForeignKey("SiteUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EFCUTY_ASP_2022231.Models.Subject", "Subject")
                        .WithMany("Posts")
                        .HasForeignKey("SubjectCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EFCUTY_ASP_2022231.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EFCUTY_ASP_2022231.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCUTY_ASP_2022231.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EFCUTY_ASP_2022231.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("EFCUTY_ASP_2022231.Models.Subject", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}