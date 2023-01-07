using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("f9bf6733-2042-43bf-a41e-2823f2b6b655"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0fbb53ff-8e07-47ff-8f1e-c1d495d1a22d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1c2c81cc-9ed3-4773-8aa6-919b42ae75d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("309ffcd1-3e05-4230-9b15-d38c5c1c5f79"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("352f7116-1950-4347-ac52-7976a19ca7fa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("384643ad-2348-4b7c-9c62-dc2adbd6c213"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("62161150-ca48-4a21-ba15-0e98d3f87d9d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d9049a8-92ce-46ac-809e-23720c50f9c2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("75f7c10c-84ef-4d43-9ebc-109cebc0c207"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8918bbb2-35dd-4a2e-bfb5-9fd7371fee47"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("abe0a80c-e75c-4e09-a6c1-8f3975c1bfc8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c18acc6b-34ed-4ac0-8c69-792ff79f0b52"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c38c3cf3-5bc9-4e49-8981-dbe46dc2495d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c43349dc-e901-4013-bb84-5a03497975ef"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f2d45aa9-1085-4c27-98d0-c7dba8309068"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fe84214a-1dbd-496e-9836-20c80c1f7e39"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Size" },
                values: new object[] { new Guid("f9bf6733-2042-43bf-a41e-2823f2b6b655"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("c38c3cf3-5bc9-4e49-8981-dbe46dc2495d"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("fe84214a-1dbd-496e-9836-20c80c1f7e39"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("c18acc6b-34ed-4ac0-8c69-792ff79f0b52"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("75f7c10c-84ef-4d43-9ebc-109cebc0c207"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("abe0a80c-e75c-4e09-a6c1-8f3975c1bfc8"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("6d9049a8-92ce-46ac-809e-23720c50f9c2"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("352f7116-1950-4347-ac52-7976a19ca7fa"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("f2d45aa9-1085-4c27-98d0-c7dba8309068"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("0fbb53ff-8e07-47ff-8f1e-c1d495d1a22d"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("1c2c81cc-9ed3-4773-8aa6-919b42ae75d1"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("8918bbb2-35dd-4a2e-bfb5-9fd7371fee47"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("c43349dc-e901-4013-bb84-5a03497975ef"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("62161150-ca48-4a21-ba15-0e98d3f87d9d"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("384643ad-2348-4b7c-9c62-dc2adbd6c213"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("309ffcd1-3e05-4230-9b15-d38c5c1c5f79"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" }
                });
        }
    }
}
