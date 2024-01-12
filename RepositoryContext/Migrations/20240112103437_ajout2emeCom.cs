using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryContext.Migrations
{
    /// <inheritdoc />
    public partial class ajout2emeCom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 1, 12, 11, 34, 36, 588, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 1, 7, 11, 34, 36, 588, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2023, 11, 12, 11, 34, 36, 588, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Commentaires",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 1, 12, 11, 34, 36, 588, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.InsertData(
                table: "Commentaires",
                columns: new[] { "Id", "ArticleId", "Auteur", "Contenu", "DateCreation", "DateModification" },
                values: new object[] { 2, 1, "Eve", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", new DateTime(2024, 1, 12, 11, 34, 36, 588, DateTimeKind.Local).AddTicks(7951), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Commentaires",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Commentaires",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 1, 11, 22, 26, 58, 253, DateTimeKind.Local).AddTicks(5744));
        }
    }
}
