﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Postgres.Api.Repository.BuildingLink;

#nullable disable

namespace Postgres.Api.Migrations
{
    [DbContext(typeof(ShiftLogDbContext))]
    [Migration("20230720232037_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SynchronizedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SynchronizedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Note", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<int>("CreatedByEmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("DeletedByEmployeeId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("EmailId")
                        .IsRequired()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsHighPriority")
                        .HasColumnType("boolean");

                    b.Property<int?>("LocationId")
                        .HasColumnType("integer");

                    b.Property<string>("Notes")
                        .HasColumnType("text")
                        .HasColumnName("Note");

                    b.Property<int?>("OccupancyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmailId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OccupancyId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Occupancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Label")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SynchronizedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<int?>("UnitId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UnitId");

                    b.ToTable("Occupancies");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsShiftLogEmailHighPriorityOnly")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsShiftLogNightlyReport")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsShiftLogSearchManagerOnly")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("SynchronizedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.ReportEmailAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("character varying(320)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("ReportEmailAddresses");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Label")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SynchronizedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Email", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Property", "Property")
                        .WithMany("Emails")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Employee", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Property", "Property")
                        .WithMany("Employees")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Location", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Property", "Property")
                        .WithMany("Locations")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Note", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Email", "Email")
                        .WithMany("Notes")
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Location", "Location")
                        .WithMany("Notes")
                        .HasForeignKey("LocationId");

                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Occupancy", "Occupancy")
                        .WithMany("Notes")
                        .HasForeignKey("OccupancyId");

                    b.Navigation("Email");

                    b.Navigation("Location");

                    b.Navigation("Occupancy");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Occupancy", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Property", "Property")
                        .WithMany("Occupancies")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Unit", "Unit")
                        .WithMany("Occupancies")
                        .HasForeignKey("UnitId");

                    b.Navigation("Property");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.ReportEmailAddress", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Property", "Property")
                        .WithMany("ReportEmailAddresses")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Unit", b =>
                {
                    b.HasOne("Postgres.Api.Repository.BuildingLink.Models.Property", "Property")
                        .WithMany("Units")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Email", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Location", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Occupancy", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Property", b =>
                {
                    b.Navigation("Emails");

                    b.Navigation("Employees");

                    b.Navigation("Locations");

                    b.Navigation("Occupancies");

                    b.Navigation("ReportEmailAddresses");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Postgres.Api.Repository.BuildingLink.Models.Unit", b =>
                {
                    b.Navigation("Occupancies");
                });
#pragma warning restore 612, 618
        }
    }
}
