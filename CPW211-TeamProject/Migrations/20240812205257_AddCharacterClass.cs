using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_TeamProject.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rival = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DebutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComicBookDebut = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
