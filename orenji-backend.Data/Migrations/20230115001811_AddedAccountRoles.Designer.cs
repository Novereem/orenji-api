﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using orenji_backend.Data;

namespace orenji_backend.Data.Migrations
{
    [DbContext(typeof(OrenjiContext))]
    [Migration("20230115001811_AddedAccountRoles")]
    partial class AddedAccountRoles
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
                            Id = new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"),
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
                            Id = new Guid("8a07df4c-9375-49e9-bc5d-0d53bc099244"),
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
                            Id = new Guid("30b3bd96-bddf-47b5-bc23-8cb8238ae14d"),
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
                            Id = new Guid("74c914d0-c12c-44b4-b5a5-3039982bd086"),
                            AudienceType = "Male",
                            Company = "The Cool Company",
                            Name = "Cool Pants",
                            Price = 4.9900000000000002,
                            Size = "M",
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("0375b5ba-e44f-4eee-905e-bebe1be16d07"),
                            AudienceType = "Male",
                            Company = "The Quirky Company ",
                            Name = "Quirky Pants",
                            Price = 9.9900000000000002,
                            Size = "L",
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("11d912e7-fe1e-4f17-be10-4fa8b454820d"),
                            AudienceType = "Female",
                            Company = "The Lax Company ",
                            Name = "Lax Pants",
                            Price = 1.99,
                            Size = "M",
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("25f4e013-2ccb-4a5e-bff1-7ec58c1f9392"),
                            AudienceType = "Male",
                            Company = "The Modest Company",
                            Name = "Modest Shirt",
                            Price = 12.99,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("80f11f23-2b44-43f8-a177-9ef1ac75f52c"),
                            AudienceType = "Male",
                            Company = "The Calm Company",
                            Name = "Calm Shirt",
                            Price = 19.989999999999998,
                            Size = "L",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("ae6a11c8-cdaa-4783-a030-1dd62beba250"),
                            AudienceType = "Female",
                            Company = "The Modest Company",
                            Name = "Timid Shirt",
                            Price = 24.989999999999998,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("2679bd68-e563-4180-a7f3-9b1c43eb3819"),
                            AudienceType = "Female",
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 64.989999999999995,
                            Size = "S",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("5f7d25b4-f452-4015-aa08-bfd87d962f05"),
                            AudienceType = "Genderless",
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 14.99,
                            Size = "XS",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("8c2f9d2f-4c38-4ceb-a4ae-e4586fb79591"),
                            AudienceType = "Genderless",
                            Company = "The Jolly Company",
                            Name = "Jolly Shirt",
                            Price = 47.990000000000002,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("6588f607-7689-415d-8b59-7775eb3e9f6e"),
                            AudienceType = "Genderless",
                            Company = "The Brave Company",
                            Name = "Brave Shirt",
                            Price = 34.990000000000002,
                            Size = "M",
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("ce78bcd4-afb8-4af4-bb86-4d10fc7d4edd"),
                            AudienceType = "Male",
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 12.99,
                            Size = "M",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("e162e470-16d3-4b53-927b-b006c76dbd25"),
                            AudienceType = "Female",
                            Company = "The Docile Company",
                            Name = "Docile Shirt",
                            Price = 19.989999999999998,
                            Size = "M",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("edd52901-7c74-470d-8534-4ecc9f1ba12e"),
                            AudienceType = "Female",
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 24.989999999999998,
                            Size = "S",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("055471d9-f7e4-471c-a9e3-a440e8578bf0"),
                            AudienceType = "Female",
                            Company = "The Timid Company",
                            Name = "Timid Shirt",
                            Price = 64.989999999999995,
                            Size = "L",
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("711dc800-1475-4d67-adb7-d7e52544190d"),
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
                            Id = new Guid("3d1e4972-9ecf-4052-aeed-ed544fadec0b"),
                            fAccount = new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"),
                            fProduct = new Guid("ce78bcd4-afb8-4af4-bb86-4d10fc7d4edd")
                        },
                        new
                        {
                            Id = new Guid("41022a5f-4a81-4d8e-9cb4-18a83146f0f9"),
                            fAccount = new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"),
                            fProduct = new Guid("e162e470-16d3-4b53-927b-b006c76dbd25")
                        },
                        new
                        {
                            Id = new Guid("4c0cf126-5441-42a4-888d-75cca709b484"),
                            fAccount = new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"),
                            fProduct = new Guid("edd52901-7c74-470d-8534-4ecc9f1ba12e")
                        },
                        new
                        {
                            Id = new Guid("5ac16cb5-c4c6-4513-8173-556dd94e9647"),
                            fAccount = new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"),
                            fProduct = new Guid("055471d9-f7e4-471c-a9e3-a440e8578bf0")
                        },
                        new
                        {
                            Id = new Guid("6d0e1d87-3ba9-49f0-a64e-a2d00d1c9afb"),
                            fAccount = new Guid("e064cdc4-f114-4f3d-bafc-7bca99c25598"),
                            fProduct = new Guid("711dc800-1475-4d67-adb7-d7e52544190d")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
