﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrintingHouseBackend.Data;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    [DbContext(typeof(PrintingHouseContext))]
    partial class PrintingHouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrintingHouseBackend.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "Courtesy Hardware Store",
                            Name = "Steven",
                            PhoneNumber = "7815219682",
                            Surname = "Waters"
                        },
                        new
                        {
                            Id = 2,
                            Company = "Friendly Advice",
                            Name = "Matthew",
                            PhoneNumber = "6209959419",
                            Surname = "Clark"
                        },
                        new
                        {
                            Id = 3,
                            Company = "Peaches",
                            Name = "Robert",
                            PhoneNumber = "4026489114",
                            Surname = "Phillips"
                        });
                });

            modelBuilder.Entity("PrintingHouseBackend.Models.JobDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pattern")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobsDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "SW. Courtesy Hardward Store",
                            Pattern = "swchs12"
                        },
                        new
                        {
                            Id = 2,
                            Name = "MC. Friendly Advice",
                            Pattern = "mcfa3"
                        },
                        new
                        {
                            Id = 3,
                            Name = "RP. Peaches",
                            Pattern = "rpp1"
                        });
                });

            modelBuilder.Entity("PrintingHouseBackend.Models.JobOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("JobDetailsId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("OrderDate")
                        .HasColumnType("date");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("JobDetailsId");

                    b.ToTable("JobsOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            JobDetailsId = 1,
                            OrderDate = new DateOnly(2024, 2, 12),
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            JobDetailsId = 2,
                            OrderDate = new DateOnly(2024, 6, 1),
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            JobDetailsId = 3,
                            OrderDate = new DateOnly(2023, 7, 27),
                            Status = true
                        });
                });

            modelBuilder.Entity("PrintingHouseBackend.Models.JobOrder", b =>
                {
                    b.HasOne("PrintingHouseBackend.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrintingHouseBackend.Models.JobDetails", "JobDetails")
                        .WithMany()
                        .HasForeignKey("JobDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("JobDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
