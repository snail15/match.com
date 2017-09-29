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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    birthday = table.Column<DateTime>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Userdetails",
                columns: table => new
                {
                    UserdetailId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: false),
                    city = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    givenname = table.Column<string>(nullable: true),
                    middleinitial = table.Column<string>(nullable: true),
                    nameset = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    streetaddress = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false),
                    zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userdetails", x => x.UserdetailId);
                });

            migrationBuilder.CreateTable(
                name: "Userprofiles",
                columns: table => new
                {
                    UserprofileId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Relationship = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserdetailId = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: true),
                    biodetail = table.Column<string>(nullable: true),
                    bodytype = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    drink = table.Column<string>(nullable: true),
                    height = table.Column<string>(nullable: true),
                    kid = table.Column<string>(nullable: true),
                    profilepic = table.Column<string>(nullable: true),
                    salary = table.Column<int>(nullable: true),
                    smoke = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userprofiles", x => x.UserprofileId);
                });

            migrationBuilder.CreateTable(
                name: "Userpayments",
                columns: table => new
                {
                    UserpaymentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CVV2 = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ccexpires = table.Column<string>(nullable: true),
                    ccnumber = table.Column<string>(nullable: true),
                    cctype = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userpayments", x => x.UserpaymentId);
                    table.ForeignKey(
                        name: "FK_Userpayments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userpreferences",
                columns: table => new
                {
                    UserpreferenceId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MaxAge = table.Column<int>(nullable: true),
                    MinAge = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserdetailId = table.Column<int>(nullable: false),
                    UserprofileId = table.Column<int>(nullable: false),
                    bodytypepref = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    distance = table.Column<int>(nullable: true),
                    drinkpref = table.Column<string>(nullable: true),
                    genderpref = table.Column<string>(nullable: true),
                    heightpref = table.Column<string>(nullable: true),
                    salarypref = table.Column<int>(nullable: true),
                    smokepref = table.Column<int>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userpreferences", x => x.UserpreferenceId);
                    table.ForeignKey(
                        name: "FK_Userpreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userpreferences_Userdetails_UserdetailId",
                        column: x => x.UserdetailId,
                        principalTable: "Userdetails",
                        principalColumn: "UserdetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userpreferences_Userprofiles_UserprofileId",
                        column: x => x.UserprofileId,
                        principalTable: "Userprofiles",
                        principalColumn: "UserprofileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userbioactivities",
                columns: table => new
                {
                    UserbioactivityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: false),
                    UserdetailId = table.Column<int>(nullable: false),
                    UserpreferenceId = table.Column<int>(nullable: false),
                    UserprofileId = table.Column<int>(nullable: false),
                    aboutme = table.Column<string>(nullable: true),
                    beach = table.Column<bool>(nullable: false),
                    cooking = table.Column<bool>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    hiking = table.Column<bool>(nullable: false),
                    movies = table.Column<bool>(nullable: false),
                    reading = table.Column<bool>(nullable: false),
                    romance = table.Column<bool>(nullable: false),
                    sports = table.Column<bool>(nullable: false),
                    travelling = table.Column<bool>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userbioactivities", x => x.UserbioactivityId);
                    table.ForeignKey(
                        name: "FK_Userbioactivities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userbioactivities_Userdetails_UserdetailId",
                        column: x => x.UserdetailId,
                        principalTable: "Userdetails",
                        principalColumn: "UserdetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userbioactivities_Userpreferences_UserpreferenceId",
                        column: x => x.UserpreferenceId,
                        principalTable: "Userpreferences",
                        principalColumn: "UserpreferenceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userbioactivities_Userprofiles_UserprofileId",
                        column: x => x.UserprofileId,
                        principalTable: "Userprofiles",
                        principalColumn: "UserprofileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Userbioactivities_UserId",
                table: "Userbioactivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Userbioactivities_UserdetailId",
                table: "Userbioactivities",
                column: "UserdetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Userbioactivities_UserpreferenceId",
                table: "Userbioactivities",
                column: "UserpreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Userbioactivities_UserprofileId",
                table: "Userbioactivities",
                column: "UserprofileId");

            migrationBuilder.CreateIndex(
                name: "IX_Userpayments_UserId",
                table: "Userpayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Userpreferences_UserId",
                table: "Userpreferences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Userpreferences_UserdetailId",
                table: "Userpreferences",
                column: "UserdetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Userpreferences_UserprofileId",
                table: "Userpreferences",
                column: "UserprofileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Userbioactivities");

            migrationBuilder.DropTable(
                name: "Userpayments");

            migrationBuilder.DropTable(
                name: "Userpreferences");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Userdetails");

            migrationBuilder.DropTable(
                name: "Userprofiles");
        }
    }
}
