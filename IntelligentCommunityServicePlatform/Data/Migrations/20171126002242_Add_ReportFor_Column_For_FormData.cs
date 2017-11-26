using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IntelligentCommunityServicePlatform.Data.Migrations
{
    public partial class Add_ReportFor_Column_For_FormData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReportFor",
                table: "FormDatas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportFor",
                table: "FormDatas");
        }
    }
}
