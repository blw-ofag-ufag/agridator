using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agridator.Web.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CultureCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description_Fr = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Description_De = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Description_It = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CultureCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description_Fr = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Description_De = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Description_It = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantProtectionProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    WNr = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    ActiveSubstances = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantProtectionProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsageTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<int>(type: "INTEGER", nullable: false),
                    Nutzung_Fr = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Nutzung_De = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Nutzung_It = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    ValidFromYear = table.Column<int>(type: "INTEGER", nullable: false),
                    ValidToYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Overlaying = table.Column<int>(type: "INTEGER", nullable: false),
                    BffQi = table.Column<bool>(type: "INTEGER", nullable: false),
                    SpezialCulture = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cultures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cultureode = table.Column<int>(type: "INTEGER", nullable: false),
                    Description_Fr = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Description_De = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true),
                    Description_It = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cultures_CultureCategories_CatId",
                        column: x => x.CatId,
                        principalTable: "CultureCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cultures_CatId",
                table: "Cultures",
                column: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cultures");

            migrationBuilder.DropTable(
                name: "Fertilizers");

            migrationBuilder.DropTable(
                name: "PlantProtectionProducts");

            migrationBuilder.DropTable(
                name: "UsageTypes");

            migrationBuilder.DropTable(
                name: "CultureCategories");
        }
    }
}
