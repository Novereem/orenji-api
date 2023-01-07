using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Account_AccountId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Account_AccountId1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_AccountId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_AccountId1",
                table: "Product");

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

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AccountId1",
                table: "Product");

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[] { new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("16d1c1c8-f9fd-47d7-9caa-3f9b0f4c29d5"), "The Bold Company", "Bold Shirt", 14.99, "Shoe" },
                    { new Guid("faa4d654-1a9c-40d5-9e31-9f07b83a68ee"), "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("eacc7445-85d6-47f5-ba35-1baf62f6bdfd"), "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("02a6bd67-ffa9-4d68-8ff0-7879e98ef918"), "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("84fc79b3-6cac-4f23-8636-de67a0f56632"), "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("d9ed4d2a-b2a7-409c-b8e6-ae50935e79ef"), "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("c7fe63cb-48cf-4688-b0aa-461c3e900bd7"), "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("4013069d-dad4-47a4-9657-ffc33312462d"), "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("f7fcec95-d693-43a5-9d07-9a8919383dfd"), "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("1fa5da33-ab26-452b-89cd-539f8cacbd94"), "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("31947e3f-9fa4-4153-bc77-90db19014bf4"), "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("6682f748-1f0a-4101-99e9-af9dfbc3a1dc"), "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("8b24113b-9371-4b6c-9779-1345fa7de995"), "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("74ef58e6-6db8-4cc9-b7cb-16f52f71796c"), "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("c5666f2e-64c6-4a5a-8e14-9cb40f167ad0"), "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("873edcb5-79d4-4ccd-9baa-d00bc5874b8c"), new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"), new Guid("faa4d654-1a9c-40d5-9e31-9f07b83a68ee") },
                    { new Guid("aae8f0ed-c707-45ab-985c-c2ccbf5b1743"), new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"), new Guid("84fc79b3-6cac-4f23-8636-de67a0f56632") },
                    { new Guid("26a1f235-e7aa-48cc-ac20-344b41a9f815"), new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"), new Guid("02a6bd67-ffa9-4d68-8ff0-7879e98ef918") },
                    { new Guid("2608d59c-3c60-4829-a19a-340faa051b72"), new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"), new Guid("eacc7445-85d6-47f5-ba35-1baf62f6bdfd") },
                    { new Guid("f877463f-56ec-4802-8c20-617bf02e3cbd"), new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"), new Guid("16d1c1c8-f9fd-47d7-9caa-3f9b0f4c29d5") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("02a6bd67-ffa9-4d68-8ff0-7879e98ef918"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("16d1c1c8-f9fd-47d7-9caa-3f9b0f4c29d5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1fa5da33-ab26-452b-89cd-539f8cacbd94"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("31947e3f-9fa4-4153-bc77-90db19014bf4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4013069d-dad4-47a4-9657-ffc33312462d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6682f748-1f0a-4101-99e9-af9dfbc3a1dc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("74ef58e6-6db8-4cc9-b7cb-16f52f71796c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("84fc79b3-6cac-4f23-8636-de67a0f56632"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8b24113b-9371-4b6c-9779-1345fa7de995"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5666f2e-64c6-4a5a-8e14-9cb40f167ad0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c7fe63cb-48cf-4688-b0aa-461c3e900bd7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d9ed4d2a-b2a7-409c-b8e6-ae50935e79ef"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eacc7445-85d6-47f5-ba35-1baf62f6bdfd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f7fcec95-d693-43a5-9d07-9a8919383dfd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faa4d654-1a9c-40d5-9e31-9f07b83a68ee"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("2608d59c-3c60-4829-a19a-340faa051b72"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("26a1f235-e7aa-48cc-ac20-344b41a9f815"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("873edcb5-79d4-4ccd-9baa-d00bc5874b8c"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("aae8f0ed-c707-45ab-985c-c2ccbf5b1743"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("f877463f-56ec-4802-8c20-617bf02e3cbd"));

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
    }
}
