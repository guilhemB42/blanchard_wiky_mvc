using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryContext.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Auteur = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contenu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commentaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Auteur = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contenu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commentaires_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Auteur", "Contenu", "DateCreation", "DateModification", "Theme" },
                values: new object[,]
                {
                    { 1, "Alice", "Lorem Ipsum", new DateTime(2024, 1, 11, 16, 39, 49, 267, DateTimeKind.Local).AddTicks(8755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faux Texte" },
                    { 2, "Bob", "Très belle ville", new DateTime(2024, 1, 6, 16, 39, 49, 267, DateTimeKind.Local).AddTicks(8849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montpellier" },
                    { 3, "Charlie", "Coin coin", new DateTime(2023, 11, 11, 16, 39, 49, 267, DateTimeKind.Local).AddTicks(8853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canard" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaires_ArticleId",
                table: "Commentaires",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaires");

            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
