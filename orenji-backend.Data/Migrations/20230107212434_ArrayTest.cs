using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class ArrayTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[] { new Guid("da844e71-9a24-46a4-9255-0824018ba12c"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("625a0778-96c0-4c4d-9a9f-3d2a7bb40bc1"), "The Bold Company", "Bold Shirt", 14.99, "Shoe" },
                    { new Guid("d75746ec-240f-487b-a012-7ca70f02256b"), "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("9b1403d4-d6b3-4835-be01-c2dcfdbc88e0"), "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("eeade479-8576-4c8d-8bd8-cf0b87463715"), "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("3d361dad-eed9-4fad-878e-4aac3da6326f"), "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("c3a4226c-6afb-41b8-a28c-626edc7a3de8"), "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("1870bf83-e8fc-43d5-8f89-712eff9a710c"), "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("1fc935d7-b971-411a-9e25-4aee0227e2f1"), "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("7ebfe328-57be-4fd5-b3dc-6ad3ac4294c8"), "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("a9ba4e08-4089-41f0-8951-25a26ff900df"), "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("7c6083f1-f4c9-4884-be65-c9247895bfe5"), "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("77bb22a1-6236-492f-8980-c9bff122be1c"), "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("ed554609-d6f3-43d4-bd93-4bf7f31a9e91"), "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("0417f3f6-f961-44c8-a38d-02de51d3ea81"), "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("81003214-2f58-4675-a3a5-3e06b8ce1868"), "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("7f0f08b3-7734-4e80-ab82-ad301f01a477"), new Guid("da844e71-9a24-46a4-9255-0824018ba12c"), new Guid("d75746ec-240f-487b-a012-7ca70f02256b") },
                    { new Guid("5a1a258d-a5fa-4637-be8d-c69d4f6b55ad"), new Guid("da844e71-9a24-46a4-9255-0824018ba12c"), new Guid("3d361dad-eed9-4fad-878e-4aac3da6326f") },
                    { new Guid("ccd06bc4-c7e2-4017-8104-1d5b1c13f788"), new Guid("da844e71-9a24-46a4-9255-0824018ba12c"), new Guid("eeade479-8576-4c8d-8bd8-cf0b87463715") },
                    { new Guid("9daf4719-df16-4f51-88cf-ddce2ffe3885"), new Guid("da844e71-9a24-46a4-9255-0824018ba12c"), new Guid("9b1403d4-d6b3-4835-be01-c2dcfdbc88e0") },
                    { new Guid("c91911a0-1b7e-4cd2-89e4-aca1e4665d10"), new Guid("da844e71-9a24-46a4-9255-0824018ba12c"), new Guid("625a0778-96c0-4c4d-9a9f-3d2a7bb40bc1") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("da844e71-9a24-46a4-9255-0824018ba12c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0417f3f6-f961-44c8-a38d-02de51d3ea81"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1870bf83-e8fc-43d5-8f89-712eff9a710c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1fc935d7-b971-411a-9e25-4aee0227e2f1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3d361dad-eed9-4fad-878e-4aac3da6326f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("625a0778-96c0-4c4d-9a9f-3d2a7bb40bc1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77bb22a1-6236-492f-8980-c9bff122be1c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7c6083f1-f4c9-4884-be65-c9247895bfe5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7ebfe328-57be-4fd5-b3dc-6ad3ac4294c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("81003214-2f58-4675-a3a5-3e06b8ce1868"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9b1403d4-d6b3-4835-be01-c2dcfdbc88e0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a9ba4e08-4089-41f0-8951-25a26ff900df"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c3a4226c-6afb-41b8-a28c-626edc7a3de8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d75746ec-240f-487b-a012-7ca70f02256b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ed554609-d6f3-43d4-bd93-4bf7f31a9e91"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eeade479-8576-4c8d-8bd8-cf0b87463715"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("5a1a258d-a5fa-4637-be8d-c69d4f6b55ad"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("7f0f08b3-7734-4e80-ab82-ad301f01a477"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("9daf4719-df16-4f51-88cf-ddce2ffe3885"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("c91911a0-1b7e-4cd2-89e4-aca1e4665d10"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("ccd06bc4-c7e2-4017-8104-1d5b1c13f788"));

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
    }
}
