using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using match.Models;

namespace match.Migrations
{
    [DbContext(typeof(MatchContext))]
    [Migration("20170927155411_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("match.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CVV2");

                    b.Property<int>("age");

                    b.Property<DateTime>("birthday");

                    b.Property<string>("ccexpires");

                    b.Property<string>("ccnumber");

                    b.Property<string>("cctype");

                    b.Property<string>("city");

                    b.Property<string>("color");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("email");

                    b.Property<string>("gender");

                    b.Property<string>("givenname");

                    b.Property<string>("height");

                    b.Property<string>("maidenname");

                    b.Property<string>("middleinitial");

                    b.Property<string>("nameset");

                    b.Property<string>("nationalid");

                    b.Property<string>("occupation");

                    b.Property<string>("password");

                    b.Property<string>("state");

                    b.Property<string>("streetaddress");

                    b.Property<string>("surname");

                    b.Property<int>("telephonecountrycode");

                    b.Property<string>("telephonenumber");

                    b.Property<string>("tropicalzodiac");

                    b.Property<DateTime>("updated_at");

                    b.Property<string>("username");

                    b.Property<string>("weight");

                    b.Property<string>("zipcode");

                    b.HasKey("UserId");

                    b.ToTable("Users");
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

                    b.HasIndex("UserId");

                    b.ToTable("Userdetails");
                });

            modelBuilder.Entity("match.Models.Userpayment", b =>
                {
                    b.Property<int>("UserpaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CVV2");

                    b.Property<int>("UserId");

                    b.Property<int>("age");

                    b.Property<string>("birthday");

                    b.Property<string>("ccexpires");

                    b.Property<string>("ccnumber");

                    b.Property<string>("cctype");

                    b.Property<string>("city");

                    b.Property<string>("color");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("email");

                    b.Property<string>("gender");

                    b.Property<string>("givenname");

                    b.Property<string>("height");

                    b.Property<string>("maidenname");

                    b.Property<string>("middleinitial");

                    b.Property<string>("nameset");

                    b.Property<string>("nationalid");

                    b.Property<string>("occupation");

                    b.Property<string>("password");

                    b.Property<string>("state");

                    b.Property<string>("streetaddress");

                    b.Property<string>("surname");

                    b.Property<int>("telephonecountrycode");

                    b.Property<string>("telephonenumber");

                    b.Property<string>("tropicalzodiac");

                    b.Property<DateTime>("updated_at");

                    b.Property<string>("username");

                    b.Property<string>("weight");

                    b.Property<string>("zipcode");

                    b.HasKey("UserpaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Userpayment");
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

                    b.Property<string>("CVV2");

                    b.Property<string>("Relationship");

                    b.Property<int>("UserId");

                    b.Property<int>("UserdetailId");

                    b.Property<int>("age");

                    b.Property<string>("birthday");

                    b.Property<string>("bodytype");

                    b.Property<string>("ccexpires");

                    b.Property<string>("ccnumber");

                    b.Property<string>("cctype");

                    b.Property<string>("city");

                    b.Property<string>("color");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("email");

                    b.Property<string>("gender");

                    b.Property<string>("givenname");

                    b.Property<string>("height");

                    b.Property<string>("maidenname");

                    b.Property<string>("middleinitial");

                    b.Property<string>("nameset");

                    b.Property<string>("nationalid");

                    b.Property<string>("occupation");

                    b.Property<string>("password");

                    b.Property<int?>("salary");

                    b.Property<string>("smoke");

                    b.Property<string>("state");

                    b.Property<string>("streetaddress");

                    b.Property<string>("surname");

                    b.Property<int>("telephonecountrycode");

                    b.Property<string>("telephonenumber");

                    b.Property<string>("tropicalzodiac");

                    b.Property<DateTime>("updated_at");

                    b.Property<string>("username");

                    b.Property<string>("weight");

                    b.Property<string>("zipcode");

                    b.HasKey("UserprofileId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserdetailId");

                    b.ToTable("Userprofiles");
                });

            modelBuilder.Entity("match.Models.Userdetail", b =>
                {
                    b.HasOne("match.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
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

            modelBuilder.Entity("match.Models.Userprofile", b =>
                {
                    b.HasOne("match.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("match.Models.Userdetail", "Userdetail")
                        .WithMany()
                        .HasForeignKey("UserdetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
