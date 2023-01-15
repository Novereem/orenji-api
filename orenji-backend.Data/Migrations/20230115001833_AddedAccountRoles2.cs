using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AddedAccountRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role", "Size" },
                values: new object[,]
                {
                    { new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"), "a@a.com", "John", "Doe", "a", "11234567890", "Administrator", "M" },
                    { new Guid("99d3ac42-c35b-4601-ba06-217961fed709"), "b@b.com", "Joe", "Biden", "b", "21234567890", "User", "L" },
                    { new Guid("10aa6c9a-94b1-44a2-a359-4abd2e96692b"), "c@c.com", "James", "Howard", "c", "31234567890", "User", "XL" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AudienceType", "Company", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("318661b2-b65a-4555-82cf-18229934f26d"), "Male", "The Bold Company", "Bold Shirt", 14.99, "L", "Shoe" },
                    { new Guid("ab0b97e9-552e-49d2-89a5-5d330ce7775d"), "Female", "The Timid Company", "Timid Shirt", 64.989999999999995, "L", "Shoe" },
                    { new Guid("3aabda5d-f9f5-420c-8294-a6dd7eca4174"), "Female", "The Lonely Company", "Lonely Shirt", 24.989999999999998, "S", "Shoe" },
                    { new Guid("9d805f3d-652a-410a-b166-0479fdd0a790"), "Female", "The Docile Company", "Docile Shirt", 19.989999999999998, "M", "Shoe" },
                    { new Guid("750c35e8-2909-466e-b4d9-6b2315043940"), "Male", "The Adamant Company", "Adamant Shirt", 12.99, "M", "Shoe" },
                    { new Guid("d0b229f9-ea41-48ba-9866-92c0fa61e54f"), "Genderless", "The Brave Company", "Brave Shirt", 34.990000000000002, "M", "Shirt" },
                    { new Guid("426d4c42-9560-4fdc-96a1-d65a955c1f00"), "Genderless", "The Lonely Company", "Lonely Shirt", 14.99, "XS", "Shirt" },
                    { new Guid("b2eb1b31-5b98-460d-8056-631843199370"), "Genderless", "The Jolly Company", "Jolly Shirt", 47.990000000000002, "M", "Shirt" },
                    { new Guid("dc8c0600-4955-4721-babf-538809f5d046"), "Female", "The Modest Company", "Timid Shirt", 24.989999999999998, "M", "Shirt" },
                    { new Guid("c86b2467-2281-416a-827b-af37a05e8917"), "Male", "The Calm Company", "Calm Shirt", 19.989999999999998, "L", "Shirt" },
                    { new Guid("9e033753-eeb2-441a-9890-1d69d18586cd"), "Male", "The Modest Company", "Modest Shirt", 12.99, "M", "Shirt" },
                    { new Guid("03493d57-4665-4408-89b1-cecb58af820c"), "Female", "The Lax Company ", "Lax Pants", 1.99, "M", "Pants" },
                    { new Guid("5a817bdd-a121-4179-8776-89a19a46d4e2"), "Male", "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "L", "Pants" },
                    { new Guid("b3294573-abfe-448b-8a27-60f1703f0bed"), "Male", "The Cool Company", "Cool Pants", 4.9900000000000002, "M", "Pants" },
                    { new Guid("e0c3e3a9-1bce-4447-a279-f60f3263298a"), "Female", "The Adamant Company", "Adamant Shirt", 64.989999999999995, "S", "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("d000a953-67ad-46fb-b6c6-530b26412e5c"), new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"), new Guid("ab0b97e9-552e-49d2-89a5-5d330ce7775d") },
                    { new Guid("f63b018b-29f0-465e-ac8e-b86a6441ac91"), new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"), new Guid("750c35e8-2909-466e-b4d9-6b2315043940") },
                    { new Guid("dd32d51e-8029-40bb-9575-3cbd8e6d9b02"), new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"), new Guid("9d805f3d-652a-410a-b166-0479fdd0a790") },
                    { new Guid("1460dd15-d6bd-4bf8-81c2-71febfd2f835"), new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"), new Guid("3aabda5d-f9f5-420c-8294-a6dd7eca4174") },
                    { new Guid("b62d5e1a-86be-4738-9211-67fefcb7c95a"), new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"), new Guid("318661b2-b65a-4555-82cf-18229934f26d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10aa6c9a-94b1-44a2-a359-4abd2e96692b"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99d3ac42-c35b-4601-ba06-217961fed709"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("03493d57-4665-4408-89b1-cecb58af820c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("318661b2-b65a-4555-82cf-18229934f26d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3aabda5d-f9f5-420c-8294-a6dd7eca4174"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("426d4c42-9560-4fdc-96a1-d65a955c1f00"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a817bdd-a121-4179-8776-89a19a46d4e2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("750c35e8-2909-466e-b4d9-6b2315043940"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9d805f3d-652a-410a-b166-0479fdd0a790"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9e033753-eeb2-441a-9890-1d69d18586cd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ab0b97e9-552e-49d2-89a5-5d330ce7775d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b2eb1b31-5b98-460d-8056-631843199370"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b3294573-abfe-448b-8a27-60f1703f0bed"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c86b2467-2281-416a-827b-af37a05e8917"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0b229f9-ea41-48ba-9866-92c0fa61e54f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc8c0600-4955-4721-babf-538809f5d046"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e0c3e3a9-1bce-4447-a279-f60f3263298a"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("1460dd15-d6bd-4bf8-81c2-71febfd2f835"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("b62d5e1a-86be-4738-9211-67fefcb7c95a"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("d000a953-67ad-46fb-b6c6-530b26412e5c"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("dd32d51e-8029-40bb-9575-3cbd8e6d9b02"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("f63b018b-29f0-465e-ac8e-b86a6441ac91"));

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
    }
}
