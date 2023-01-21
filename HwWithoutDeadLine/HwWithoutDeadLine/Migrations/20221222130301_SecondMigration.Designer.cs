﻿// <auto-generated />
using System;
using HwWithoutDeadLine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HwWithoutDeadLine.Migrations
{
    [DbContext(typeof(LogicContext))]
    [Migration("20221222130301_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HwWithoutDeadLine.Models.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("HwWithoutDeadLine.Models.SupporSpecialist", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusSpecialist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("SupporSpecialist");
                });

            modelBuilder.Entity("HwWithoutDeadLine.Models.SupportRequest", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpecialistID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SpecialistStatusID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("SpecialistID");

                    b.HasIndex("SpecialistStatusID");

                    b.ToTable("SupportRequest");
                });

            modelBuilder.Entity("HwWithoutDeadLine.Models.SupporSpecialist", b =>
                {
                    b.HasOne("HwWithoutDeadLine.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("HwWithoutDeadLine.Models.SupportRequest", b =>
                {
                    b.HasOne("HwWithoutDeadLine.Models.SupporSpecialist", "Specialist")
                        .WithMany()
                        .HasForeignKey("SpecialistID");

                    b.HasOne("HwWithoutDeadLine.Models.SupporSpecialist", "SpecialistStatus")
                        .WithMany()
                        .HasForeignKey("SpecialistStatusID");
                });
#pragma warning restore 612, 618
        }
    }
}