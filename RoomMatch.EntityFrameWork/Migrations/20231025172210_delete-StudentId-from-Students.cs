using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomMatch.EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class deleteStudentIdfromStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
