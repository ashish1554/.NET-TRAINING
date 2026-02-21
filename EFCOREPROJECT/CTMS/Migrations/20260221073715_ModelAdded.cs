using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTMS.Migrations
{
    /// <inheritdoc />
    public partial class ModelAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTrainers",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ExpertiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTrainers", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_EmployeeTrainers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    TrainingProgramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.TrainingProgramId);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_EmployeeTrainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "EmployeeTrainers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "int", nullable: false),
                    EnrollDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PerformanceScore = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => new { x.EmployeeId, x.TrainingProgramId });
                    table.CheckConstraint("CK_Enrollment_PerformanceScore", "PerformanceScore >= 0 AND PerformanceScore <= 100");
                    table.ForeignKey(
                        name: "FK_Enrollments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "TrainingProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepName", "Location" },
                values: new object[,]
                {
                    { 1, "IT", "Ahmedabad" },
                    { 2, "HR", "Gandhinagar" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentId", "Email", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "ashish123@gmail.com", "Ashish Pateliya", 120000.0 },
                    { 2, 2, "raju123@gmail.com", "Raj Rana", 50000.0 },
                    { 3, 2, "nitya123@gmail.com", "Nitya Shah", 40000.0 },
                    { 4, 1, "mihir123@gmail.com", "Mihir Prajapati", 30000.0 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTrainers",
                columns: new[] { "EmployeeId", "ExpertiseLevel" },
                values: new object[,]
                {
                    { 1, "Expert" },
                    { 4, "Beginner" }
                });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "TrainingProgramId", "Duration", "StartDate", "Title", "TrainerId" },
                values: new object[,]
                {
                    { 1, 50, new DateOnly(2026, 1, 5), "Data Science", 4 },
                    { 2, 30, new DateOnly(2026, 2, 5), "C#", 1 }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EmployeeId", "TrainingProgramId", "EnrollDate" },
                values: new object[] { 2, 2, new DateOnly(2026, 10, 2) });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_TrainingProgramId",
                table: "Enrollments",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_Title",
                table: "TrainingPrograms",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_TrainerId",
                table: "TrainingPrograms",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "EmployeeTrainers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
