﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SamarApp.Migrations
{
    public partial class IsAgreeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "AspNetUsers");
        }
    }
}
