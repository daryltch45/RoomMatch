using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomMatch.EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class newPropertiesPasswordhashandDateJoined : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Users",
                newName: "Firstnam");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Rooms",
                newName: "Pricepublic");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoined",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateJoined",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Firstnam",
                table: "Users",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "Pricepublic",
                table: "Rooms",
                newName: "Price");
        }
    }
}
