﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class ExtendedUserClassAddcols2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_Userid",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "Photos",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_Userid",
                table: "Photos",
                newName: "IX_Photos_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Photos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Photos",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                newName: "IX_Photos_Userid");

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "Photos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_Userid",
                table: "Photos",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
