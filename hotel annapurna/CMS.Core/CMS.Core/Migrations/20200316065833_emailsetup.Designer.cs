﻿// <auto-generated />
using System;
using CMS.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMS.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200316065833_emailsetup")]
    partial class emailsetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMS.Core.Entity.Appointment", b =>
                {
                    b.Property<long>("appointment_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("appointment_date");

                    b.Property<string>("contact_no")
                        .HasMaxLength(100);

                    b.Property<string>("country")
                        .IsRequired();

                    b.Property<string>("description")
                        .HasMaxLength(2000);

                    b.Property<string>("email")
                        .HasMaxLength(250);

                    b.Property<DateTime>("entry_date");

                    b.Property<string>("name")
                        .HasMaxLength(2000);

                    b.Property<int>("type");

                    b.HasKey("appointment_id");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("CMS.Core.Entity.Blog", b =>
                {
                    b.Property<long>("blog_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("artical_by")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("description")
                        .HasMaxLength(50000);

                    b.Property<string>("image_name")
                        .HasMaxLength(100);

                    b.Property<bool>("is_enabled");

                    b.Property<DateTime>("posted_on");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("blog_id");

                    b.ToTable("blog");
                });

            modelBuilder.Entity("CMS.Core.Entity.BlogComment", b =>
                {
                    b.Property<long>("blog_comment_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("blogComment");

                    b.Property<long>("blog_id");

                    b.Property<string>("comment_by")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("comment_date");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("blog_comment_id");

                    b.HasIndex("blogComment");

                    b.HasIndex("blog_id");

                    b.ToTable("blog_comment");
                });

            modelBuilder.Entity("CMS.Core.Entity.Career", b =>
                {
                    b.Property<long>("career_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("closing_date");

                    b.Property<string>("description");

                    b.Property<string>("image_name")
                        .HasMaxLength(70);

                    b.Property<bool>("is_closed");

                    b.Property<DateTime>("opening_date");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("career_id");

                    b.ToTable("careers");
                });

            modelBuilder.Entity("CMS.Core.Entity.Classes", b =>
                {
                    b.Property<long>("class_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("is_active");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("class_id");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("CMS.Core.Entity.Courses", b =>
                {
                    b.Property<long>("course_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<long>("faculty_id");

                    b.Property<string>("features");

                    b.Property<string>("file_name")
                        .HasMaxLength(110);

                    b.Property<bool>("is_enabled");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("specification");

                    b.HasKey("course_id");

                    b.HasIndex("faculty_id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("CMS.Core.Entity.Designation", b =>
                {
                    b.Property<long>("Designation_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("position")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Designation_id");

                    b.ToTable("designations");
                });

            modelBuilder.Entity("CMS.Core.Entity.Details", b =>
                {
                    b.Property<long>("details_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("value0");

                    b.Property<long>("value1");

                    b.Property<long>("value2");

                    b.Property<long>("value3");

                    b.Property<long>("value4");

                    b.HasKey("details_id");

                    b.ToTable("details");
                });

            modelBuilder.Entity("CMS.Core.Entity.Doctors", b =>
                {
                    b.Property<long>("doctor_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(1000);

                    b.Property<string>("contact_number")
                        .HasMaxLength(50);

                    b.Property<string>("education")
                        .HasMaxLength(1000);

                    b.Property<string>("email")
                        .HasMaxLength(50);

                    b.Property<string>("experience")
                        .HasMaxLength(200);

                    b.Property<string>("facebook")
                        .HasMaxLength(200);

                    b.Property<string>("image")
                        .HasMaxLength(120);

                    b.Property<bool>("is_active");

                    b.Property<bool>("is_contact_enabled");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("speciality")
                        .HasMaxLength(2000);

                    b.Property<string>("twitter")
                        .HasMaxLength(200);

                    b.Property<string>("website")
                        .HasMaxLength(200);

                    b.HasKey("doctor_id");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("CMS.Core.Entity.Event", b =>
                {
                    b.Property<long>("event_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<DateTime>("event_from_date");

                    b.Property<DateTime>("event_to_date");

                    b.Property<string>("file_name")
                        .HasMaxLength(70);

                    b.Property<string>("image_name")
                        .HasMaxLength(70);

                    b.Property<bool>("is_closed");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("time")
                        .HasMaxLength(200);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("venue")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("event_id");

                    b.ToTable("events");
                });

            modelBuilder.Entity("CMS.Core.Entity.ExamTerm", b =>
                {
                    b.Property<long>("exam_term_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("is_active");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("exam_term_id");

                    b.ToTable("exam_terms");
                });

            modelBuilder.Entity("CMS.Core.Entity.Faculty", b =>
                {
                    b.Property<long>("faculty_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("is_active");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("faculty_id");

                    b.ToTable("faculty");
                });

            modelBuilder.Entity("CMS.Core.Entity.Faq", b =>
                {
                    b.Property<long>("faq_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<bool>("is_active");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("faq_id");

                    b.ToTable("faqs");
                });

            modelBuilder.Entity("CMS.Core.Entity.FileUpload", b =>
                {
                    b.Property<long>("file_upload_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("file_name")
                        .HasMaxLength(70);

                    b.Property<bool>("is_enabled");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("file_upload_id");

                    b.ToTable("file_uploads");
                });

            modelBuilder.Entity("CMS.Core.Entity.FiscalYear", b =>
                {
                    b.Property<long>("fiscal_year_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("is_current");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("fiscal_year_id");

                    b.ToTable("fiscalYears");
                });

            modelBuilder.Entity("CMS.Core.Entity.Gallery", b =>
                {
                    b.Property<long>("gallery_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_description");

                    b.Property<string>("description");

                    b.Property<bool>("is_active");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("gallery_id");

                    b.ToTable("gallery");
                });

            modelBuilder.Entity("CMS.Core.Entity.GalleryImage", b =>
                {
                    b.Property<long>("gallery_image_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<long>("gallery_id");

                    b.Property<string>("image_name")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<bool>("is_default");

                    b.Property<bool>("is_enabled");

                    b.Property<bool>("is_slider_image");

                    b.Property<string>("title")
                        .HasMaxLength(70);

                    b.HasKey("gallery_image_id");

                    b.HasIndex("gallery_id");

                    b.ToTable("GalleryImage");
                });

            modelBuilder.Entity("CMS.Core.Entity.Member", b =>
                {
                    b.Property<long>("member_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Designation_id");

                    b.Property<string>("address")
                        .HasMaxLength(50);

                    b.Property<string>("contact_number")
                        .HasMaxLength(50);

                    b.Property<string>("description");

                    b.Property<long>("fiscal_year_id");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("image_url")
                        .HasMaxLength(120);

                    b.Property<bool>("is_contact_enabled");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("member_id");

                    b.HasIndex("Designation_id");

                    b.HasIndex("fiscal_year_id");

                    b.ToTable("members");
                });

            modelBuilder.Entity("CMS.Core.Entity.News", b =>
                {
                    b.Property<long>("news_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date");

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("image");

                    b.Property<bool>("is_active");

                    b.Property<string>("news_by");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("news_id");

                    b.ToTable("news");
                });

            modelBuilder.Entity("CMS.Core.Entity.Notice", b =>
                {
                    b.Property<long>("notice_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<string>("image_name")
                        .HasMaxLength(70);

                    b.Property<bool>("is_closed");

                    b.Property<DateTime>("notice_date");

                    b.Property<DateTime>("notice_expiry_date");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("notice_id");

                    b.ToTable("notices");
                });

            modelBuilder.Entity("CMS.Core.Entity.Page", b =>
                {
                    b.Property<long>("page_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<string>("image_name")
                        .HasMaxLength(70);

                    b.Property<bool>("is_enabled");

                    b.Property<bool>("is_home_page");

                    b.Property<long>("page_category_id");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("page_id");

                    b.HasIndex("page_category_id");

                    b.ToTable("pages");
                });

            modelBuilder.Entity("CMS.Core.Entity.PageCategory", b =>
                {
                    b.Property<long>("page_category_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("is_enabled");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("page_category_id");

                    b.ToTable("page_categories");
                });

            modelBuilder.Entity("CMS.Core.Entity.ReceivedEmail", b =>
                {
                    b.Property<long>("received_email_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("message")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("sender_email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("received_email_id");

                    b.ToTable("received_emails");
                });

            modelBuilder.Entity("CMS.Core.Entity.Routine", b =>
                {
                    b.Property<long>("routine_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("class_id");

                    b.Property<DateTime>("end_date");

                    b.Property<string>("image")
                        .IsRequired();

                    b.Property<bool>("is_active");

                    b.Property<DateTime>("start_date");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("routine_id");

                    b.HasIndex("class_id");

                    b.ToTable("routine");
                });

            modelBuilder.Entity("CMS.Core.Entity.Services", b =>
                {
                    b.Property<long>("service_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("image");

                    b.Property<bool>("is_active");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("service_id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("CMS.Core.Entity.Setup", b =>
                {
                    b.Property<long>("setup_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("key")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("value")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("setup_id");

                    b.ToTable("setup");
                });

            modelBuilder.Entity("CMS.Core.Entity.Testimonial", b =>
                {
                    b.Property<long>("testimonial_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("associated_company_name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("image_name")
                        .HasMaxLength(100);

                    b.Property<bool>("is_visible");

                    b.Property<string>("person_name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("statement")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("testimonial_id");

                    b.ToTable("testimonials");
                });

            modelBuilder.Entity("CMS.Core.Entity.Video", b =>
                {
                    b.Property<long>("video_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasMaxLength(50000);

                    b.Property<bool>("is_enabled");

                    b.Property<bool>("is_home_video");

                    b.Property<string>("title");

                    b.Property<string>("video_url")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("video_id");

                    b.ToTable("videos");
                });

            modelBuilder.Entity("CMS.Core.Entity.BlogComment", b =>
                {
                    b.HasOne("CMS.Core.Entity.Blog")
                        .WithMany("blogComment")
                        .HasForeignKey("blogComment");

                    b.HasOne("CMS.Core.Entity.Blog", "blog")
                        .WithMany()
                        .HasForeignKey("blog_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS.Core.Entity.Courses", b =>
                {
                    b.HasOne("CMS.Core.Entity.Faculty", "faculty")
                        .WithMany()
                        .HasForeignKey("faculty_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS.Core.Entity.GalleryImage", b =>
                {
                    b.HasOne("CMS.Core.Entity.Gallery", "gallery")
                        .WithMany("gallery_images")
                        .HasForeignKey("gallery_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS.Core.Entity.Member", b =>
                {
                    b.HasOne("CMS.Core.Entity.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("Designation_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CMS.Core.Entity.FiscalYear", "fiscalyear")
                        .WithMany()
                        .HasForeignKey("fiscal_year_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS.Core.Entity.Page", b =>
                {
                    b.HasOne("CMS.Core.Entity.PageCategory", "page_category")
                        .WithMany("pages")
                        .HasForeignKey("page_category_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS.Core.Entity.Routine", b =>
                {
                    b.HasOne("CMS.Core.Entity.Classes", "classes")
                        .WithMany()
                        .HasForeignKey("class_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
