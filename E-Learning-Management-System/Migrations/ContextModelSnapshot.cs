﻿// <auto-generated />
using System;
using E_Learning_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Learning_Management_System.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseLearner", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("LearnersId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "LearnersId");

                    b.HasIndex("LearnersId");

                    b.ToTable("CourseLearner");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Adminstrator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ContentId");

                    b.ToTable("Adminstrator");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdminstratorId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LearnerId")
                        .HasColumnType("int");

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

                    b.HasIndex("AdminstratorId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("LearnerId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LearnerId")
                        .HasColumnType("int");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LearnerId");

                    b.HasIndex("QuizId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdminstratorId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LearnerId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminstratorId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LearnerId");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LearnerId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("LearnerId");

                    b.HasIndex("QuizId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Learner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ContentId");

                    b.HasIndex("QuizId");

                    b.ToTable("Learner");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CertificateId")
                        .HasColumnType("int");

                    b.Property<int?>("FeedbackId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LearnerId")
                        .HasColumnType("int");

                    b.Property<double>("Mark")
                        .HasColumnType("float");

                    b.Property<int?>("TheQuizzesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.HasIndex("FeedbackId");

                    b.HasIndex("LearnerId");

                    b.HasIndex("TheQuizzesId");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.TheQuizzes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("TheQuizzes");
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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("CourseLearner", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Learning_Management_System.Models.Learner", null)
                        .WithMany()
                        .HasForeignKey("LearnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Adminstrator", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("E_Learning_Management_System.Models.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.Navigation("Account");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.ApplicationUser", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Adminstrator", "Adminstrator")
                        .WithMany()
                        .HasForeignKey("AdminstratorId");

                    b.HasOne("E_Learning_Management_System.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");

                    b.HasOne("E_Learning_Management_System.Models.Learner", "Learner")
                        .WithMany()
                        .HasForeignKey("LearnerId");

                    b.Navigation("Adminstrator");

                    b.Navigation("Instructor");

                    b.Navigation("Learner");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Certificate", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Learner", "Learner")
                        .WithMany("Certificates")
                        .HasForeignKey("LearnerId");

                    b.HasOne("E_Learning_Management_System.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");

                    b.Navigation("Learner");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Content", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Adminstrator", "Adminstrator")
                        .WithMany()
                        .HasForeignKey("AdminstratorId");

                    b.HasOne("E_Learning_Management_System.Models.Course", "Course")
                        .WithMany("Contents")
                        .HasForeignKey("CourseId");

                    b.HasOne("E_Learning_Management_System.Models.Learner", "Learner")
                        .WithMany()
                        .HasForeignKey("LearnerId");

                    b.Navigation("Adminstrator");

                    b.Navigation("Course");

                    b.Navigation("Learner");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Course", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Instructor", "Instructor")
                        .WithMany("Coruses")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Feedback", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Instructor", "Instructor")
                        .WithMany("Feedbacks")
                        .HasForeignKey("InstructorId");

                    b.HasOne("E_Learning_Management_System.Models.Learner", "Learner")
                        .WithMany("Feedbacks")
                        .HasForeignKey("LearnerId");

                    b.HasOne("E_Learning_Management_System.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");

                    b.Navigation("Instructor");

                    b.Navigation("Learner");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Instructor", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Learner", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("E_Learning_Management_System.Models.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.HasOne("E_Learning_Management_System.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");

                    b.Navigation("Account");

                    b.Navigation("Content");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Quiz", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId");

                    b.HasOne("E_Learning_Management_System.Models.Feedback", "Feedback")
                        .WithMany()
                        .HasForeignKey("FeedbackId");

                    b.HasOne("E_Learning_Management_System.Models.Learner", "Learner")
                        .WithMany()
                        .HasForeignKey("LearnerId");

                    b.HasOne("E_Learning_Management_System.Models.TheQuizzes", "TheQuizzes")
                        .WithMany("Quizzes")
                        .HasForeignKey("TheQuizzesId");

                    b.Navigation("Certificate");

                    b.Navigation("Feedback");

                    b.Navigation("Learner");

                    b.Navigation("TheQuizzes");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.TheQuizzes", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.Instructor", "Instructor")
                        .WithMany("TheQuizzes")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Instructor");
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
                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", null)
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

                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("E_Learning_Management_System.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Course", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Instructor", b =>
                {
                    b.Navigation("Coruses");

                    b.Navigation("Feedbacks");

                    b.Navigation("TheQuizzes");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.Learner", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("E_Learning_Management_System.Models.TheQuizzes", b =>
                {
                    b.Navigation("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
