using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class SecondaryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shelfs",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -1, "Item1" },
                    { -2, "Item2" },
                    { -3, "Item3" },
                    { -4, "Item4" },
                    { -5, "Item5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelfs",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "shelfs",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "shelfs",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "shelfs",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "shelfs",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
