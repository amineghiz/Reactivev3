using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.RenameColumn(
                name: "TVARate",
                table: "Drinks",
                newName: "VTA");

            migrationBuilder.RenameColumn(
                name: "PersonDescription",
                table: "Drinks",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Entitled",
                table: "Drinks",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "Alcohol",
                table: "Drinks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surface = table.Column<string>(type: "TEXT", nullable: true),
                    Reunion = table.Column<string>(type: "TEXT", nullable: true),
                    TableInU = table.Column<string>(type: "TEXT", nullable: true),
                    SchoolRank = table.Column<string>(type: "TEXT", nullable: true),
                    Conference = table.Column<string>(type: "TEXT", nullable: true),
                    Cabaret = table.Column<string>(type: "TEXT", nullable: true),
                    Banquet = table.Column<string>(type: "TEXT", nullable: true),
                    Showroom = table.Column<string>(type: "TEXT", nullable: true),
                    vide = table.Column<string>(type: "TEXT", nullable: true),
                    Cocktail = table.Column<string>(type: "TEXT", nullable: true),
                    DayLight = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerDay = table.Column<string>(type: "TEXT", nullable: true),
                    PriceHalfDay = table.Column<string>(type: "TEXT", nullable: true),
                    NoHalfDay = table.Column<bool>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    OnlyForSeminar = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerPerson = table.Column<string>(type: "TEXT", nullable: true),
                    VAT = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropColumn(
                name: "Alcohol",
                table: "Drinks");

            migrationBuilder.RenameColumn(
                name: "VTA",
                table: "Drinks",
                newName: "TVARate");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Drinks",
                newName: "PersonDescription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Drinks",
                newName: "Entitled");

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Entitled = table.Column<string>(type: "TEXT", nullable: true),
                    PersonDescription = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerPerson = table.Column<string>(type: "TEXT", nullable: true),
                    TVARate = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });
        }
    }
}
