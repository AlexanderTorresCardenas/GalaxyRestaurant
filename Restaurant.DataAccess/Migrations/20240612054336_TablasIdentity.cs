﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TablasIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "Categoria",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "DATE", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2024, 6, 12, 5, 43, 35, 402, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "Categoria");

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
    }
}
