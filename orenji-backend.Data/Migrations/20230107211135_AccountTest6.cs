using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2825e7df-e568-41c8-8468-eede01fc9855"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1d30e6ee-f798-4ee9-ada8-a109aad27523"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2b456141-d06e-43cf-aa4a-d03b957465d5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2f4b45d9-7634-4722-90e0-582dff5d60c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6a9f92e7-f174-4e41-9d65-ded8f6942775"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6fb216d1-bdb0-4ee1-8f36-c605857243f9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7888d5d5-379b-4b15-8747-fb353077ca67"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("78e1672e-8093-438f-8840-624d1f73804e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("840b3de2-fd1c-46a5-8be9-b5a056a02bf7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8e604072-f5f6-4a8f-8d16-49e4a781c18d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("adefe837-c876-49ac-b54f-1dafd4f9a6ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b39cd5dc-4711-4f89-8ade-32123f58a738"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c81c638d-1979-4a4f-aa76-c6a7fde5e2ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ce028899-e6af-4542-a2fd-5c7bd3e48cbc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e6ba6fd3-fc2a-4fac-8953-0bd919983458"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f33dac6c-5d82-4e68-b12c-1e7bd8f3217b"));

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    fAccount = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    fProduct = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("2f358903-8cdc-4031-9bb6-ec7b9850634e"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("00892d82-7318-4c33-994f-2b87bbaac6a7"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" },
                    { new Guid("578d5dac-b574-4256-afb8-5e1e29108337"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("98aefe40-64cf-4cdd-b07f-ddd200b43e5d"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("c5d74fb8-3509-46b4-bde8-cada99fc5150"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("b03b5ae9-8a74-4d1a-b908-552f56d52b13"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("588761e9-59e8-4fd4-a3e4-5bee235b15c1"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("cc8c09f4-aa46-427f-9ee5-af339a61370a"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("9989a914-8a53-44a0-af9b-5b0f395313c1"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("4cddc19f-55a8-42fe-bb86-3b720a2ce6ca"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("07681671-bebe-4568-b65a-f1287b96c27e"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("c00fd6e2-9965-4a7d-bae9-102a5f8e1cba"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("99d9f4e0-953a-4c99-a6df-652219741071"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("6d31f2a4-84b2-40ea-b658-468acf036bf2"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("f6e69882-2e7f-4f34-bb42-afa8b7e973e3"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("9f55e94d-9592-44a1-afb7-5205395b77d8"), new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"), new Guid("578d5dac-b574-4256-afb8-5e1e29108337") },
                    { new Guid("43bbef4c-25cb-46a3-a3cf-d46c71204806"), new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"), new Guid("b03b5ae9-8a74-4d1a-b908-552f56d52b13") },
                    { new Guid("e701f41c-dd45-4037-ab57-18a7216c1107"), new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"), new Guid("c5d74fb8-3509-46b4-bde8-cada99fc5150") },
                    { new Guid("95940fb8-0661-4530-9ed9-436c7f46e4ed"), new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"), new Guid("98aefe40-64cf-4cdd-b07f-ddd200b43e5d") },
                    { new Guid("9554ec67-4cdd-4b29-8b97-0c9fb344a2f3"), new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"), new Guid("00892d82-7318-4c33-994f-2b87bbaac6a7") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("00892d82-7318-4c33-994f-2b87bbaac6a7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("07681671-bebe-4568-b65a-f1287b96c27e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2f358903-8cdc-4031-9bb6-ec7b9850634e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4cddc19f-55a8-42fe-bb86-3b720a2ce6ca"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("578d5dac-b574-4256-afb8-5e1e29108337"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("588761e9-59e8-4fd4-a3e4-5bee235b15c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d31f2a4-84b2-40ea-b658-468acf036bf2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("98aefe40-64cf-4cdd-b07f-ddd200b43e5d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9989a914-8a53-44a0-af9b-5b0f395313c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99d9f4e0-953a-4c99-a6df-652219741071"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b03b5ae9-8a74-4d1a-b908-552f56d52b13"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c00fd6e2-9965-4a7d-bae9-102a5f8e1cba"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5d74fb8-3509-46b4-bde8-cada99fc5150"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cc8c09f4-aa46-427f-9ee5-af339a61370a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f6e69882-2e7f-4f34-bb42-afa8b7e973e3"));

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[] { new Guid("2825e7df-e568-41c8-8468-eede01fc9855"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("ce028899-e6af-4542-a2fd-5c7bd3e48cbc"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("b39cd5dc-4711-4f89-8ade-32123f58a738"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("78e1672e-8093-438f-8840-624d1f73804e"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("1d30e6ee-f798-4ee9-ada8-a109aad27523"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("2b456141-d06e-43cf-aa4a-d03b957465d5"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("c81c638d-1979-4a4f-aa76-c6a7fde5e2ec"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("6fb216d1-bdb0-4ee1-8f36-c605857243f9"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("7888d5d5-379b-4b15-8747-fb353077ca67"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("e6ba6fd3-fc2a-4fac-8953-0bd919983458"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("adefe837-c876-49ac-b54f-1dafd4f9a6ec"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("8e604072-f5f6-4a8f-8d16-49e4a781c18d"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("f33dac6c-5d82-4e68-b12c-1e7bd8f3217b"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("2f4b45d9-7634-4722-90e0-582dff5d60c8"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("840b3de2-fd1c-46a5-8be9-b5a056a02bf7"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("6a9f92e7-f174-4e41-9d65-ded8f6942775"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" }
                });
        }
    }
}
