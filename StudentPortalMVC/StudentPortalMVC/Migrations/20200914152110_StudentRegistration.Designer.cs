﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentPortalMVC.Models;

namespace StudentPortalMVC.Migrations
{
    [DbContext(typeof(StudentPortalDbContext))]
    [Migration("20200914152110_StudentRegistration")]
    partial class StudentRegistration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentPortalMVC.Models.Attendances", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Attendance");

                    b.Property<DateTime>("AttendanceDate");

                    b.Property<int>("CourseId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("SemesterId");

                    b.Property<int>("Status");

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("AttendanceId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Clearence", b =>
                {
                    b.Property<int>("ClearenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ClearenceStatus");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<short>("FeeType");

                    b.Property<int>("Status");

                    b.Property<int>("StudentFeeTransactionId");

                    b.Property<int>("StudentId");

                    b.Property<int>("StudentPaymentId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ClearenceId");

                    b.ToTable("Clearence");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode");

                    b.Property<short>("CourseCredit");

                    b.Property<decimal>("CourseFee");

                    b.Property<string>("CourseName");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.CourseTeacherMapping", b =>
                {
                    b.Property<int>("CourseTeacherMappingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("SectionId");

                    b.Property<int>("SemesterId");

                    b.Property<int>("Status");

                    b.Property<int>("TeacherId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("CourseTeacherMappingId");

                    b.HasIndex("CourseId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("TeacherId");

                    b.ToTable("CourseTeacherMapping");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Marks", b =>
                {
                    b.Property<int>("MarksId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseTeacherMappingId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<decimal>("Mark");

                    b.Property<short>("MarksType")
                        .HasMaxLength(30);

                    b.Property<int>("SemesterId");

                    b.Property<int>("Status");

                    b.Property<int>("StudentId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("MarksId");

                    b.HasIndex("CourseTeacherMappingId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Notice", b =>
                {
                    b.Property<int>("NoticeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Notices");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("NoticeId");

                    b.ToTable("Notice");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Parents", b =>
                {
                    b.Property<int>("ParentsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BloodGroup");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ParentsName");

                    b.Property<int>("Status");

                    b.Property<int>("StudentId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ParentsId");

                    b.HasIndex("StudentId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Routine", b =>
                {
                    b.Property<int>("RoutineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<short>("Day");

                    b.Property<int>("SemesterId");

                    b.Property<short>("Slot");

                    b.Property<int>("Status");

                    b.Property<int>("TeacherId");

                    b.Property<string>("TeacherInitial");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("RoutineId");

                    b.ToTable("Routine");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("SemesterId");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Batch");

                    b.Property<string>("BloodGroup");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FatherName");

                    b.Property<int>("Gender");

                    b.Property<string>("Image");

                    b.Property<string>("MobileNo");

                    b.Property<string>("MotherName");

                    b.Property<string>("Nationality");

                    b.Property<string>("Religion");

                    b.Property<int>("Status");

                    b.Property<string>("StudentName");

                    b.Property<string>("StudentRule");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.StudentFeeTransaction", b =>
                {
                    b.Property<int>("StudentFeeTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<decimal>("CreditAmount");

                    b.Property<decimal>("DebitAmount");

                    b.Property<decimal>("Due");

                    b.Property<int>("Status");

                    b.Property<int>("StudentId");

                    b.Property<int>("StudentRegistrationId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("StudentFeeTransactionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentFeeTransaction");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.StudentPayment", b =>
                {
                    b.Property<int>("StudentPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("SemesterId");

                    b.Property<int>("Status");

                    b.Property<int>("StudentFeeTransactionId");

                    b.Property<int>("StudentId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("StudentPaymentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentPayment");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.StudentRegistration", b =>
                {
                    b.Property<int>("StudentRegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("SemesterId");

                    b.Property<int>("Status");

                    b.Property<int>("StudentId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("StudentRegistrationId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentRegistration");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BloodGroup");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image");

                    b.Property<string>("Mobile");

                    b.Property<int>("Status");

                    b.Property<string>("TeacherCode");

                    b.Property<string>("TeacherInitial");

                    b.Property<string>("TeacherName");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<string>("MobileNo");

                    b.Property<string>("Password");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserName");

                    b.Property<int>("UserTypeId");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.UserMapping", b =>
                {
                    b.Property<int>("UserMappingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdentityId");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.Property<int>("UserTypeId");

                    b.HasKey("UserMappingId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMapping");
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Attendances", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.Course", "Course")
                        .WithMany("Attendances")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentPortalMVC.Models.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentPortalMVC.Models.Teacher", "Teacher")
                        .WithMany("Attendances")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.CourseTeacherMapping", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.Course", "Course")
                        .WithMany("CourseTeacherMapping")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentPortalMVC.Models.Semester", "Semester")
                        .WithMany("CourseTeacherMapping")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentPortalMVC.Models.Teacher", "Teacher")
                        .WithMany("CourseTeacherMapping")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Marks", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.CourseTeacherMapping", "CourseTeacherMapping")
                        .WithMany("Marks")
                        .HasForeignKey("CourseTeacherMappingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentPortalMVC.Models.Semester", "Semester")
                        .WithMany("Marks")
                        .HasForeignKey("SemesterId");

                    b.HasOne("StudentPortalMVC.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.Parents", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.Student", "Student")
                        .WithMany("Parent")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.StudentFeeTransaction", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.Student", "Student")
                        .WithMany("StudentFeeTransaction")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.StudentPayment", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.Student", "Student")
                        .WithMany("StudentPayment")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.StudentRegistration", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.Course", "Course")
                        .WithMany("StudentRegistration")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentPortalMVC.Models.Student", "Student")
                        .WithMany("StudentRegistration")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentPortalMVC.Models.UserMapping", b =>
                {
                    b.HasOne("StudentPortalMVC.Models.User", "User")
                        .WithMany("UserMapping")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
