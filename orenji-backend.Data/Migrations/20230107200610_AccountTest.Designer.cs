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
    [Migration("20230107200610_AccountTest")]
    partial class AccountTest
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
                            Id = new Guid("767970bf-b2e4-400d-bcf7-e3a684ed3bb8"),
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
                            Id = new Guid("33945978-4409-4ff1-af99-3903400ac38c"),
                            Company = "The Cool Company",
                            Name = "Cool Pants",
                            Price = 4.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("92ece56e-2e7f-45f3-8fe4-c12c9d52843d"),
                            Company = "The Quirky Company ",
                            Name = "Quirky Pants",
                            Price = 9.9900000000000002,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("c086e725-77bd-436b-990d-9288bbdb43b2"),
                            Company = "The Lax Company ",
                            Name = "Lax Pants",
                            Price = 1.99,
                            Type = "Pants"
                        },
                        new
                        {
                            Id = new Guid("b777e133-b9b0-414b-8ce5-c9ef1dd3fd9e"),
                            Company = "The Modest Company",
                            Name = "Modest Shirt",
                            Price = 12.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("d7c46cfa-ad9b-44b8-bc97-44812e1cadc3"),
                            Company = "The Calm Company",
                            Name = "Calm Shirt",
                            Price = 19.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("facc80fc-34fc-4a99-8963-d23d956e0897"),
                            Company = "The Modest Company",
                            Name = "Timid Shirt",
                            Price = 24.989999999999998,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("18803175-e3c8-455e-9c7a-0c36ca41dac1"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 64.989999999999995,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("dfd92be8-a94a-411d-b086-404f93167662"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 14.99,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("00e60eb0-ec59-4564-b647-613e3438ab2d"),
                            Company = "The Jolly Company",
                            Name = "Jolly Shirt",
                            Price = 47.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("dcb0d6dc-952c-4bf7-94f5-1d3b355ea0e7"),
                            Company = "The Brave Company",
                            Name = "Brave Shirt",
                            Price = 34.990000000000002,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("7552d24c-23ef-4a47-a06d-092529784a23"),
                            Company = "The Adamant Company",
                            Name = "Adamant Shirt",
                            Price = 12.99,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("d0ccfe7e-17ea-40aa-b8e2-dad7c8affc09"),
                            Company = "The Docile Company",
                            Name = "Docile Shirt",
                            Price = 19.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("9d50ddd0-d7a2-46d4-b346-6e0b1adfa385"),
                            Company = "The Lonely Company",
                            Name = "Lonely Shirt",
                            Price = 24.989999999999998,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("38d5c3a5-2116-488f-8dfb-5bb5e85a31fa"),
                            Company = "The Timid Company",
                            Name = "Timid Shirt",
                            Price = 64.989999999999995,
                            Type = "Shoe"
                        },
                        new
                        {
                            Id = new Guid("e660ef8e-4012-4b09-ab63-57697ee019bb"),
                            Company = "The Bold Company",
                            Name = "Bold Shirt",
                            Price = 14.99,
                            Type = "Shoe"
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
