using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using match.Models;

namespace match.Migrations
{
    [DbContext(typeof(MatchContext))]
    partial class MatchContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("match.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("birthday");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("email");

                    b.Property<string>("password");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("match.Models.Userbioactivity", b =>
                {
                    b.Property<int>("UserbioactivityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.Property<int>("UserdetailId");

                    b.Property<int>("UserpreferenceId");

                    b.Property<int>("UserprofileId");

                    b.Property<string>("aboutme");

                    b.Property<bool>("beach");

                    b.Property<bool>("cooking");

                    b.Property<DateTime>("created_at");

                    b.Property<bool>("hiking");

                    b.Property<bool>("movies");

                    b.Property<bool>("reading");

                    b.Property<bool>("romance");

                    b.Property<bool>("sports");

                    b.Property<bool>("travelling");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("UserbioactivityId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserdetailId");

                    b.HasIndex("UserpreferenceId");

                    b.HasIndex("UserprofileId");

                    b.ToTable("Userbioactivities");
                });

            modelBuilder.Entity("match.Models.Userdetail", b =>
                {
                    b.Property<int>("UserdetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.Property<string>("city");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("gender");

                    b.Property<string>("givenname");

                    b.Property<string>("middleinitial");

                    b.Property<string>("nameset");

                    b.Property<string>("state");

                    b.Property<string>("streetaddress");

                    b.Property<string>("surname");

                    b.Property<DateTime>("updated_at");

                    b.Property<string>("zipcode");

                    b.HasKey("UserdetailId");

                    b.ToTable("Userdetails");
                });

            modelBuilder.Entity("match.Models.Userpayment", b =>
                {
                    b.Property<int>("UserpaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CVV2");

                    b.Property<int>("UserId");

                    b.Property<string>("ccexpires");

                    b.Property<string>("ccnumber");

                    b.Property<string>("cctype");

                    b.Property<DateTime>("created_at");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("UserpaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Userpayments");
                });

            modelBuilder.Entity("match.Models.Userpreference", b =>
                {
                    b.Property<int>("UserpreferenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MaxAge");

                    b.Property<int?>("MinAge");

                    b.Property<int>("UserId");

                    b.Property<int>("UserdetailId");

                    b.Property<int>("UserprofileId");

                    b.Property<int?>("bodytypepref");

                    b.Property<DateTime>("created_at");

                    b.Property<int?>("distance");

                    b.Property<string>("drinkpref");

                    b.Property<string>("genderpref");

                    b.Property<string>("heightpref");

                    b.Property<int?>("salarypref");

                    b.Property<int?>("smokepref");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("UserpreferenceId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserdetailId");

                    b.HasIndex("UserprofileId");

                    b.ToTable("Userpreferences");
                });

            modelBuilder.Entity("match.Models.Userprofile", b =>
                {
                    b.Property<int>("UserprofileId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Relationship");

                    b.Property<int>("UserId");

                    b.Property<int>("UserdetailId");

                    b.Property<int?>("age");

                    b.Property<string>("biodetail");

                    b.Property<string>("bodytype");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("drink");

                    b.Property<string>("height");

                    b.Property<string>("kid");

                    b.Property<string>("profilepic");

                    b.Property<int?>("salary");

                    b.Property<string>("smoke");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("UserprofileId");

                    b.ToTable("Userprofiles");
                });

            modelBuilder.Entity("match.Models.Userbioactivity", b =>
                {
                    b.HasOne("match.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("match.Models.Userdetail", "Userdetail")
                        .WithMany()
                        .HasForeignKey("UserdetailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("match.Models.Userpreference", "Userpreference")
                        .WithMany()
                        .HasForeignKey("UserpreferenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("match.Models.Userprofile", "Userprofile")
                        .WithMany()
                        .HasForeignKey("UserprofileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("match.Models.Userpayment", b =>
                {
                    b.HasOne("match.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("match.Models.Userpreference", b =>
                {
                    b.HasOne("match.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("match.Models.Userdetail", "Userdetail")
                        .WithMany()
                        .HasForeignKey("UserdetailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("match.Models.Userprofile", "Userprofile")
                        .WithMany()
                        .HasForeignKey("UserprofileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
