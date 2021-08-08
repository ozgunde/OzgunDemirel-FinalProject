using Microsoft.EntityFrameworkCore.Migrations;

namespace Music.DataAccess.Migrations
{
    public partial class initialize2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Genres_GenreId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Singers_SingerId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Songs_SongId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genres_GenreID",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Albums_GenreId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_SingerId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_SongId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "SingerId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Songs",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_GenreID",
                table: "Songs",
                newName: "IX_Songs_GenreId");

            migrationBuilder.CreateTable(
                name: "AlbumSong",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    SongId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumSong", x => new { x.AlbumId, x.SongId });
                    table.ForeignKey(
                        name: "FK_AlbumSong_Albums_SongId",
                        column: x => x.SongId,
                        principalTable: "Albums",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AlbumSong_Songs_SongId1",
                        column: x => x.SongId1,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSong_SongId",
                table: "AlbumSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSong_SongId1",
                table: "AlbumSong",
                column: "SongId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genres_GenreId",
                table: "Songs",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genres_GenreId",
                table: "Songs");

            migrationBuilder.DropTable(
                name: "AlbumSong");

            migrationBuilder.DropColumn(
                name: "AlbumPoster",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Songs",
                newName: "GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                newName: "IX_Songs_GenreID");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SingerId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SongId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_SingerId",
                table: "Albums",
                column: "SingerId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_SongId",
                table: "Albums",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Genres_GenreId",
                table: "Albums",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Singers_SingerId",
                table: "Albums",
                column: "SingerId",
                principalTable: "Singers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Songs_SongId",
                table: "Albums",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genres_GenreID",
                table: "Songs",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "Id");
        }
    }
}
