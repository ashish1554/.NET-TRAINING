using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTMS.Migrations
{
    /// <inheritdoc />
    public partial class EnrollDateupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "EmployeeId", "TrainingProgramId" },
                keyValues: new object[] { 2, 2 },
                column: "EnrollDate",
                value: new DateOnly(2026, 2, 10));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "EmployeeId", "TrainingProgramId" },
                keyValues: new object[] { 2, 2 },
                column: "EnrollDate",
                value: new DateOnly(2026, 10, 2));
        }
    }
}
