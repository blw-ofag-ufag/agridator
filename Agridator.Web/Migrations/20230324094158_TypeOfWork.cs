using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agridator.Web.Migrations
{
    /// <inheritdoc />
    public partial class TypeOfWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title_it",
                table: "TypeOfWorks",
                newName: "Title_It");

            migrationBuilder.RenameColumn(
                name: "Title_fr",
                table: "TypeOfWorks",
                newName: "Title_Fr");

            migrationBuilder.RenameColumn(
                name: "Title_de",
                table: "TypeOfWorks",
                newName: "Title_De");

            migrationBuilder.AlterColumn<string>(
                name: "Title_It",
                table: "TypeOfWorks",
                type: "TEXT",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Title_Fr",
                table: "TypeOfWorks",
                type: "TEXT",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Title_De",
                table: "TypeOfWorks",
                type: "TEXT",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title_It",
                table: "TypeOfWorks",
                newName: "Title_it");

            migrationBuilder.RenameColumn(
                name: "Title_Fr",
                table: "TypeOfWorks",
                newName: "Title_fr");

            migrationBuilder.RenameColumn(
                name: "Title_De",
                table: "TypeOfWorks",
                newName: "Title_de");

            migrationBuilder.AlterColumn<string>(
                name: "Title_it",
                table: "TypeOfWorks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title_fr",
                table: "TypeOfWorks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title_de",
                table: "TypeOfWorks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 8000,
                oldNullable: true);
        }
    }
}
