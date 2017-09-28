using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace match.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BodyType = table.Column<int>(nullable: false),
                    Drink = table.Column<int>(nullable: false),
                    Ethnicity = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Kid = table.Column<int>(nullable: false),
                    Relationship = table.Column<int>(nullable: false),
                    Religion = table.Column<int>(nullable: false),
                    Smoke = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preferences");
        }
    }
}
