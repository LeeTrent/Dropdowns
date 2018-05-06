﻿// <auto-generated />
using Dropdowns.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dropdowns.Migrations
{
    [DbContext(typeof(DropdownContext))]
    partial class DropdownContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Dropdowns.Models.Continent", b =>
                {
                    b.Property<int>("ContinentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContinentName");

                    b.HasKey("ContinentID");

                    b.ToTable("Continent");
                });

            modelBuilder.Entity("Dropdowns.Models.Corporation", b =>
                {
                    b.Property<int>("CorporationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorporationName");

                    b.Property<int?>("CountryID");

                    b.HasKey("CorporationID");

                    b.HasIndex("CountryID");

                    b.ToTable("Corporation");
                });

            modelBuilder.Entity("Dropdowns.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContinentID");

                    b.Property<string>("CountryName");

                    b.HasKey("CountryID");

                    b.HasIndex("ContinentID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Dropdowns.Models.Corporation", b =>
                {
                    b.HasOne("Dropdowns.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");
                });

            modelBuilder.Entity("Dropdowns.Models.Country", b =>
                {
                    b.HasOne("Dropdowns.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}