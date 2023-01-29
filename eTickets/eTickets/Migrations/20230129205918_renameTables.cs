using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class renameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinmeas_CinemaId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinmeas",
                table: "Cinmeas");

            migrationBuilder.RenameTable(
                name: "Cinmeas",
                newName: "Cinemas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Cinmeas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinmeas",
                table: "Cinmeas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinmeas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinmeas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
