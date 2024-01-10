using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rentacar.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Todos",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Cars",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Todos",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "CarId");
        }
    }
}
