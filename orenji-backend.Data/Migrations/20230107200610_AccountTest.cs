using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9e61ddf1-6a80-464f-9dcb-f4cd56003139"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ccec4c11-5604-4b33-bbb6-50d3ddb0ab4f"));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Product",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Product",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId1",
                table: "Product",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[] { new Guid("767970bf-b2e4-400d-bcf7-e3a684ed3bb8"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("33945978-4409-4ff1-af99-3903400ac38c"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("92ece56e-2e7f-45f3-8fe4-c12c9d52843d"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("c086e725-77bd-436b-990d-9288bbdb43b2"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("b777e133-b9b0-414b-8ce5-c9ef1dd3fd9e"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("d7c46cfa-ad9b-44b8-bc97-44812e1cadc3"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("facc80fc-34fc-4a99-8963-d23d956e0897"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("18803175-e3c8-455e-9c7a-0c36ca41dac1"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("dfd92be8-a94a-411d-b086-404f93167662"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("00e60eb0-ec59-4564-b647-613e3438ab2d"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("dcb0d6dc-952c-4bf7-94f5-1d3b355ea0e7"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("7552d24c-23ef-4a47-a06d-092529784a23"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("d0ccfe7e-17ea-40aa-b8e2-dad7c8affc09"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("9d50ddd0-d7a2-46d4-b346-6e0b1adfa385"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("38d5c3a5-2116-488f-8dfb-5bb5e85a31fa"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("e660ef8e-4012-4b09-ab63-57697ee019bb"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_AccountId",
                table: "Product",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_AccountId1",
                table: "Product",
                column: "AccountId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Account_AccountId",
                table: "Product",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Account_AccountId1",
                table: "Product",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Account_AccountId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Account_AccountId1",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Product_AccountId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_AccountId1",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("00e60eb0-ec59-4564-b647-613e3438ab2d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("18803175-e3c8-455e-9c7a-0c36ca41dac1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33945978-4409-4ff1-af99-3903400ac38c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("38d5c3a5-2116-488f-8dfb-5bb5e85a31fa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7552d24c-23ef-4a47-a06d-092529784a23"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92ece56e-2e7f-45f3-8fe4-c12c9d52843d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9d50ddd0-d7a2-46d4-b346-6e0b1adfa385"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b777e133-b9b0-414b-8ce5-c9ef1dd3fd9e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c086e725-77bd-436b-990d-9288bbdb43b2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0ccfe7e-17ea-40aa-b8e2-dad7c8affc09"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7c46cfa-ad9b-44b8-bc97-44812e1cadc3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dcb0d6dc-952c-4bf7-94f5-1d3b355ea0e7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dfd92be8-a94a-411d-b086-404f93167662"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e660ef8e-4012-4b09-ab63-57697ee019bb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("facc80fc-34fc-4a99-8963-d23d956e0897"));

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AccountId1",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Product",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double")
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
    }
}
