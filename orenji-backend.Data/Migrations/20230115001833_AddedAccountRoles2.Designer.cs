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
    [Migration("20230115001833_AddedAccountRoles2")]
    partial class AddedAccountRoles2
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

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<string>("Size")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"),
                            Email = "a@a.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "a",
                            PhoneNumber = "11234567890",
                            Role = "Administrator",
                            Size = "M"
                        },
                        new
                        {
                            Id = new Guid("99d3ac42-c35b-4601-ba06-217961fed709"),
                            Email = "b@b.com",
                            FirstName = "Joe",
                            LastName = "Biden",
                            Password = "b",
                            PhoneNumber = "21234567890",
                            Role = "User",
                            Size = "L"
                        },
                        new
                        {
                            Id = new Guid("10aa6c9a-94b1-44a2-a359-4abd2e96692b"),
                            Email = "c@c.com",
                            FirstName = "James",
                            LastName = "Howard",
                            Password = "c",
                            PhoneNumber = "31234567890",
                            Role = "User",
                            Size = "XL"
                        });
                });

            modelBuilder.Entity("orenji_backend.Common.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AudienceType")
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Size")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3294573-abfe-448b-8a27-60f1703f0bed"),
                            AudienceType = "Male",
                            Company = "The Cool Company",
                            Name = "Cool Pants",
                            Price = 4.9900000000000002,
                            Size = "M",
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("5a817bdd-a121-4179-8776-89a19a46d4e2"),
                            AudienceType = "Male",
                            Company = "The Quirky Company ",
                            Name = "Quirky Pants",
                            Price = 9.9900000000000002,
                            Size = "L",
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("03493d57-4665-4408-89b1-cecb58af820c"),
                            AudienceType = "Female",
                            Company = "The Lax Company ",
                            Name = "Lax Pants",
                            Price = 1.99,
                            Size = "M",
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("9e033753-eeb2-441a-9890-1d69d18586cd"),
                            AudienceType = "Male",
                            Company = "The Modest Company",
                            Name = "Modest Shirt",
                            Price = 12.99,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("c86b2467-2281-416a-827b-af37a05e8917"),
                            AudienceType = "Male",
                            Company = "The Calm Company",
                            Name = "Calm Shirt",
                            Price = 19.989999999999998,
                            Size = "L",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("dc8c0600-4955-4721-babf-538809f5d046"),
                            AudienceType = "Female",
                            Company = "The Modest Company",
                            Name = "Timid Shirt",
                            Price = 24.989999999999998,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("e0c3e3a9-1bce-4447-a279-f60f3263298a"),
                            AudienceType = "Female",
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 64.989999999999995,
                            Size = "S",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("426d4c42-9560-4fdc-96a1-d65a955c1f00"),
                            AudienceType = "Genderless",
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 14.99,
                            Size = "XS",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("b2eb1b31-5b98-460d-8056-631843199370"),
                            AudienceType = "Genderless",
                            Company = "The Jolly Company",
                            Name = "Jolly Shirt",
                            Price = 47.990000000000002,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("d0b229f9-ea41-48ba-9866-92c0fa61e54f"),
                            AudienceType = "Genderless",
                            Company = "The Brave Company",
                            Name = "Brave Shirt",
                            Price = 34.990000000000002,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("750c35e8-2909-466e-b4d9-6b2315043940"),
                            AudienceType = "Male",
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 12.99,
                            Size = "M",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("9d805f3d-652a-410a-b166-0479fdd0a790"),
                            AudienceType = "Female",
                            Company = "The Docile Company",
                            Name = "Docile Shirt",
                            Price = 19.989999999999998,
                            Size = "M",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("3aabda5d-f9f5-420c-8294-a6dd7eca4174"),
                            AudienceType = "Female",
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 24.989999999999998,
                            Size = "S",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("ab0b97e9-552e-49d2-89a5-5d330ce7775d"),
                            AudienceType = "Female",
                            Company = "The Timid Company",
                            Name = "Timid Shirt",
                            Price = 64.989999999999995,
                            Size = "L",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("318661b2-b65a-4555-82cf-18229934f26d"),
                            AudienceType = "Male",
                            Company = "The Bold Company",
                            Name = "Bold Shirt",
                            Price = 14.99,
                            Size = "L",
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
                            Id = new Guid("f63b018b-29f0-465e-ac8e-b86a6441ac91"),
                            fAccount = new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"),
                            fProduct = new Guid("750c35e8-2909-466e-b4d9-6b2315043940")
                        },
                        new
                        {
                            Id = new Guid("dd32d51e-8029-40bb-9575-3cbd8e6d9b02"),
                            fAccount = new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"),
                            fProduct = new Guid("9d805f3d-652a-410a-b166-0479fdd0a790")
                        },
                        new
                        {
                            Id = new Guid("1460dd15-d6bd-4bf8-81c2-71febfd2f835"),
                            fAccount = new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"),
                            fProduct = new Guid("3aabda5d-f9f5-420c-8294-a6dd7eca4174")
                        },
                        new
                        {
                            Id = new Guid("d000a953-67ad-46fb-b6c6-530b26412e5c"),
                            fAccount = new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"),
                            fProduct = new Guid("ab0b97e9-552e-49d2-89a5-5d330ce7775d")
                        },
                        new
                        {
                            Id = new Guid("b62d5e1a-86be-4738-9211-67fefcb7c95a"),
                            fAccount = new Guid("756af63b-f858-402d-afa4-6b31ef8559c5"),
                            fProduct = new Guid("318661b2-b65a-4555-82cf-18229934f26d")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
