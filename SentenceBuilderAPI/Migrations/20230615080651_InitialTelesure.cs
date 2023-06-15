using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SentenceBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialTelesure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sentences",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentences", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WordTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordTypes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Word",
                columns: new[] { "ID", "Description", "WordTypeID" },
                values: new object[,]
                {
                    { 1, "appointment", 1 },
                    { 2, "farmer", 1 },
                    { 3, "pizza", 1 },
                    { 4, "bonus", 1 },
                    { 5, "boyfriend", 1 },
                    { 6, "me", 2 },
                    { 7, "someone", 2 },
                    { 8, "whose", 2 },
                    { 9, "themselves", 2 },
                    { 10, "your", 2 },
                    { 11, "overwrought", 3 },
                    { 12, "mighty", 3 },
                    { 13, "heavenly", 3 },
                    { 14, "weary", 3 },
                    { 15, "level", 3 },
                    { 16, "permit", 4 },
                    { 17, "preserve", 4 },
                    { 18, "originate", 4 },
                    { 19, "apply", 4 },
                    { 20, "dip", 4 },
                    { 21, "hopelessly", 5 },
                    { 22, "finally", 5 },
                    { 23, "exactly", 5 },
                    { 24, "regularly", 5 },
                    { 25, "originally", 5 },
                    { 26, "without", 6 },
                    { 27, "regarding", 6 },
                    { 28, "next", 6 },
                    { 29, "under", 6 },
                    { 30, "with", 6 },
                    { 31, "if", 7 },
                    { 32, "because", 7 },
                    { 33, "while", 7 },
                    { 34, "or", 7 },
                    { 35, "and", 7 },
                    { 36, "that", 8 },
                    { 37, "this", 8 },
                    { 38, "whichever", 8 },
                    { 39, "every", 8 },
                    { 40, "all", 8 },
                    { 41, "wow!", 9 },
                    { 42, "oh joy!", 9 },
                    { 43, "I am going to faint!", 9 },
                    { 44, "no way!", 9 },
                    { 45, "for real?!", 9 }
                });

            migrationBuilder.InsertData(
                table: "WordTypes",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "Nouns" },
                    { 2, "Pronoun" },
                    { 3, "Adjectives" },
                    { 4, "Verb" },
                    { 5, "Adverbs" },
                    { 6, "Preposition" },
                    { 7, "Conjuctions" },
                    { 8, "Determiner" },
                    { 9, "Exclamaton" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sentences");

            migrationBuilder.DropTable(
                name: "Word");

            migrationBuilder.DropTable(
                name: "WordTypes");
        }
    }
}
