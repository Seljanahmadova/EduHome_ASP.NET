﻿// <auto-generated />
using EduHome.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduHome.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200706180522_NameColumnAdded")]
    partial class NameColumnAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EduHome.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assessment")
                        .IsRequired();

                    b.Property<string>("ClassDuration")
                        .IsRequired();

                    b.Property<int>("CourseCategoryId");

                    b.Property<int>("CourseContentId");

                    b.Property<string>("Duration")
                        .IsRequired();

                    b.Property<decimal>("Fee");

                    b.Property<string>("Language")
                        .IsRequired();

                    b.Property<string>("SkillLevel")
                        .IsRequired();

                    b.Property<string>("StartTime")
                        .IsRequired();

                    b.Property<int>("StudentCount");

                    b.HasKey("Id");

                    b.HasIndex("CourseCategoryId");

                    b.HasIndex("CourseContentId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("EduHome.Models.CourseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CourseCategory");
                });

            modelBuilder.Entity("EduHome.Models.CourseContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired();

                    b.Property<string>("Certification")
                        .IsRequired();

                    b.Property<string>("HowToApply")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CourseContent");
                });

            modelBuilder.Entity("EduHome.Models.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Reply");
                });

            modelBuilder.Entity("EduHome.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Communication");

                    b.Property<int>("Design");

                    b.Property<int>("Development");

                    b.Property<int>("Innovation");

                    b.Property<int>("Language");

                    b.Property<int>("TeamLeader");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("EduHome.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Degree")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Experience")
                        .IsRequired();

                    b.Property<string>("Facebook");

                    b.Property<string>("Faculty")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Hobbies")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("Pinterest");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("SkillId");

                    b.Property<string>("Skype");

                    b.Property<string>("Twitter");

                    b.Property<string>("Vimeo");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EduHome.Models.Course", b =>
                {
                    b.HasOne("EduHome.Models.CourseCategory", "CourseCategory")
                        .WithMany()
                        .HasForeignKey("CourseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EduHome.Models.CourseContent", "CourseContent")
                        .WithMany()
                        .HasForeignKey("CourseContentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EduHome.Models.Teacher", b =>
                {
                    b.HasOne("EduHome.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
