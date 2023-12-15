﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PointOfSaleDataAccess;

#nullable disable

namespace PointOfSaleDataAccess.Migrations
{
    [DbContext(typeof(POSDBContext))]
    partial class POSDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PointOfSaleSystemAPI.Models.ProductEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BarcodePrefix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BarcodePrefix = "1001",
                            CreatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6909),
                            Name = "Product 1",
                            UpdatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6919)
                        },
                        new
                        {
                            Id = 2L,
                            BarcodePrefix = "1002",
                            CreatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6921),
                            Name = "Product 2",
                            UpdatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6922)
                        },
                        new
                        {
                            Id = 3L,
                            BarcodePrefix = "1003",
                            CreatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6923),
                            Name = "Product 3",
                            UpdatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6924)
                        },
                        new
                        {
                            Id = 4L,
                            BarcodePrefix = "1004",
                            CreatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6925),
                            Name = "Product 4",
                            UpdatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6926)
                        },
                        new
                        {
                            Id = 5L,
                            BarcodePrefix = "1005",
                            CreatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6927),
                            Name = "Product 5",
                            UpdatedDate = new DateTime(2023, 12, 15, 20, 38, 8, 534, DateTimeKind.Local).AddTicks(6928)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}