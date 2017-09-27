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
                    CVV2 = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    birthday = table.Column<DateTime>(nullable: false),
                    ccexpires = table.Column<string>(nullable: true),
                    ccnumber = table.Column<string>(nullable: true),
                    cctype = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    givenname = table.Column<string>(nullable: true),
                    height = table.Column<string>(nullable: true),
                    maidenname = table.Column<string>(nullable: true),
                    middleinitial = table.Column<string>(nullable: true),
                    nameset = table.Column<string>(nullable: true),
                    nationalid = table.Column<string>(nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    streetaddress = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    telephonecountrycode = table.Column<int>(nullable: false),
                    telephonenumber = table.Column<string>(nullable: true),
                    tropicalzodiac = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    weight = table.Column<string>(nullable: true),
                    zipcode = table.Column<string>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Userdetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userpayment",
                columns: table => new
                {
                    UserpaymentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CVV2 = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    birthday = table.Column<string>(nullable: true),
                    ccexpires = table.Column<string>(nullable: true),
                    ccnumber = table.Column<string>(nullable: true),
                    cctype = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    givenname = table.Column<string>(nullable: true),
                    height = table.Column<string>(nullable: true),
                    maidenname = table.Column<string>(nullable: true),
                    middleinitial = table.Column<string>(nullable: true),
                    nameset = table.Column<string>(nullable: true),
                    nationalid = table.Column<string>(nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    streetaddress = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    telephonecountrycode = table.Column<int>(nullable: false),
                    telephonenumber = table.Column<string>(nullable: true),
                    tropicalzodiac = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    weight = table.Column<string>(nullable: true),
                    zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userpayment", x => x.UserpaymentId);
                    table.ForeignKey(
                        name: "FK_Userpayment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userprofiles",
                columns: table => new
                {
                    UserprofileId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CVV2 = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserdetailId = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    birthday = table.Column<string>(nullable: true),
                    bodytype = table.Column<string>(nullable: true),
                    ccexpires = table.Column<string>(nullable: true),
                    ccnumber = table.Column<string>(nullable: true),
                    cctype = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    givenname = table.Column<string>(nullable: true),
                    height = table.Column<string>(nullable: true),
                    maidenname = table.Column<string>(nullable: true),
                    middleinitial = table.Column<string>(nullable: true),
                    nameset = table.Column<string>(nullable: true),
                    nationalid = table.Column<string>(nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    salary = table.Column<int>(nullable: true),
                    smoke = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    streetaddress = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    telephonecountrycode = table.Column<int>(nullable: false),
                    telephonenumber = table.Column<string>(nullable: true),
                    tropicalzodiac = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    weight = table.Column<string>(nullable: true),
                    zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userprofiles", x => x.UserprofileId);
                    table.ForeignKey(
                        name: "FK_Userprofiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userprofiles_Userdetails_UserdetailId",
                        column: x => x.UserdetailId,
                        principalTable: "Userdetails",
                        principalColumn: "UserdetailId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Userdetails_UserId",
                table: "Userdetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Userpayment_UserId",
                table: "Userpayment",
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

            migrationBuilder.CreateIndex(
                name: "IX_Userprofiles_UserId",
                table: "Userprofiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Userprofiles_UserdetailId",
                table: "Userprofiles",
                column: "UserdetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Userpayment");

            migrationBuilder.DropTable(
                name: "Userpreferences");

            migrationBuilder.DropTable(
                name: "Userprofiles");

            migrationBuilder.DropTable(
                name: "Userdetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
