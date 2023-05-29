﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using products_app;

#nullable disable

namespace products_app.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20230529040654_InitialProductData")]
    partial class InitialProductData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("products_app.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(4550));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(4890));

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6306e426-b354-4b8e-b868-c4fec84e073d"),
                            CreatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3650),
                            Image = "peoduct.png",
                            Name = " Producto 1",
                            Price = 10.5f,
                            Stock = 10,
                            UpdatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3680)
                        },
                        new
                        {
                            Id = new Guid("9eb3ae6f-c048-4694-98c1-282435664882"),
                            CreatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3690),
                            Image = "peoduct.png",
                            Name = " Producto 2",
                            Price = 20.5f,
                            Stock = 20,
                            UpdatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3690)
                        },
                        new
                        {
                            Id = new Guid("43638990-1f07-40c0-aaf3-3a245dd8b143"),
                            CreatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700),
                            Image = "peoduct.png",
                            Name = " Producto 3",
                            Price = 30.5f,
                            Stock = 30,
                            UpdatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700)
                        },
                        new
                        {
                            Id = new Guid("f98d5299-688f-471a-a8d4-d3b64d1bff9f"),
                            CreatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700),
                            Image = "peoduct.png",
                            Name = " Producto 4",
                            Price = 40.5f,
                            Stock = 40,
                            UpdatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700)
                        },
                        new
                        {
                            Id = new Guid("084a4e99-299b-4c2e-8361-477f509f977f"),
                            CreatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3780),
                            Image = "peoduct.png",
                            Name = " Producto 5",
                            Price = 50.5f,
                            Stock = 50,
                            UpdatedAt = new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3780)
                        });
                });

            modelBuilder.Entity("products_app.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(5580));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("StoredSalt")
                        .HasColumnType("bytea");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(5780));

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}