using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Camposadicionales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImagen",
                table: "Producto",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 12, 2, 58, 24, 242, DateTimeKind.Utc).AddTicks(1937));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImagen",
                table: "Producto");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 4, 56, 57, 871, DateTimeKind.Utc).AddTicks(2548));
        }
    }
}
