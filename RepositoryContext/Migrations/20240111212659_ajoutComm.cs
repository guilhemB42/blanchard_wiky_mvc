using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryContext.Migrations
{
    /// <inheritdoc />
    public partial class ajoutComm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 1, 11, 22, 26, 58, 253, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 1, 6, 22, 26, 58, 253, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2023, 11, 11, 22, 26, 58, 253, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.InsertData(
                table: "Commentaires",
                columns: new[] { "Id", "ArticleId", "Auteur", "Contenu", "DateCreation", "DateModification" },
                values: new object[] { 1, 1, "Eve", "Non c'est faux", new DateTime(2024, 1, 11, 22, 26, 58, 253, DateTimeKind.Local).AddTicks(5744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Commentaires",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 1, 11, 16, 39, 49, 267, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 1, 6, 16, 39, 49, 267, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2023, 11, 11, 16, 39, 49, 267, DateTimeKind.Local).AddTicks(8853));
        }
    }
}
