﻿// <auto-generated />
using System;
using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220613040942_reset")]
    partial class reset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Entities.Account", b =>
                {
                    b.Property<int>("AcccountID")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassWord")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Ecommerce.Entities.Category", b =>
                {
                    b.Property<int>("CateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Levels")
                        .HasColumnType("int");

                    b.Property<string>("MetaDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ordering")
                        .HasColumnType("int");

                    b.Property<int?>("Parent")
                        .HasColumnType("int");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Thumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CateID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CateID = 1,
                            CateName = "Rau Củ",
                            Description = "Rau Củ",
                            Levels = 0,
                            Ordering = 0,
                            Published = true
                        },
                        new
                        {
                            CateID = 2,
                            CateName = "Trái Cây",
                            Description = "Trái Cây",
                            Levels = 0,
                            Ordering = 0,
                            Published = true
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 511, DateTimeKind.Local).AddTicks(6644),
                            Email = "Kh1@email.com",
                            FullName = "Khách Hàng 1",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(7705),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 2,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9646),
                            Email = "Kh2@email.com",
                            FullName = "Khách Hàng 2",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9652),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 3,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9656),
                            Email = "Kh3@email.com",
                            FullName = "Khách Hàng 3",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9657),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 4,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9659),
                            Email = "Kh4@email.com",
                            FullName = "Khách Hàng 4",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9660),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 5,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9662),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 5",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9663),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 6,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9665),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 6",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9666),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 7,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9667),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 7",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9668),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 8,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9670),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 8",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9671),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 9,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9673),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 9",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9674),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 10,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9676),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 10",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9677),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 11,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9678),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 11",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9679),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 12,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9681),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 12",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9681),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 13,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9683),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 13",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9684),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 14,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9685),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 14",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9686),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 15,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9688),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 15",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9689),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 16,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9691),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 16",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9692),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 17,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9693),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 17",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9694),
                            PassWord = "123",
                            Phone = "000000000"
                        },
                        new
                        {
                            CustomerID = 18,
                            Active = false,
                            Address = "Đồng Nai",
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9695),
                            Email = "Kh5@email.com",
                            FullName = "Khách Hàng 18",
                            LastLogin = new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9696),
                            PassWord = "123",
                            Phone = "000000000"
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PaidPaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PaymentID")
                        .HasColumnType("float");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalMoney")
                        .HasColumnType("float");

                    b.Property<int?>("TransactSatatusID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TransactSatatusID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ecommerce.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("TotalMoney")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BestSellers")
                        .HasColumnType("bit");

                    b.Property<int>("CateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<bool>("HomeFlag")
                        .HasColumnType("bit");

                    b.Property<string>("MetaDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CateId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Khoai Lang",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 2,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Rau Muống",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 3,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Chanh Dây",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 4,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Bí Đỏ",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 5,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Cà Rốt",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 6,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Cà Chua",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 7,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Dưa Leo",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 8,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Bắp Mỹ",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 9,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Hành Lá",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductID = 10,
                            Active = true,
                            BestSellers = false,
                            CateId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0,
                            HomeFlag = false,
                            Price = 30000,
                            ProductName = "Su Su",
                            UnitsInStock = 10
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Description = "Administrator",
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleID = 2,
                            Description = "Nhân Viên",
                            RoleName = "Staff"
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.TransactSatatus", b =>
                {
                    b.Property<int>("TransactSatatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactSatatusID");

                    b.ToTable("TransactSatatus");
                });

            modelBuilder.Entity("Ecommerce.Entities.Account", b =>
                {
                    b.HasOne("Ecommerce.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("AcccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Ecommerce.Entities.Order", b =>
                {
                    b.HasOne("Ecommerce.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.HasOne("Ecommerce.Entities.TransactSatatus", "TransactSatatus")
                        .WithMany("Orders")
                        .HasForeignKey("TransactSatatusID");

                    b.Navigation("Customer");

                    b.Navigation("TransactSatatus");
                });

            modelBuilder.Entity("Ecommerce.Entities.OrderDetail", b =>
                {
                    b.HasOne("Ecommerce.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Ecommerce.Entities.Product", b =>
                {
                    b.HasOne("Ecommerce.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ecommerce.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Ecommerce.Entities.TransactSatatus", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
