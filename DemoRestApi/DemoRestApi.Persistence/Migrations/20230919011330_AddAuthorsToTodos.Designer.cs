﻿// <auto-generated />
using System;
using DemoRestApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoRestApi.Persistence.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    [Migration("20230919011330_AddAuthorsToTodos")]
    partial class AddAuthorsToTodos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoRestApi.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Dinuka Bandara"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Isanka"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Dilshan"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "M Rajapaksha"
                        });
                });

            modelBuilder.Entity("DemoRestApi.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9250),
                            Description = "sample 2",
                            Due = new DateTime(2023, 9, 21, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9280),
                            Status = 1,
                            Title = "Collect letters"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290),
                            Description = "Go to suppermarket and get some vegitables",
                            Due = new DateTime(2023, 9, 20, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290),
                            Status = 0,
                            Title = "Need some vegitables"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Created = new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290),
                            Description = "Weekly Gym",
                            Due = new DateTime(2023, 9, 22, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290),
                            Status = 0,
                            Title = "Go to GYM"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            Created = new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290),
                            Description = "Profile photo update",
                            Due = new DateTime(2023, 9, 24, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290),
                            Status = 1,
                            Title = "Upwork Profile update"
                        });
                });

            modelBuilder.Entity("DemoRestApi.Models.Todo", b =>
                {
                    b.HasOne("DemoRestApi.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
