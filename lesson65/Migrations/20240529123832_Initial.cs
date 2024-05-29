using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lesson65.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OfficialName = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    Population = table.Column<int>(type: "integer", nullable: false),
                    Capital = table.Column<string>(type: "text", nullable: false),
                    Area = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Area", "Capital", "Name", "OfficialName", "Population", "Region" },
                values: new object[,]
                {
                    { 1, 200000, "Bishkek", "Kyrgyzstan", "The Kyrgyz Republic", 8000000, "Asia" },
                    { 2, 9833520, "Washington", "USA", "United States of America", 330000000, "North America" },
                    { 3, 17000000, "Moscow", "Russia", "Russian Federation", 150000000, "Europe and Asia" },
                    { 4, 92212, "Lisbon", "Portugal", "The Portuguese Republic", 10200000, "Europe" },
                    { 5, 9984670, "Ottawa", "Canada", "Dominion of Canada", 38000000, "Europe" },
                    { 6, 357592, "Berlin", "Germany", "Federal Republic of Germany", 83800000, "Europe" },
                    { 7, 551695, "Paris", "France", "The French Republic", 68000000, "Europe" },
                    { 8, 209331, "London", "Great Britain", "The United Kingdom of Great Britain and Northern Ireland", 67000000, "Europe" },
                    { 9, 41285, "Bern", "Switzerland", "Swiss Confederation", 8700000, "Europe" },
                    { 10, 385207, "Oslo", "Norway", "The Kingdom of Norway", 5500000, "Europe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
