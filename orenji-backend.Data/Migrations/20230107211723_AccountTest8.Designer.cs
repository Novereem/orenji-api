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
    [Migration("20230107211723_AccountTest8")]
    partial class AccountTest8
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
                            Id = new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"),
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
                            Id = new Guid("74ef58e6-6db8-4cc9-b7cb-16f52f71796c"),
                            Company = "The Cool Company",
                            Name = "Cool Pants",
                            Price = 4.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("8b24113b-9371-4b6c-9779-1345fa7de995"),
                            Company = "The Quirky Company ",
                            Name = "Quirky Pants",
                            Price = 9.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("6682f748-1f0a-4101-99e9-af9dfbc3a1dc"),
                            Company = "The Lax Company ",
                            Name = "Lax Pants",
                            Price = 1.99,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("31947e3f-9fa4-4153-bc77-90db19014bf4"),
                            Company = "The Modest Company",
                            Name = "Modest Shirt",
                            Price = 12.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("1fa5da33-ab26-452b-89cd-539f8cacbd94"),
                            Company = "The Calm Company",
                            Name = "Calm Shirt",
                            Price = 19.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("f7fcec95-d693-43a5-9d07-9a8919383dfd"),
                            Company = "The Modest Company",
                            Name = "Timid Shirt",
                            Price = 24.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("c5666f2e-64c6-4a5a-8e14-9cb40f167ad0"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 64.989999999999995,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("c7fe63cb-48cf-4688-b0aa-461c3e900bd7"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 14.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("d9ed4d2a-b2a7-409c-b8e6-ae50935e79ef"),
                            Company = "The Jolly Company",
                            Name = "Jolly Shirt",
                            Price = 47.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("4013069d-dad4-47a4-9657-ffc33312462d"),
                            Company = "The Brave Company",
                            Name = "Brave Shirt",
                            Price = 34.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("84fc79b3-6cac-4f23-8636-de67a0f56632"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 12.99,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("02a6bd67-ffa9-4d68-8ff0-7879e98ef918"),
                            Company = "The Docile Company",
                            Name = "Docile Shirt",
                            Price = 19.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("eacc7445-85d6-47f5-ba35-1baf62f6bdfd"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 24.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("faa4d654-1a9c-40d5-9e31-9f07b83a68ee"),
                            Company = "The Timid Company",
                            Name = "Timid Shirt",
                            Price = 64.989999999999995,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("16d1c1c8-f9fd-47d7-9caa-3f9b0f4c29d5"),
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
                            Id = new Guid("aae8f0ed-c707-45ab-985c-c2ccbf5b1743"),
                            fAccount = new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"),
                            fProduct = new Guid("84fc79b3-6cac-4f23-8636-de67a0f56632")
                        },
                        new
                        {
                            Id = new Guid("26a1f235-e7aa-48cc-ac20-344b41a9f815"),
                            fAccount = new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"),
                            fProduct = new Guid("02a6bd67-ffa9-4d68-8ff0-7879e98ef918")
                        },
                        new
                        {
                            Id = new Guid("2608d59c-3c60-4829-a19a-340faa051b72"),
                            fAccount = new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"),
                            fProduct = new Guid("eacc7445-85d6-47f5-ba35-1baf62f6bdfd")
                        },
                        new
                        {
                            Id = new Guid("873edcb5-79d4-4ccd-9baa-d00bc5874b8c"),
                            fAccount = new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"),
                            fProduct = new Guid("faa4d654-1a9c-40d5-9e31-9f07b83a68ee")
                        },
                        new
                        {
                            Id = new Guid("f877463f-56ec-4802-8c20-617bf02e3cbd"),
                            fAccount = new Guid("28822352-8ca8-4e54-b933-8b9835c21ff1"),
                            fProduct = new Guid("16d1c1c8-f9fd-47d7-9caa-3f9b0f4c29d5")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}