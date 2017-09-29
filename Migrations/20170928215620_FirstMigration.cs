using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace match.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    messageContent = table.Column<string>(nullable: true),
                    receiverId = table.Column<int>(nullable: false),
                    senderId = table.Column<int>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Age = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    BodyType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Drink = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Ethnicity = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Kid = table.Column<int>(nullable: false),
                    MaxAge = table.Column<int>(nullable: false),
                    MinAge = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Relationship = table.Column<int>(nullable: false),
                    Religion = table.Column<int>(nullable: false),
                    Smoke = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Preferences");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
