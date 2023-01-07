using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("31d99643-3b2f-4140-a426-ecb4dd418485"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("012242e6-7fcc-4a69-a335-b2e654012ede"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("153d2570-77a1-4943-982c-cefac96d8930"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1ad15522-0b29-4b8d-8734-703841a2bd1c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e12bf6b-2da3-4c5e-885b-6453ec83b76d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6a8a300f-0cbe-456e-ae3a-cd3d8099dfc0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("780814e0-a305-43e0-a275-fed43b8393d0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92f1d657-93ea-4973-a021-b4b492ed6f88"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("93c7804d-805e-4c35-9d48-c733cc703b21"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("978fd7e9-26c2-41e1-8767-88de122b7e7c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b8401075-cd9f-4165-bd29-2a7192dd37cc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c729dd9d-0563-4f9a-b4c5-de8ac84709e3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e89e7034-2f9e-48e4-b202-255dc4147f53"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eb23a2e4-1347-410a-906c-ae267f72148a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("efd759f8-f5e9-49a8-aa85-8629657b9ed7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f0578860-3e8a-423b-8698-5cac95d93d9d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("31d99643-3b2f-4140-a426-ecb4dd418485"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("93c7804d-805e-4c35-9d48-c733cc703b21"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("153d2570-77a1-4943-982c-cefac96d8930"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("1e12bf6b-2da3-4c5e-885b-6453ec83b76d"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("012242e6-7fcc-4a69-a335-b2e654012ede"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("efd759f8-f5e9-49a8-aa85-8629657b9ed7"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("780814e0-a305-43e0-a275-fed43b8393d0"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("c729dd9d-0563-4f9a-b4c5-de8ac84709e3"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("1ad15522-0b29-4b8d-8734-703841a2bd1c"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("978fd7e9-26c2-41e1-8767-88de122b7e7c"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("92f1d657-93ea-4973-a021-b4b492ed6f88"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("6a8a300f-0cbe-456e-ae3a-cd3d8099dfc0"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("e89e7034-2f9e-48e4-b202-255dc4147f53"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("f0578860-3e8a-423b-8698-5cac95d93d9d"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("eb23a2e4-1347-410a-906c-ae267f72148a"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("b8401075-cd9f-4165-bd29-2a7192dd37cc"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" }
                });
        }
    }
}
