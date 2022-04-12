using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poke.Migrations
{
    public partial class att2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trainers",
                newName: "IdT");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Trainers",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Trainers");

            migrationBuilder.RenameColumn(
                name: "IdT",
                table: "Trainers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);
        }
    }
}
