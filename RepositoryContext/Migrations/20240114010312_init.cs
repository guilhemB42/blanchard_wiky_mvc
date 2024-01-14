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
                    { 1, "Alice", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer eget laoreet felis, fermentum porta metus. Suspendisse a dapibus ante. Donec ex purus, sagittis dignissim elit sed, vehicula iaculis lacus. Praesent pretium porta felis. In porttitor leo metus, a tristique tortor convallis eu. Nam luctus lacus eget commodo lobortis. Vestibulum at fermentum tortor, ut volutpat arcu.\r\n\r\nPraesent dictum quam sit amet rutrum consectetur. Curabitur quam quam, mollis ac luctus eu, laoreet vel nunc. Suspendisse vel elit odio. Aenean pharetra sed nisi ut mollis. Fusce eu nisl feugiat, eleifend nisi et, rutrum nunc. Nunc volutpat ante at ligula condimentum blandit. Morbi dapibus, nunc id suscipit mattis, mauris felis blandit lacus, ac tincidunt risus ipsum id nunc. In posuere leo id lectus laoreet elementum. ", new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5392), "Lorem Ipsum" },
                    { 2, "Otis", "Vous savez, moi je ne crois pas qu’il y ait de bonne ou de mauvaise situation. Moi, si je devais résumer ma vie aujourd’hui avec vous, je dirais que c’est d’abord des rencontres. Des gens qui m’ont tendu la main, peut-être à un moment où je ne pouvais pas, où j’étais seul chez moi. Et c’est assez curieux de se dire que les hasards, les rencontres forgent une destinée… Parce que quand on a le goût de la chose, quand on a le goût de la chose bien faite, le beau geste, parfois on ne trouve pas l’interlocuteur en face je dirais, le miroir qui vous aide à avancer. Alors ça n’est pas mon cas, comme je disais là, puisque moi au contraire, j’ai pu : et je dis merci à la vie, je lui dis merci, je chante la vie, je danse la vie… je ne suis qu’amour ! Et finalement, quand beaucoup de gens aujourd’hui me disent « Mais comment fais-tu pour avoir cette humanité ? », et bien je leur réponds très simplement, je leur dis que c’est ce goût de l’amour ce goût donc qui m’a poussé aujourd’hui à entreprendre une construction mécanique, mais demain qui sait ? Peut-être simplement à me mettre au service de la communauté, à faire le don, le don de soi…", new DateTime(2024, 1, 9, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5399), new DateTime(2024, 1, 12, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5403), "Situation des scribes" },
                    { 3, "Criquette", "Le WQT est un animal aquatique nocturne", new DateTime(2023, 11, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5405), new DateTime(2023, 12, 27, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5410), "WQT" }
                });

            migrationBuilder.InsertData(
                table: "Commentaires",
                columns: new[] { "Id", "ArticleId", "Auteur", "Contenu", "DateCreation", "DateModification" },
                values: new object[,]
                {
                    { 1, 1, "Bob", "Lorem lorem", new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5417), new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5419) },
                    { 2, 2, "Asterix", "C'est une autre culture", new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5424), new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5426) },
                    { 3, 3, "Brett", "Je vous crois", new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5428), new DateTime(2024, 1, 14, 2, 3, 11, 860, DateTimeKind.Local).AddTicks(5430) }
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
