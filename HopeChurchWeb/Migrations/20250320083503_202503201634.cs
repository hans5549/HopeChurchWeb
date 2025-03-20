﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HopeChurchWeb.Migrations
{
    /// <inheritdoc />
    public partial class _202503201634 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortId",
                table: "ForumArticleCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortId",
                table: "ForumArticleCategories");
        }
    }
}
