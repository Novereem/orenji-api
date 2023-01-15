using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AddedAccountRoles3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"), "a@a.com", "John", "Doe", "a", "11234567890", "Administrator", "M" },
                    { new Guid("9a5de550-1e05-4f3c-a161-8708b18ab88c"), "b@b.com", "Joe", "Biden", "b", "21234567890", "User", "L" },
                    { new Guid("35cf9275-009b-4335-bbcc-4f512486d403"), "c@c.com", "James", "Howard", "c", "31234567890", "User", "XL" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AudienceType", "Company", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("36336085-885b-4fda-8d45-0e79a6387469"), "Male", "The Bold Company", "Bold Shirt", 14.99, "L", "Shoe" },
                    { new Guid("1f61adac-beff-44ec-88a3-06c29ee45510"), "Female", "The Timid Company", "Timid Shirt", 64.989999999999995, "L", "Shoe" },
                    { new Guid("682c75e0-eebe-457e-999b-3d24d0f4efd9"), "Female", "The Lonely Company", "Lonely Shirt", 24.989999999999998, "S", "Shoe" },
                    { new Guid("439e84e1-8995-4876-a669-54649890e156"), "Female", "The Docile Company", "Docile Shirt", 19.989999999999998, "M", "Shoe" },
                    { new Guid("462814c3-6b78-4713-a67a-9780341f9b81"), "Male", "The Adamant Company", "Adamant Shirt", 12.99, "M", "Shoe" },
                    { new Guid("748d03d8-8d3c-4dcf-9d20-efb6fe389e66"), "Genderless", "The Brave Company", "Brave Shirt", 34.990000000000002, "M", "Shirt" },
                    { new Guid("f6da7f5b-a446-42f4-9e2b-7abe0c24e9bb"), "Genderless", "The Lonely Company", "Lonely Shirt", 14.99, "XS", "Shirt" },
                    { new Guid("98369b84-bd83-4853-ad78-0873e50f98aa"), "Genderless", "The Jolly Company", "Jolly Shirt", 47.990000000000002, "M", "Shirt" },
                    { new Guid("c0d7a583-4bb5-481a-b1ae-c1c8a47f309f"), "Female", "The Modest Company", "Timid Shirt", 24.989999999999998, "M", "Shirt" },
                    { new Guid("09089ee3-77dc-42a0-8b6e-2cb9b9593537"), "Male", "The Calm Company", "Calm Shirt", 19.989999999999998, "L", "Shirt" },
                    { new Guid("f1319c4f-2674-4e22-af38-48ca25c154fd"), "Male", "The Modest Company", "Modest Shirt", 12.99, "M", "Shirt" },
                    { new Guid("ad6446b6-ffd8-4c51-b496-158d6da4d5b4"), "Female", "The Lax Company ", "Lax Pants", 1.99, "M", "Pants" },
                    { new Guid("024f5426-2458-4273-991b-fb3863482e57"), "Male", "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "L", "Pants" },
                    { new Guid("b5a6b395-b75e-4343-ae1a-183e7c641771"), "Male", "The Cool Company", "Cool Pants", 4.9900000000000002, "M", "Pants" },
                    { new Guid("219363f7-4997-4e96-89f0-99ec78c64ae9"), "Female", "The Adamant Company", "Adamant Shirt", 64.989999999999995, "S", "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "fAccount", "fProduct" },
                values: new object[,]
                {
                    { new Guid("4e4d5a15-9c91-45de-9b16-d0065b7d00db"), new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"), new Guid("1f61adac-beff-44ec-88a3-06c29ee45510") },
                    { new Guid("c136025d-07a0-488b-864a-5de03a3d85b2"), new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"), new Guid("462814c3-6b78-4713-a67a-9780341f9b81") },
                    { new Guid("be434191-663a-43b5-a796-56e301a951cd"), new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"), new Guid("439e84e1-8995-4876-a669-54649890e156") },
                    { new Guid("48650102-88a8-4f2a-bc98-3c5a0c483149"), new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"), new Guid("682c75e0-eebe-457e-999b-3d24d0f4efd9") },
                    { new Guid("fe517fe5-a26a-44e4-b143-5ac1755d31f3"), new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"), new Guid("36336085-885b-4fda-8d45-0e79a6387469") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("35cf9275-009b-4335-bbcc-4f512486d403"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("567cf2ec-f095-420f-8ed5-ad7fcbfcf50b"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("9a5de550-1e05-4f3c-a161-8708b18ab88c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("024f5426-2458-4273-991b-fb3863482e57"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("09089ee3-77dc-42a0-8b6e-2cb9b9593537"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1f61adac-beff-44ec-88a3-06c29ee45510"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("219363f7-4997-4e96-89f0-99ec78c64ae9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36336085-885b-4fda-8d45-0e79a6387469"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("439e84e1-8995-4876-a669-54649890e156"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("462814c3-6b78-4713-a67a-9780341f9b81"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("682c75e0-eebe-457e-999b-3d24d0f4efd9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("748d03d8-8d3c-4dcf-9d20-efb6fe389e66"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("98369b84-bd83-4853-ad78-0873e50f98aa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ad6446b6-ffd8-4c51-b496-158d6da4d5b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b5a6b395-b75e-4343-ae1a-183e7c641771"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c0d7a583-4bb5-481a-b1ae-c1c8a47f309f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f1319c4f-2674-4e22-af38-48ca25c154fd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f6da7f5b-a446-42f4-9e2b-7abe0c24e9bb"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("48650102-88a8-4f2a-bc98-3c5a0c483149"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("4e4d5a15-9c91-45de-9b16-d0065b7d00db"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("be434191-663a-43b5-a796-56e301a951cd"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("c136025d-07a0-488b-864a-5de03a3d85b2"));

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumn: "Id",
                keyValue: new Guid("fe517fe5-a26a-44e4-b143-5ac1755d31f3"));

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
    }
}
