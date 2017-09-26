using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using match.Models;

namespace match.Migrations
{
    [DbContext(typeof(MatchContext))]
    [Migration("20170926181839_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("match.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<int>("BodyType");

                    b.Property<int>("Drink");

                    b.Property<string>("Email");

                    b.Property<int>("Ethnicity");

                    b.Property<int>("Height");

                    b.Property<int>("Kid");

                    b.Property<int>("MaxAge");

                    b.Property<int>("MinAge");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("Relationship");

                    b.Property<int>("Religion");

                    b.Property<int>("Smoke");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
        }
    }
}
