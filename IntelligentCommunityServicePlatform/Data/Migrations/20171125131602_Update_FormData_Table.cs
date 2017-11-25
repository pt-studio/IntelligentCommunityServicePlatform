using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IntelligentCommunityServicePlatform.Data.Migrations
{
    public partial class Update_FormData_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormDatas_AspNetUsers_UserId",
                table: "FormDatas");

            migrationBuilder.DropIndex(
                name: "IX_FormDatas_UserId",
                table: "FormDatas");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FormDatas",
                newName: "PermanentAddress");

            migrationBuilder.RenameColumn(
                name: "ReportFor",
                table: "FormDatas",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "PermanentAddress",
                table: "FormDatas",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identity",
                table: "FormDatas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportForId",
                table: "FormDatas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identity",
                table: "FormDatas");

            migrationBuilder.DropColumn(
                name: "ReportForId",
                table: "FormDatas");

            migrationBuilder.RenameColumn(
                name: "PermanentAddress",
                table: "FormDatas",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FormDatas",
                newName: "ReportFor");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "FormDatas",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormDatas_UserId",
                table: "FormDatas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormDatas_AspNetUsers_UserId",
                table: "FormDatas",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
