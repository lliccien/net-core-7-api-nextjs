using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace products_app.Migrations
{
    /// <inheritdoc />
    public partial class InitialProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(5780),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(5580),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(4890),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Image", "Name", "Price", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("084a4e99-299b-4c2e-8361-477f509f977f"), new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3780), "peoduct.png", " Producto 5", 50.5f, 50, new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3780) },
                    { new Guid("43638990-1f07-40c0-aaf3-3a245dd8b143"), new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700), "peoduct.png", " Producto 3", 30.5f, 30, new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700) },
                    { new Guid("6306e426-b354-4b8e-b868-c4fec84e073d"), new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3650), "peoduct.png", " Producto 1", 10.5f, 10, new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3680) },
                    { new Guid("9eb3ae6f-c048-4694-98c1-282435664882"), new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3690), "peoduct.png", " Producto 2", 20.5f, 20, new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3690) },
                    { new Guid("f98d5299-688f-471a-a8d4-d3b64d1bff9f"), new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700), "peoduct.png", " Producto 4", 40.5f, 40, new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(3700) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("084a4e99-299b-4c2e-8361-477f509f977f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43638990-1f07-40c0-aaf3-3a245dd8b143"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6306e426-b354-4b8e-b868-c4fec84e073d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eb3ae6f-c048-4694-98c1-282435664882"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f98d5299-688f-471a-a8d4-d3b64d1bff9f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(5490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(5290),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 28, 22, 57, 58, 445, DateTimeKind.Local).AddTicks(4260),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 5, 28, 23, 6, 54, 629, DateTimeKind.Local).AddTicks(4550));
        }
    }
}
