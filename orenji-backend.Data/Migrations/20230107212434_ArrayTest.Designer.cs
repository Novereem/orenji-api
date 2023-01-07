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
    [Migration("20230107212434_ArrayTest")]
    partial class ArrayTest
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("da844e71-9a24-46a4-9255-0824018ba12c"),
                            Email = "a@a.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "a",
                            PhoneNumber = "11234567890",
                            Size = "M"
                        });
                });

            modelBuilder.Entity("orenji_backend.Common.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0417f3f6-f961-44c8-a38d-02de51d3ea81"),
                            Company = "The Cool Company",
                            Name = "Cool Pants",
                            Price = 4.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("ed554609-d6f3-43d4-bd93-4bf7f31a9e91"),
                            Company = "The Quirky Company ",
                            Name = "Quirky Pants",
                            Price = 9.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("77bb22a1-6236-492f-8980-c9bff122be1c"),
                            Company = "The Lax Company ",
                            Name = "Lax Pants",
                            Price = 1.99,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("7c6083f1-f4c9-4884-be65-c9247895bfe5"),
                            Company = "The Modest Company",
                            Name = "Modest Shirt",
                            Price = 12.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("a9ba4e08-4089-41f0-8951-25a26ff900df"),
                            Company = "The Calm Company",
                            Name = "Calm Shirt",
                            Price = 19.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("7ebfe328-57be-4fd5-b3dc-6ad3ac4294c8"),
                            Company = "The Modest Company",
                            Name = "Timid Shirt",
                            Price = 24.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("81003214-2f58-4675-a3a5-3e06b8ce1868"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 64.989999999999995,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("1870bf83-e8fc-43d5-8f89-712eff9a710c"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 14.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("c3a4226c-6afb-41b8-a28c-626edc7a3de8"),
                            Company = "The Jolly Company",
                            Name = "Jolly Shirt",
                            Price = 47.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("1fc935d7-b971-411a-9e25-4aee0227e2f1"),
                            Company = "The Brave Company",
                            Name = "Brave Shirt",
                            Price = 34.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("3d361dad-eed9-4fad-878e-4aac3da6326f"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 12.99,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("eeade479-8576-4c8d-8bd8-cf0b87463715"),
                            Company = "The Docile Company",
                            Name = "Docile Shirt",
                            Price = 19.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("9b1403d4-d6b3-4835-be01-c2dcfdbc88e0"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 24.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("d75746ec-240f-487b-a012-7ca70f02256b"),
                            Company = "The Timid Company",
                            Name = "Timid Shirt",
                            Price = 64.989999999999995,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("625a0778-96c0-4c4d-9a9f-3d2a7bb40bc1"),
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
                            Id = new Guid("5a1a258d-a5fa-4637-be8d-c69d4f6b55ad"),
                            fAccount = new Guid("da844e71-9a24-46a4-9255-0824018ba12c"),
                            fProduct = new Guid("3d361dad-eed9-4fad-878e-4aac3da6326f")
                        },
                        new
                        {
                            Id = new Guid("ccd06bc4-c7e2-4017-8104-1d5b1c13f788"),
                            fAccount = new Guid("da844e71-9a24-46a4-9255-0824018ba12c"),
                            fProduct = new Guid("eeade479-8576-4c8d-8bd8-cf0b87463715")
                        },
                        new
                        {
                            Id = new Guid("9daf4719-df16-4f51-88cf-ddce2ffe3885"),
                            fAccount = new Guid("da844e71-9a24-46a4-9255-0824018ba12c"),
                            fProduct = new Guid("9b1403d4-d6b3-4835-be01-c2dcfdbc88e0")
                        },
                        new
                        {
                            Id = new Guid("7f0f08b3-7734-4e80-ab82-ad301f01a477"),
                            fAccount = new Guid("da844e71-9a24-46a4-9255-0824018ba12c"),
                            fProduct = new Guid("d75746ec-240f-487b-a012-7ca70f02256b")
                        },
                        new
                        {
                            Id = new Guid("c91911a0-1b7e-4cd2-89e4-aca1e4665d10"),
                            fAccount = new Guid("da844e71-9a24-46a4-9255-0824018ba12c"),
                            fProduct = new Guid("625a0778-96c0-4c4d-9a9f-3d2a7bb40bc1")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
