using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE.Migrations
{
    /// <inheritdoc />
    public partial class Fkremoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches");

            migrationBuilder.DropIndex(
                name: "IX_Batches_TrainerId",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Batches");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Batches_TrainerId",
                table: "Batches",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
