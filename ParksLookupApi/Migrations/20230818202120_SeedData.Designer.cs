﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookupApi.Models;

#nullable disable

namespace ParksLookupApi.Migrations
{
    [DbContext(typeof(ParksLookupApiContext))]
    [Migration("20230818202120_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookupApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<int>("YearOfEstablishment")
                        .HasColumnType("int");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Designation = "State Park",
                            Name = "Custer State Park",
                            State = "South Dakota",
                            YearOfEstablishment = 1919
                        },
                        new
                        {
                            ParkId = 2,
                            Designation = "National Park",
                            Name = "Acadia National Park",
                            State = "Maine",
                            YearOfEstablishment = 1919
                        },
                        new
                        {
                            ParkId = 3,
                            Designation = "National Park",
                            Name = "Canyonlands National Park",
                            State = "Utah",
                            YearOfEstablishment = 1964
                        },
                        new
                        {
                            ParkId = 4,
                            Designation = "National Historical Park",
                            Name = "Valley Forge National Historical Park",
                            State = "Pennsylvania",
                            YearOfEstablishment = 1976
                        },
                        new
                        {
                            ParkId = 5,
                            Designation = "National Seashore",
                            Name = "Cape Hatteras National Seashore",
                            State = "North Carolina",
                            YearOfEstablishment = 1937
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
