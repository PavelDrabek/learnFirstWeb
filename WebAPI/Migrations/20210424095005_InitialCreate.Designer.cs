﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(DonationDBContext))]
    [Migration("20210424095005_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebAPI.Models.DCandidate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("address")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("bloodGroup")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fullName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("mobile")
                        .HasColumnType("varchar(16)");

                    b.HasKey("id");

                    b.ToTable("DCandidates");
                });
#pragma warning restore 612, 618
        }
    }
}
