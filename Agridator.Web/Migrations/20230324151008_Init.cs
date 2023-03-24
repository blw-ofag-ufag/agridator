using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Agridator.Web.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CultureCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description_Fr = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Description_De = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Description_It = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CultureCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description_Fr = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Description_De = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Description_It = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantProtectionProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    WNr = table.Column<int>(type: "integer", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    ActiveSubstances = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantProtectionProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title_Fr = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Title_De = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Title_It = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsageTypes",
                columns: table => new
                {
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nutzung_Fr = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Nutzung_De = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Nutzung_It = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    ValidFromYear = table.Column<int>(type: "integer", nullable: true),
                    ValidToYear = table.Column<int>(type: "integer", nullable: true),
                    Overlaying = table.Column<int>(type: "integer", nullable: false),
                    BffQi = table.Column<int>(type: "integer", nullable: false),
                    SpezialCulture = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsageTypes", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Cultures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CatId = table.Column<int>(type: "integer", nullable: false),
                    Cultureode = table.Column<int>(type: "integer", nullable: false),
                    Description_Fr = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Description_De = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
                    Description_It = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true)
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
                name: "TypeOfWorks");

            migrationBuilder.DropTable(
                name: "UsageTypes");

            migrationBuilder.DropTable(
                name: "CultureCategories");
        }
    }
}
