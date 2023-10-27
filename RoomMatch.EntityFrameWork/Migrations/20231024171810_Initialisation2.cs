using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomMatch.EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class Initialisation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomId");
        }
    }
}
