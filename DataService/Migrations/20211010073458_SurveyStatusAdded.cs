﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataService.Migrations
{
    public partial class SurveyStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurveyStatus",
                table: "Responses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyStatus",
                table: "Responses");
        }
    }
}
