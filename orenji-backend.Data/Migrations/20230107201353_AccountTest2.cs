using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace orenji_backend.Data.Migrations
{
    public partial class AccountTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("767970bf-b2e4-400d-bcf7-e3a684ed3bb8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("00e60eb0-ec59-4564-b647-613e3438ab2d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("18803175-e3c8-455e-9c7a-0c36ca41dac1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33945978-4409-4ff1-af99-3903400ac38c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("38d5c3a5-2116-488f-8dfb-5bb5e85a31fa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7552d24c-23ef-4a47-a06d-092529784a23"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92ece56e-2e7f-45f3-8fe4-c12c9d52843d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9d50ddd0-d7a2-46d4-b346-6e0b1adfa385"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b777e133-b9b0-414b-8ce5-c9ef1dd3fd9e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c086e725-77bd-436b-990d-9288bbdb43b2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0ccfe7e-17ea-40aa-b8e2-dad7c8affc09"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7c46cfa-ad9b-44b8-bc97-44812e1cadc3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dcb0d6dc-952c-4bf7-94f5-1d3b355ea0e7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dfd92be8-a94a-411d-b086-404f93167662"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e660ef8e-4012-4b09-ab63-57697ee019bb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("facc80fc-34fc-4a99-8963-d23d956e0897"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("767970bf-b2e4-400d-bcf7-e3a684ed3bb8"), "a@a.com", "John", "Doe", "a", "11234567890", "M" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "AccountId1", "Company", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("33945978-4409-4ff1-af99-3903400ac38c"), null, null, "The Cool Company", "Cool Pants", 4.9900000000000002, "Pants" },
                    { new Guid("92ece56e-2e7f-45f3-8fe4-c12c9d52843d"), null, null, "The Quirky Company ", "Quirky Pants", 9.9900000000000002, "Pants" },
                    { new Guid("c086e725-77bd-436b-990d-9288bbdb43b2"), null, null, "The Lax Company ", "Lax Pants", 1.99, "Pants" },
                    { new Guid("b777e133-b9b0-414b-8ce5-c9ef1dd3fd9e"), null, null, "The Modest Company", "Modest Shirt", 12.99, "Shirt" },
                    { new Guid("d7c46cfa-ad9b-44b8-bc97-44812e1cadc3"), null, null, "The Calm Company", "Calm Shirt", 19.989999999999998, "Shirt" },
                    { new Guid("facc80fc-34fc-4a99-8963-d23d956e0897"), null, null, "The Modest Company", "Timid Shirt", 24.989999999999998, "Shirt" },
                    { new Guid("18803175-e3c8-455e-9c7a-0c36ca41dac1"), null, null, "The Adamant Company", "Adamant Shirt", 64.989999999999995, "Shirt" },
                    { new Guid("dfd92be8-a94a-411d-b086-404f93167662"), null, null, "The Lonely Company", "Lonely Shirt", 14.99, "Shirt" },
                    { new Guid("00e60eb0-ec59-4564-b647-613e3438ab2d"), null, null, "The Jolly Company", "Jolly Shirt", 47.990000000000002, "Shirt" },
                    { new Guid("dcb0d6dc-952c-4bf7-94f5-1d3b355ea0e7"), null, null, "The Brave Company", "Brave Shirt", 34.990000000000002, "Shirt" },
                    { new Guid("7552d24c-23ef-4a47-a06d-092529784a23"), null, null, "The Adamant Company", "Adamant Shirt", 12.99, "Shoe" },
                    { new Guid("d0ccfe7e-17ea-40aa-b8e2-dad7c8affc09"), null, null, "The Docile Company", "Docile Shirt", 19.989999999999998, "Shoe" },
                    { new Guid("9d50ddd0-d7a2-46d4-b346-6e0b1adfa385"), null, null, "The Lonely Company", "Lonely Shirt", 24.989999999999998, "Shoe" },
                    { new Guid("38d5c3a5-2116-488f-8dfb-5bb5e85a31fa"), null, null, "The Timid Company", "Timid Shirt", 64.989999999999995, "Shoe" },
                    { new Guid("e660ef8e-4012-4b09-ab63-57697ee019bb"), null, null, "The Bold Company", "Bold Shirt", 14.99, "Shoe" }
                });
        }
    }
}
