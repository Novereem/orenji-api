using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class ProductChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AudienceType",
                table: "Product",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Product",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[,]
                {
                    { new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"), "a@a.com", "John", "Doe", "a", "11234567890", "M" },
                    { new Guid("7903c56e-5785-45ed-b2b7-12cc0189b384"), "b@b.com", "Joe", "Biden", "b", "21234567890", "L" },
                    { new Guid("b8a175d9-49e1-4609-b7b2-ec6877d5fced"), "c@c.com", "James", "Howard", "c", "31234567890", "XL" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AudienceType", "Company", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("e7bb15e3-b88c-4c94-b1dc-7592146a9d0a"), "Male", "The Bold Company", "Bold Shirt", 14.99, "M", "Shoe" },
                    { new Guid("0b516438-3831-4666-a200-75dc5a82c78f"), "Male", "The Timid Company", "Timid Shirt", 64.989999999999995, "M", "Shoe" },
                    { new Guid("5276a148-eee5-4523-9a53-166d6681c812"), "Male", "The Lonely Company", "Lonely Shirt", 24.989999999999998, "M", "Shoe" },
                    { new Guid("d3eac698-92c0-4fff-aa3c-3b943d057d5f"), "Male", "The Docile Company", "Docile Shirt", 19.989999999999998, "M", "Shoe" },
                    { new Guid("5a417974-a42c-4445-bdcc-cf22d19fb4a1"), "Male", "The Adamant Company", "Adamant Shirt", 12.99, "M", "Shoe" },
                    { new Guid("af817a7f-90c6-410c-932e-514274761baf"), "Male", "The Brave Company", "Brave Shirt", 34.990000000000002, "M", "Shirt" },
                    { new Guid("6a8f73be-5bd6-495c-9014-d2857c031343"), "Male", "The Lonely Company", "Lonely Shirt", 14.99, "M", "Shirt" },
                    { new Guid("a9adbdc1-fc2a-4dac-b3fc-8b93ede1c947"), "Male", "The Jolly Company", "Jolly Shirt", 47.990000000000002, "M", "Shirt" },
                    { new Guid("2977fca5-ba72-4709-8c3d-1d95351279d1"), "Male", "The Modest Company", "Timid Shirt", 24.989999999999998, "M", "Shirt" },
                    { new Guid("43165ec8-4aa0-48aa-a0ed-6587fea0f916"), "Male", "The Calm Company", "Calm Shirt", 19.989999999999998, "M", "Shirt" },
                    { new Guid("738fc24d-668d-423b-ab22-bb61fc2c7656"), "Male", "The Modest Company", "Modest Shirt", 12.99, "M", "Shirt" },
                    { new Guid("171b609b-6d5b-4b3e-9f28-97e451ad29a1"), "Male", "The Lax Company ", "Lax Pants", 1.99, "M", "Pants" },
                    { new Guid("a8f343eb-ddcd-4dd1-b7f0-5384c5c99f8a"), "Male", "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "M", "Pants" },
                    { new Guid("168d4936-0a69-443c-88cf-61223a0eaccc"), "Male", "The Cool Company", "Cool Pants", 4.9900000000000002, "M", "Pants" },
                    { new Guid("4b717fdd-a770-4bcd-bd2e-6fdde86a0350"), "Male", "The Adamant Company", "Adamant Shirt", 64.989999999999995, "M", "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("2f21d87a-fbbd-494a-b6a7-f4a836fbcb06"), new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"), new Guid("0b516438-3831-4666-a200-75dc5a82c78f") },
                    { new Guid("ad323092-4519-4879-ac8e-78744df6fa96"), new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"), new Guid("5a417974-a42c-4445-bdcc-cf22d19fb4a1") },
                    { new Guid("abbb9791-0655-4c27-89d8-235be9382dca"), new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"), new Guid("d3eac698-92c0-4fff-aa3c-3b943d057d5f") },
                    { new Guid("5b172a92-01a5-4dd4-985f-b465ede9148c"), new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"), new Guid("5276a148-eee5-4523-9a53-166d6681c812") },
                    { new Guid("808e08dd-9b41-4e67-91bf-f3edcab2004a"), new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"), new Guid("e7bb15e3-b88c-4c94-b1dc-7592146a9d0a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46b03f62-5016-48a1-bd41-aa3d639e6673"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("7903c56e-5785-45ed-b2b7-12cc0189b384"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8a175d9-49e1-4609-b7b2-ec6877d5fced"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0b516438-3831-4666-a200-75dc5a82c78f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("168d4936-0a69-443c-88cf-61223a0eaccc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("171b609b-6d5b-4b3e-9f28-97e451ad29a1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2977fca5-ba72-4709-8c3d-1d95351279d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43165ec8-4aa0-48aa-a0ed-6587fea0f916"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4b717fdd-a770-4bcd-bd2e-6fdde86a0350"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5276a148-eee5-4523-9a53-166d6681c812"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a417974-a42c-4445-bdcc-cf22d19fb4a1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6a8f73be-5bd6-495c-9014-d2857c031343"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("738fc24d-668d-423b-ab22-bb61fc2c7656"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a8f343eb-ddcd-4dd1-b7f0-5384c5c99f8a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a9adbdc1-fc2a-4dac-b3fc-8b93ede1c947"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af817a7f-90c6-410c-932e-514274761baf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d3eac698-92c0-4fff-aa3c-3b943d057d5f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e7bb15e3-b88c-4c94-b1dc-7592146a9d0a"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("2f21d87a-fbbd-494a-b6a7-f4a836fbcb06"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("5b172a92-01a5-4dd4-985f-b465ede9148c"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("808e08dd-9b41-4e67-91bf-f3edcab2004a"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("abbb9791-0655-4c27-89d8-235be9382dca"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("ad323092-4519-4879-ac8e-78744df6fa96"));

            migrationBuilder.DropColumn(
                name: "AudienceType",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Product");

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
    }
}
