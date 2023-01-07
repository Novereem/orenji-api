using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Price", "Type" },
                values: new object[] { new Guid("9e61ddf1-6a80-464f-9dcb-f4cd56003139"), "Company name", "Pants name", "5 dollar", "Pants" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Price", "Type" },
                values: new object[] { new Guid("ccec4c11-5604-4b33-bbb6-50d3ddb0ab4f"), "Company name", "Pants name", "10 dollar", "Pants" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
