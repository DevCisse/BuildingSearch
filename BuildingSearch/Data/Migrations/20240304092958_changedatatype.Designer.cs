﻿// <auto-generated />
using BuildingSearch.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuildingSearch.Data.Migrations
{
    [DbContext(typeof(SearchContext))]
    [Migration("20240304092958_changedatatype")]
    partial class changedatatype
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("BuildingSearch.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BATCH_NO")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "BATCH NO.");

                    b.Property<string>("CAD_ZONE")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "CAD ZONE");

                    b.Property<string>("DATE")
                        .HasColumnType("TEXT");

                    b.Property<string>("DATE_RETURNED")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE RETURNED");

                    b.Property<string>("DEVELOPER_S_NAME")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "DEVELOPER'S NAME");

                    b.Property<string>("FILE_NUMBER")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "FILE NUMBER");

                    b.Property<string>("ORIGINAL_FILE_LOCATION")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "ORIGINAL FILE LOCATION");

                    b.Property<long>("PLOT_NO")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "PLOT NO.");

                    b.HasKey("Id");

                    b.ToTable("Buildings");
                });
#pragma warning restore 612, 618
        }
    }
}
