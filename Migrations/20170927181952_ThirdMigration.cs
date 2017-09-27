using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace match.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV2",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "ccexpires",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "ccnumber",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "cctype",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "color",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "givenname",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "maidenname",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "middleinitial",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "nameset",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "nationalid",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "occupation",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "streetaddress",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "surname",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "telephonecountrycode",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "telephonenumber",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "tropicalzodiac",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "zipcode",
                table: "Userprofiles");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "color",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "givenname",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "height",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "maidenname",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "middleinitial",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "nameset",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "nationalid",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "occupation",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "streetaddress",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "surname",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "telephonecountrycode",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "telephonenumber",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "tropicalzodiac",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "zipcode",
                table: "Userpayments");

            migrationBuilder.DropColumn(
                name: "CVV2",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "ccexpires",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "ccnumber",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "cctype",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "color",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "height",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "maidenname",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "nationalid",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "occupation",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "telephonecountrycode",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "telephonenumber",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "tropicalzodiac",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "Userdetails");

            migrationBuilder.DropColumn(
                name: "CVV2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ccexpires",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ccnumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "cctype",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "color",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "givenname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "height",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "maidenname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "middleinitial",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "nameset",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "nationalid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "occupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "streetaddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "surname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "telephonecountrycode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "telephonenumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "tropicalzodiac",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "zipcode",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CVV2",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Userprofiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "birthday",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ccexpires",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ccnumber",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cctype",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "givenname",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maidenname",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "middleinitial",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nameset",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalid",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupation",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "streetaddress",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "surname",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "telephonecountrycode",
                table: "Userprofiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "telephonenumber",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tropicalzodiac",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zipcode",
                table: "Userprofiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Userpayments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "birthday",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "givenname",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "height",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maidenname",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "middleinitial",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nameset",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalid",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupation",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "streetaddress",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "surname",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "telephonecountrycode",
                table: "Userpayments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "telephonenumber",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tropicalzodiac",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weight",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zipcode",
                table: "Userpayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CVV2",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Userdetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "birthday",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ccexpires",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ccnumber",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cctype",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "height",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maidenname",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalid",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupation",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "telephonecountrycode",
                table: "Userdetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "telephonenumber",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tropicalzodiac",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weight",
                table: "Userdetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CVV2",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ccexpires",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ccnumber",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cctype",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "givenname",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "height",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maidenname",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "middleinitial",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nameset",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalid",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupation",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "streetaddress",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "surname",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "telephonecountrycode",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "telephonenumber",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tropicalzodiac",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weight",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zipcode",
                table: "Users",
                nullable: true);
        }
    }
}
