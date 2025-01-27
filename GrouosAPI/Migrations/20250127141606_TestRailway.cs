using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrouosAPI.Migrations
{
    /// <inheritdoc />
    public partial class TestRailway : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatGroups_Application_appId",
                table: "ChatGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatGroups_Category_catId",
                table: "ChatGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ChatGroups_GroupId",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatGroups",
                table: "ChatGroups");

            migrationBuilder.RenameTable(
                name: "ChatGroups",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_ChatGroups_catId",
                table: "Groups",
                newName: "IX_Groups_catId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatGroups_appId",
                table: "Groups",
                newName: "IX_Groups_appId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "groupId");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Application_appId",
                table: "Groups",
                column: "appId",
                principalTable: "Application",
                principalColumn: "appId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Category_catId",
                table: "Groups",
                column: "catId",
                principalTable: "Category",
                principalColumn: "catId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Groups_GroupId",
                table: "Report",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Application_appId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Category_catId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Groups_GroupId",
                table: "Report");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "ChatGroups");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_catId",
                table: "ChatGroups",
                newName: "IX_ChatGroups_catId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_appId",
                table: "ChatGroups",
                newName: "IX_ChatGroups_appId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatGroups",
                table: "ChatGroups",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatGroups_Application_appId",
                table: "ChatGroups",
                column: "appId",
                principalTable: "Application",
                principalColumn: "appId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatGroups_Category_catId",
                table: "ChatGroups",
                column: "catId",
                principalTable: "Category",
                principalColumn: "catId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ChatGroups_GroupId",
                table: "Report",
                column: "GroupId",
                principalTable: "ChatGroups",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
