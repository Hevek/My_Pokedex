using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poke.Migrations
{
    public partial class pokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokémons",
                table: "Pokémons");

            migrationBuilder.RenameTable(
                name: "Pokémons",
                newName: "Pokemons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "IdP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.RenameTable(
                name: "Pokemons",
                newName: "Pokémons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokémons",
                table: "Pokémons",
                column: "IdP");
        }
    }
}
