﻿// <auto-generated />
using System;
using ConcertCentral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConcertCentral.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181013053450_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("ConcertCentral.Models.Band", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EstablishmentDate");

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NoOfMembers");

                    b.HasKey("Id");

                    b.ToTable("Band");
                });

            modelBuilder.Entity("ConcertCentral.Models.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BandId");

                    b.Property<DateTime>("ConcertDate");

                    b.Property<int>("EventPlannerId");

                    b.Property<decimal>("MaxPrice");

                    b.Property<decimal>("MinPrice");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("ParkingAvailability");

                    b.Property<int>("SeatsAvailable");

                    b.Property<string>("Venue")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.HasIndex("EventPlannerId");

                    b.ToTable("Concert");
                });

            modelBuilder.Entity("ConcertCentral.Models.ContactUsForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ContactUsForm");
                });

            modelBuilder.Entity("ConcertCentral.Models.EventPlanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddressOne")
                        .IsRequired();

                    b.Property<string>("StreetAddressTwo");

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EventPlanner");
                });

            modelBuilder.Entity("ConcertCentral.Models.Concert", b =>
                {
                    b.HasOne("ConcertCentral.Models.Band", "Band")
                        .WithMany("Concerts")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConcertCentral.Models.EventPlanner", "EventPlanner")
                        .WithMany("Concerts")
                        .HasForeignKey("EventPlannerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
