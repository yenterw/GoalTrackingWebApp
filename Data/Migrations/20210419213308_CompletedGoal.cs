using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoalTrackingWebApp.Data.Migrations
{
    public partial class CompletedGoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompletedGoal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoalTitle = table.Column<string>(nullable: false),
                    GoalText = table.Column<string>(nullable: true),
                    GoalDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedGoal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedGoal");
        }
    }
}
