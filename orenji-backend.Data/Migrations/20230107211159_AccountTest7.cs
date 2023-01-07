using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("43bbef4c-25cb-46a3-a3cf-d46c71204806"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("9554ec67-4cdd-4b29-8b97-0c9fb344a2f3"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("95940fb8-0661-4530-9ed9-436c7f46e4ed"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("9f55e94d-9592-44a1-afb7-5205395b77d8"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("e701f41c-dd45-4037-ab57-18a7216c1107"));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("d2f9ac33-ed81-428d-b1d5-1e38f61b3931"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("3b1b725e-0ce4-4a81-9ac9-15dc4fefaa79"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" },
                    { new Guid("1db091bf-9701-4dce-bfc6-79c7a2703d51"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("7683ae3e-5f3e-40a0-bb66-0ad593d0f89a"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("cf58376b-fbf4-4c79-b159-92679119c05b"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("c5228e01-e461-4cf1-82a3-cc296fb87314"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("5d8b372e-e891-4e17-98c1-304cfa0dbf49"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("a93f2720-0f34-410f-b308-12e746f4c508"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("2570d752-ce8e-45f9-b4d6-e008b375380c"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("7a726a4a-25f3-4cc1-a59a-c704bc864553"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("92ea108c-5b40-4572-885e-f4c4e568e50d"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("aaa7a7e3-0bb1-40b8-9f47-fe9eb335c1d9"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("c607ab65-f49a-4c29-af32-67b14dab719b"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("a3c4c06c-8a14-4148-984a-b6bc758e1b4a"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("11421bfa-21b2-4e7d-b52e-340b985d0ae6"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("464ab413-4471-4b9b-848a-6d44e478efbc"), new Guid("af8e83e5-2f26-4da9-abe9-d4723425ab7c"), new Guid("1db091bf-9701-4dce-bfc6-79c7a2703d51") },
                    { new Guid("d2cad3fc-06f3-4224-9535-9b8880b68d19"), new Guid("af8e83e5-2f26-4da9-abe9-d4723425ab7c"), new Guid("c5228e01-e461-4cf1-82a3-cc296fb87314") },
                    { new Guid("b450557c-67ec-4d7a-98d1-83cefaac7f7b"), new Guid("af8e83e5-2f26-4da9-abe9-d4723425ab7c"), new Guid("cf58376b-fbf4-4c79-b159-92679119c05b") },
                    { new Guid("126592de-c80a-4d22-97bc-4aec2f1efe82"), new Guid("af8e83e5-2f26-4da9-abe9-d4723425ab7c"), new Guid("7683ae3e-5f3e-40a0-bb66-0ad593d0f89a") },
                    { new Guid("1596fe73-0b37-4afb-b11c-0ed66a35e063"), new Guid("af8e83e5-2f26-4da9-abe9-d4723425ab7c"), new Guid("3b1b725e-0ce4-4a81-9ac9-15dc4fefaa79") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11421bfa-21b2-4e7d-b52e-340b985d0ae6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1db091bf-9701-4dce-bfc6-79c7a2703d51"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2570d752-ce8e-45f9-b4d6-e008b375380c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3b1b725e-0ce4-4a81-9ac9-15dc4fefaa79"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5d8b372e-e891-4e17-98c1-304cfa0dbf49"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7683ae3e-5f3e-40a0-bb66-0ad593d0f89a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7a726a4a-25f3-4cc1-a59a-c704bc864553"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92ea108c-5b40-4572-885e-f4c4e568e50d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a3c4c06c-8a14-4148-984a-b6bc758e1b4a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a93f2720-0f34-410f-b308-12e746f4c508"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaa7a7e3-0bb1-40b8-9f47-fe9eb335c1d9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5228e01-e461-4cf1-82a3-cc296fb87314"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c607ab65-f49a-4c29-af32-67b14dab719b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cf58376b-fbf4-4c79-b159-92679119c05b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2f9ac33-ed81-428d-b1d5-1e38f61b3931"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("126592de-c80a-4d22-97bc-4aec2f1efe82"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("1596fe73-0b37-4afb-b11c-0ed66a35e063"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("464ab413-4471-4b9b-848a-6d44e478efbc"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("b450557c-67ec-4d7a-98d1-83cefaac7f7b"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("d2cad3fc-06f3-4224-9535-9b8880b68d19"));

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
    }
}
