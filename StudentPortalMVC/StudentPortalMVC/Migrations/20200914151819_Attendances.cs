using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortalMVC.Migrations
{
    public partial class Attendances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clearence",
                columns: table => new
                {
                    ClearenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentPaymentId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    FeeType = table.Column<short>(nullable: false),
                    ClearenceStatus = table.Column<bool>(nullable: false),
                    StudentFeeTransactionId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clearence", x => x.ClearenceId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseCode = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    CourseCredit = table.Column<short>(nullable: false),
                    CourseFee = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    NoticeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Notices = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.NoticeId);
                });

            migrationBuilder.CreateTable(
                name: "Routine",
                columns: table => new
                {
                    RoutineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseCode = table.Column<string>(nullable: true),
                    SemesterId = table.Column<int>(nullable: false),
                    Day = table.Column<short>(nullable: false),
                    Slot = table.Column<short>(nullable: false),
                    TeacherInitial = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routine", x => x.RoutineId);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SemesterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SemesterName = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SemesterId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentRule = table.Column<string>(nullable: true),
                    StudentName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Religion = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    BloodGroup = table.Column<string>(nullable: true),
                    Batch = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherName = table.Column<string>(nullable: true),
                    TeacherCode = table.Column<string>(nullable: true),
                    TeacherInitial = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    BloodGroup = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserTypeId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    ParentsName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 20, nullable: false),
                    BloodGroup = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentsId);
                    table.ForeignKey(
                        name: "FK_Parents_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentFeeTransaction",
                columns: table => new
                {
                    StudentFeeTransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    StudentRegistrationId = table.Column<int>(nullable: false),
                    DebitAmount = table.Column<decimal>(nullable: false),
                    CreditAmount = table.Column<decimal>(nullable: false),
                    Due = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentFeeTransaction", x => x.StudentFeeTransactionId);
                    table.ForeignKey(
                        name: "FK_StudentFeeTransaction_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentPayment",
                columns: table => new
                {
                    StudentPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    StudentFeeTransactionId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPayment", x => x.StudentPaymentId);
                    table.ForeignKey(
                        name: "FK_StudentPayment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentRegistration",
                columns: table => new
                {
                    StudentRegistrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegistration", x => x.StudentRegistrationId);
                    table.ForeignKey(
                        name: "FK_StudentRegistration_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentRegistration_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Attendance = table.Column<bool>(nullable: false),
                    AttendanceDate = table.Column<DateTime>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTeacherMapping",
                columns: table => new
                {
                    CourseTeacherMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTeacherMapping", x => x.CourseTeacherMappingId);
                    table.ForeignKey(
                        name: "FK_CourseTeacherMapping_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTeacherMapping_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTeacherMapping_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMapping",
                columns: table => new
                {
                    UserMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    UserTypeId = table.Column<int>(nullable: false),
                    IdentityId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMapping", x => x.UserMappingId);
                    table.ForeignKey(
                        name: "FK_UserMapping_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    MarksId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mark = table.Column<decimal>(nullable: false),
                    CourseTeacherMappingId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    MarksType = table.Column<short>(maxLength: 30, nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.MarksId);
                    table.ForeignKey(
                        name: "FK_Marks_CourseTeacherMapping_CourseTeacherMappingId",
                        column: x => x.CourseTeacherMappingId,
                        principalTable: "CourseTeacherMapping",
                        principalColumn: "CourseTeacherMappingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marks_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marks_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_CourseId",
                table: "Attendances",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_TeacherId",
                table: "Attendances",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacherMapping_CourseId",
                table: "CourseTeacherMapping",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacherMapping_SemesterId",
                table: "CourseTeacherMapping",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacherMapping_TeacherId",
                table: "CourseTeacherMapping",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_CourseTeacherMappingId",
                table: "Marks",
                column: "CourseTeacherMappingId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_SemesterId",
                table: "Marks",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_StudentId",
                table: "Marks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_StudentId",
                table: "Parents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentFeeTransaction_StudentId",
                table: "StudentFeeTransaction",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayment_StudentId",
                table: "StudentPayment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_CourseId",
                table: "StudentRegistration",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_StudentId",
                table: "StudentRegistration",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMapping_UserId",
                table: "UserMapping",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Clearence");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Routine");

            migrationBuilder.DropTable(
                name: "StudentFeeTransaction");

            migrationBuilder.DropTable(
                name: "StudentPayment");

            migrationBuilder.DropTable(
                name: "StudentRegistration");

            migrationBuilder.DropTable(
                name: "UserMapping");

            migrationBuilder.DropTable(
                name: "CourseTeacherMapping");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
