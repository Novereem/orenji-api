// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using orenji_backend.Data;

namespace orenji_backend.Data.Migrations
{
    [DbContext(typeof(OrenjiContext))]
    [Migration("20230107211135_AccountTest6")]
    partial class AccountTest6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("orenji_backend.Common.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Size")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("orenji_backend.Common.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AccountId1")
                        .HasColumnType("char(36)");

                    b.Property<string>("Company")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AccountId1");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f358903-8cdc-4031-9bb6-ec7b9850634e"),
                            Company = "The Cool Company",
                            Name = "Cool Pants",
                            Price = 4.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("6d31f2a4-84b2-40ea-b658-468acf036bf2"),
                            Company = "The Quirky Company ",
                            Name = "Quirky Pants",
                            Price = 9.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("99d9f4e0-953a-4c99-a6df-652219741071"),
                            Company = "The Lax Company ",
                            Name = "Lax Pants",
                            Price = 1.99,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("c00fd6e2-9965-4a7d-bae9-102a5f8e1cba"),
                            Company = "The Modest Company",
                            Name = "Modest Shirt",
                            Price = 12.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("07681671-bebe-4568-b65a-f1287b96c27e"),
                            Company = "The Calm Company",
                            Name = "Calm Shirt",
                            Price = 19.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("4cddc19f-55a8-42fe-bb86-3b720a2ce6ca"),
                            Company = "The Modest Company",
                            Name = "Timid Shirt",
                            Price = 24.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("9989a914-8a53-44a0-af9b-5b0f395313c1"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 64.989999999999995,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("f6e69882-2e7f-4f34-bb42-afa8b7e973e3"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 14.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("588761e9-59e8-4fd4-a3e4-5bee235b15c1"),
                            Company = "The Jolly Company",
                            Name = "Jolly Shirt",
                            Price = 47.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("cc8c09f4-aa46-427f-9ee5-af339a61370a"),
                            Company = "The Brave Company",
                            Name = "Brave Shirt",
                            Price = 34.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("b03b5ae9-8a74-4d1a-b908-552f56d52b13"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 12.99,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("c5d74fb8-3509-46b4-bde8-cada99fc5150"),
                            Company = "The Docile Company",
                            Name = "Docile Shirt",
                            Price = 19.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("98aefe40-64cf-4cdd-b07f-ddd200b43e5d"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 24.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("578d5dac-b574-4256-afb8-5e1e29108337"),
                            Company = "The Timid Company",
                            Name = "Timid Shirt",
                            Price = 64.989999999999995,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("00892d82-7318-4c33-994f-2b87bbaac6a7"),
                            Company = "The Bold Company",
                            Name = "Bold Shirt",
                            Price = 14.99,
                            Type = "Shoe"
                        });
                });

            modelBuilder.Entity("orenji_backend.Common.Models.ProductInCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("fAccount")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("fProduct")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("ProductInCart");

                    b.HasData(
                        new
                        {
                            Id = new Guid("43bbef4c-25cb-46a3-a3cf-d46c71204806"),
                            fAccount = new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"),
                            fProduct = new Guid("b03b5ae9-8a74-4d1a-b908-552f56d52b13")
                        },
                        new
                        {
                            Id = new Guid("e701f41c-dd45-4037-ab57-18a7216c1107"),
                            fAccount = new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"),
                            fProduct = new Guid("c5d74fb8-3509-46b4-bde8-cada99fc5150")
                        },
                        new
                        {
                            Id = new Guid("95940fb8-0661-4530-9ed9-436c7f46e4ed"),
                            fAccount = new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"),
                            fProduct = new Guid("98aefe40-64cf-4cdd-b07f-ddd200b43e5d")
                        },
                        new
                        {
                            Id = new Guid("9f55e94d-9592-44a1-afb7-5205395b77d8"),
                            fAccount = new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"),
                            fProduct = new Guid("578d5dac-b574-4256-afb8-5e1e29108337")
                        },
                        new
                        {
                            Id = new Guid("9554ec67-4cdd-4b29-8b97-0c9fb344a2f3"),
                            fAccount = new Guid("36e0df00-0c78-4b14-a043-b5522961a62a"),
                            fProduct = new Guid("00892d82-7318-4c33-994f-2b87bbaac6a7")
                        });
                });

            modelBuilder.Entity("orenji_backend.Common.Models.Product", b =>
                {
                    b.HasOne("orenji_backend.Common.Models.Account", null)
                        .WithMany("CartProducts")
                        .HasForeignKey("AccountId");

                    b.HasOne("orenji_backend.Common.Models.Account", null)
                        .WithMany("LikedProducts")
                        .HasForeignKey("AccountId1");
                });

            modelBuilder.Entity("orenji_backend.Common.Models.Account", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("LikedProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
