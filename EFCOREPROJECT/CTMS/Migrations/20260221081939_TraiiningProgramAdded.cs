using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTMS.Migrations
{
    /// <inheritdoc />
    public partial class TraiiningProgramAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingPrograms",
                keyColumn: "TrainingProgramId",
                keyValue: 2,
                column: "Title",
                value: "Java");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingPrograms",
                keyColumn: "TrainingProgramId",
                keyValue: 2,
                column: "Title",
                value: "C#");
        }
    }
}
