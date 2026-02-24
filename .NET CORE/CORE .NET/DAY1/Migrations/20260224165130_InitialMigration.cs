using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAY1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics", "Mobile" },
                    { 2, "Electronics", "WashingMachine" },
                    { 3, "Electronics", "TV" },
                    { 4, "Clothing", "Tshirt" },
                    { 5, "Clothing", "Jeans" },
                    { 6, "Clothing", "Jacket" },
                    { 7, "Food", "Pizza" },
                    { 8, "Food", "Burger" },
                    { 9, "Food", "Sandwich" },
                    { 10, "Sports", "Bat" },
                    { 11, "Sports", "Ball" },
                    { 12, "Sports", "Racket" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
