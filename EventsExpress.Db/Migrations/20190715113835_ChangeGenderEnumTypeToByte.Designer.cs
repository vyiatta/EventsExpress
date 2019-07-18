﻿// <auto-generated />
using System;
using EventsExpress.Db.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventsExpress.Db.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190715113835_ChangeGenderEnumTypeToByte")]
    partial class ChangeGenderEnumTypeToByte
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventsExpress.Db.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Comments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("EventId");

                    b.Property<string>("Text");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CityId");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("date");

                    b.Property<string>("Description");

                    b.Property<bool>("IsBlocked");

                    b.Property<Guid>("OwnerId");

                    b.Property<Guid?>("PhotoId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.EventCategory", b =>
                {
                    b.Property<Guid>("EventId");

                    b.Property<Guid>("CategoryId");

                    b.HasKey("EventId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("EventCategory");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.Property<Guid?>("ReportId");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Rate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EventId");

                    b.Property<int>("Score");

                    b.Property<Guid>("UserFromId");

                    b.Property<Guid>("UserToId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserFromId");

                    b.HasIndex("UserToId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Relationship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attitude");

                    b.Property<Guid>("UserFromId");

                    b.Property<Guid>("UserToId");

                    b.HasKey("Id");

                    b.HasIndex("UserFromId");

                    b.HasIndex("UserToId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("EventId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<byte>("Gender");

                    b.Property<bool>("IsBlocked");

                    b.Property<string>("Name");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone");

                    b.Property<Guid?>("PhotoId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.UserCategory", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("CategoryId");

                    b.HasKey("UserId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("UserCategory");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.UserEvent", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("EventId");

                    b.Property<int>("Status");

                    b.HasKey("UserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("UserEvent");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.City", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Comments", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsExpress.Db.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Event", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsExpress.Db.Entities.User", "Owner")
                        .WithMany("Events")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EventsExpress.Db.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.EventCategory", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsExpress.Db.Entities.Event", "Event")
                        .WithMany("Categories")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Photo", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Report")
                        .WithMany("Photos")
                        .HasForeignKey("ReportId");
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Rate", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Event", "Event")
                        .WithMany("Rates")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EventsExpress.Db.Entities.User", "UserFrom")
                        .WithMany("Rates")
                        .HasForeignKey("UserFromId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EventsExpress.Db.Entities.User", "UserTo")
                        .WithMany("MyRates")
                        .HasForeignKey("UserToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Relationship", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.User", "UserFrom")
                        .WithMany("Relationships")
                        .HasForeignKey("UserFromId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EventsExpress.Db.Entities.User", "UserTo")
                        .WithMany()
                        .HasForeignKey("UserToId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.Report", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.User", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.HasOne("EventsExpress.Db.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.UserCategory", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Category", "Category")
                        .WithMany("Users")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsExpress.Db.Entities.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsExpress.Db.Entities.UserEvent", b =>
                {
                    b.HasOne("EventsExpress.Db.Entities.Event", "Event")
                        .WithMany("Visitors")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsExpress.Db.Entities.User", "User")
                        .WithMany("EventsToVisit")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
