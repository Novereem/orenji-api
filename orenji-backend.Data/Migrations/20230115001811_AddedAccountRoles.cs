using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AddedAccountRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Account",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role", "Size" },
                values: new object[,]
                {
                    { new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"), "a@a.com", "John", "Doe", "a", "11234567890", "Administrator", "M" },
                    { new Guid("8a07df4c-9375-49e9-bc5d-0d53bc099244"), "b@b.com", "Joe", "Biden", "b", "21234567890", "User", "L" },
                    { new Guid("30b3bd96-bddf-47b5-bc23-8cb8238ae14d"), "c@c.com", "James", "Howard", "c", "31234567890", "User", "XL" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AudienceType", "Company", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("711dc800-1475-4d67-adb7-d7e52544190d"), "Male", "The Bold Company", "Bold Shirt", 14.99, "L", "Shoe" },
                    { new Guid("055471d9-f7e4-471c-a9e3-a440e8578bf0"), "Female", "The Timid Company", "Timid Shirt", 64.989999999999995, "L", "Shoe" },
                    { new Guid("edd52901-7c74-470d-8534-4ecc9f1ba12e"), "Female", "The Lonely Company", "Lonely Shirt", 24.989999999999998, "S", "Shoe" },
                    { new Guid("e162e470-16d3-4b53-927b-b006c76dbd25"), "Female", "The Docile Company", "Docile Shirt", 19.989999999999998, "M", "Shoe" },
                    { new Guid("ce78bcd4-afb8-4af4-bb86-4d10fc7d4edd"), "Male", "The Adamant Company", "Adamant Shirt", 12.99, "M", "Shoe" },
                    { new Guid("6588f607-7689-415d-8b59-7775eb3e9f6e"), "Genderless", "The Brave Company", "Brave Shirt", 34.990000000000002, "M", "Shirt" },
                    { new Guid("5f7d25b4-f452-4015-aa08-bfd87d962f05"), "Genderless", "The Lonely Company", "Lonely Shirt", 14.99, "XS", "Shirt" },
                    { new Guid("8c2f9d2f-4c38-4ceb-a4ae-e4586fb79591"), "Genderless", "The Jolly Company", "Jolly Shirt", 47.990000000000002, "M", "Shirt" },
                    { new Guid("ae6a11c8-cdaa-4783-a030-1dd62beba250"), "Female", "The Modest Company", "Timid Shirt", 24.989999999999998, "M", "Shirt" },
                    { new Guid("80f11f23-2b44-43f8-a177-9ef1ac75f52c"), "Male", "The Calm Company", "Calm Shirt", 19.989999999999998, "L", "Shirt" },
                    { new Guid("25f4e013-2ccb-4a5e-bff1-7ec58c1f9392"), "Male", "The Modest Company", "Modest Shirt", 12.99, "M", "Shirt" },
                    { new Guid("11d912e7-fe1e-4f17-be10-4fa8b454820d"), "Female", "The Lax Company ", "Lax Pants", 1.99, "M", "Pants" },
                    { new Guid("0375b5ba-e44f-4eee-905e-bebe1be16d07"), "Male", "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "L", "Pants" },
                    { new Guid("74c914d0-c12c-44b4-b5a5-3039982bd086"), "Male", "The Cool Company", "Cool Pants", 4.9900000000000002, "M", "Pants" },
                    { new Guid("2679bd68-e563-4180-a7f3-9b1c43eb3819"), "Female", "The Adamant Company", "Adamant Shirt", 64.989999999999995, "S", "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("5ac16cb5-c4c6-4513-8173-556dd94e9647"), new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"), new Guid("055471d9-f7e4-471c-a9e3-a440e8578bf0") },
                    { new Guid("3d1e4972-9ecf-4052-aeed-ed544fadec0b"), new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"), new Guid("ce78bcd4-afb8-4af4-bb86-4d10fc7d4edd") },
                    { new Guid("41022a5f-4a81-4d8e-9cb4-18a83146f0f9"), new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"), new Guid("e162e470-16d3-4b53-927b-b006c76dbd25") },
                    { new Guid("4c0cf126-5441-42a4-888d-75cca709b484"), new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"), new Guid("edd52901-7c74-470d-8534-4ecc9f1ba12e") },
                    { new Guid("6d0e1d87-3ba9-49f0-a64e-a2d00d1c9afb"), new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"), new Guid("711dc800-1475-4d67-adb7-d7e52544190d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("30b3bd96-bddf-47b5-bc23-8cb8238ae14d"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("8a07df4c-9375-49e9-bc5d-0d53bc099244"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0375b5ba-e44f-4eee-905e-bebe1be16d07"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("055471d9-f7e4-471c-a9e3-a440e8578bf0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11d912e7-fe1e-4f17-be10-4fa8b454820d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("25f4e013-2ccb-4a5e-bff1-7ec58c1f9392"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2679bd68-e563-4180-a7f3-9b1c43eb3819"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5f7d25b4-f452-4015-aa08-bfd87d962f05"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6588f607-7689-415d-8b59-7775eb3e9f6e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("711dc800-1475-4d67-adb7-d7e52544190d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("74c914d0-c12c-44b4-b5a5-3039982bd086"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("80f11f23-2b44-43f8-a177-9ef1ac75f52c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8c2f9d2f-4c38-4ceb-a4ae-e4586fb79591"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae6a11c8-cdaa-4783-a030-1dd62beba250"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ce78bcd4-afb8-4af4-bb86-4d10fc7d4edd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e162e470-16d3-4b53-927b-b006c76dbd25"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("edd52901-7c74-470d-8534-4ecc9f1ba12e"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("3d1e4972-9ecf-4052-aeed-ed544fadec0b"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("41022a5f-4a81-4d8e-9cb4-18a83146f0f9"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("4c0cf126-5441-42a4-888d-75cca709b484"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("5ac16cb5-c4c6-4513-8173-556dd94e9647"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("6d0e1d87-3ba9-49f0-a64e-a2d00d1c9afb"));

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Account");

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
    }
}
