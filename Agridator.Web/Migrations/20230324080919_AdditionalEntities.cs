using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agridator.Web.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeOfWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title_de = table.Column<string>(type: "TEXT", nullable: false),
                    Title_fr = table.Column<string>(type: "TEXT", nullable: false),
                    Title_it = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfWorks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypeOfWorks");
        }
    }
}
