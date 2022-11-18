using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    public partial class InitialCreateLocal3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Movie_CategoriaId",
                table: "Movie",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Categoria_CategoriaId",
                table: "Movie",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Categoria_CategoriaId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CategoriaId",
                table: "Movie");
        }
    }
}
