using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class MoreVariedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[,]
                {
                    { new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"), "a@a.com", "John", "Doe", "a", "11234567890", "M" },
                    { new Guid("cc923a8d-b099-4a94-a6af-0dfbea9221fc"), "b@b.com", "Joe", "Biden", "b", "21234567890", "L" },
                    { new Guid("f269d8a3-37e3-4062-bcd9-bb8ae4031a3c"), "c@c.com", "James", "Howard", "c", "31234567890", "XL" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AudienceType", "Company", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("9a72af1b-e958-499a-acc3-50a5257c25a2"), "Male", "The Bold Company", "Bold Shirt", 14.99, "L", "Shoe" },
                    { new Guid("46b8eb91-0960-4904-beaa-a011e11d7e27"), "Female", "The Timid Company", "Timid Shirt", 64.989999999999995, "L", "Shoe" },
                    { new Guid("899faa01-bba9-42f8-bda8-4ae7ac340638"), "Female", "The Lonely Company", "Lonely Shirt", 24.989999999999998, "S", "Shoe" },
                    { new Guid("92bdb1a3-f319-4b6d-99b5-ac99bfbaf0da"), "Female", "The Docile Company", "Docile Shirt", 19.989999999999998, "M", "Shoe" },
                    { new Guid("3964e013-24c9-43ae-a6ae-b72c57660585"), "Male", "The Adamant Company", "Adamant Shirt", 12.99, "M", "Shoe" },
                    { new Guid("d7237b8a-d35c-467b-82ac-06bf10e88ffb"), "Genderless", "The Brave Company", "Brave Shirt", 34.990000000000002, "M", "Shirt" },
                    { new Guid("20d922d0-8117-4906-8bef-6acf54aad172"), "Genderless", "The Lonely Company", "Lonely Shirt", 14.99, "XS", "Shirt" },
                    { new Guid("7d9bd902-da63-44f9-8536-d014ea5fb1ee"), "Genderless", "The Jolly Company", "Jolly Shirt", 47.990000000000002, "M", "Shirt" },
                    { new Guid("1228a42e-20bc-4caf-919c-66ed1eaa4d34"), "Female", "The Modest Company", "Timid Shirt", 24.989999999999998, "M", "Shirt" },
                    { new Guid("35418881-2aa7-4743-b3c2-d1f498c121ab"), "Male", "The Calm Company", "Calm Shirt", 19.989999999999998, "L", "Shirt" },
                    { new Guid("76a0262d-a863-4bdb-8a61-9e5e0babafbf"), "Male", "The Modest Company", "Modest Shirt", 12.99, "M", "Shirt" },
                    { new Guid("1d232014-b9aa-49ae-9584-9dee7605e81d"), "Female", "The Lax Company ", "Lax Pants", 1.99, "M", "Pants" },
                    { new Guid("18765e76-5367-47b1-a743-c8582b91a8af"), "Male", "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "L", "Pants" },
                    { new Guid("9442467f-055d-4814-8411-617d48501cf7"), "Male", "The Cool Company", "Cool Pants", 4.9900000000000002, "M", "Pants" },
                    { new Guid("50256ef6-bc7a-475f-b2c5-179e10b2bf8c"), "Female", "The Adamant Company", "Adamant Shirt", 64.989999999999995, "S", "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("23611263-e40a-4d29-9c21-da86a8431349"), new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"), new Guid("46b8eb91-0960-4904-beaa-a011e11d7e27") },
                    { new Guid("e6abf797-3eb7-4b0a-a9ae-8859e09076bb"), new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"), new Guid("3964e013-24c9-43ae-a6ae-b72c57660585") },
                    { new Guid("3c0b23db-6b47-4363-a79c-20291a5052ab"), new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"), new Guid("92bdb1a3-f319-4b6d-99b5-ac99bfbaf0da") },
                    { new Guid("e264ded7-b6bd-4f9b-b88d-d0d88848b67a"), new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"), new Guid("899faa01-bba9-42f8-bda8-4ae7ac340638") },
                    { new Guid("c0ea0292-34a3-4493-b2b8-9181b5668073"), new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"), new Guid("9a72af1b-e958-499a-acc3-50a5257c25a2") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88012fe0-114f-4a36-858a-49e6cfe92650"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cc923a8d-b099-4a94-a6af-0dfbea9221fc"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("f269d8a3-37e3-4062-bcd9-bb8ae4031a3c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1228a42e-20bc-4caf-919c-66ed1eaa4d34"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("18765e76-5367-47b1-a743-c8582b91a8af"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1d232014-b9aa-49ae-9584-9dee7605e81d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("20d922d0-8117-4906-8bef-6acf54aad172"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("35418881-2aa7-4743-b3c2-d1f498c121ab"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3964e013-24c9-43ae-a6ae-b72c57660585"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("46b8eb91-0960-4904-beaa-a011e11d7e27"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("50256ef6-bc7a-475f-b2c5-179e10b2bf8c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("76a0262d-a863-4bdb-8a61-9e5e0babafbf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d9bd902-da63-44f9-8536-d014ea5fb1ee"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("899faa01-bba9-42f8-bda8-4ae7ac340638"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92bdb1a3-f319-4b6d-99b5-ac99bfbaf0da"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9442467f-055d-4814-8411-617d48501cf7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9a72af1b-e958-499a-acc3-50a5257c25a2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7237b8a-d35c-467b-82ac-06bf10e88ffb"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("23611263-e40a-4d29-9c21-da86a8431349"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("3c0b23db-6b47-4363-a79c-20291a5052ab"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("c0ea0292-34a3-4493-b2b8-9181b5668073"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("e264ded7-b6bd-4f9b-b88d-d0d88848b67a"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("e6abf797-3eb7-4b0a-a9ae-8859e09076bb"));

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
    }
}
