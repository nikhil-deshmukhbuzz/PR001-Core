﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.BL;

namespace Portal.Migrations
{
    [DbContext(typeof(DB001Core))]
    [Migration("20181028061208_locationchanges")]
    partial class locationchanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portal.Models.CityMaster", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<long>("DistrictID");

                    b.HasKey("CityID");

                    b.HasIndex("DistrictID");

                    b.ToTable("CityMasters");
                });

            modelBuilder.Entity("Portal.Models.DeviceMaster", b =>
                {
                    b.Property<long>("DeviceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceName");

                    b.Property<string>("HardwareType");

                    b.Property<int>("Stock");

                    b.HasKey("DeviceID");

                    b.ToTable("DeviceMasters");
                });

            modelBuilder.Entity("Portal.Models.DistrictMaster", b =>
                {
                    b.Property<long>("DistrictID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName");

                    b.Property<long>("StateID");

                    b.HasKey("DistrictID");

                    b.HasIndex("StateID");

                    b.ToTable("DistrictMasters");
                });

            modelBuilder.Entity("Portal.Models.HardwareMaster", b =>
                {
                    b.Property<long>("HardwareID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HardwareName");

                    b.HasKey("HardwareID");

                    b.ToTable("HardwareMasters");
                });

            modelBuilder.Entity("Portal.Models.InventoryMaster", b =>
                {
                    b.Property<long>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("DeviceID");

                    b.Property<string>("InventoryName");

                    b.Property<string>("InventoryType");

                    b.Property<string>("ReferenceNumber");

                    b.Property<long?>("SpareID");

                    b.Property<DateTime?>("WarrantyDate");

                    b.HasKey("InventoryID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("SpareID");

                    b.ToTable("InventoryMasters");
                });

            modelBuilder.Entity("Portal.Models.SpareMaster", b =>
                {
                    b.Property<long>("SpareID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SpareName");

                    b.Property<int>("Stock");

                    b.HasKey("SpareID");

                    b.ToTable("SpareMasters");
                });

            modelBuilder.Entity("Portal.Models.StateMaster", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateName");

                    b.HasKey("StateID");

                    b.ToTable("StateMasters");
                });

            modelBuilder.Entity("Portal.Models.CityMaster", b =>
                {
                    b.HasOne("Portal.Models.DistrictMaster", "DistrictMaster")
                        .WithMany()
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.DistrictMaster", b =>
                {
                    b.HasOne("Portal.Models.StateMaster", "StateMaster")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.InventoryMaster", b =>
                {
                    b.HasOne("Portal.Models.DeviceMaster", "DeviceMaster")
                        .WithMany()
                        .HasForeignKey("DeviceID");

                    b.HasOne("Portal.Models.SpareMaster", "SpareMaster")
                        .WithMany()
                        .HasForeignKey("SpareID");
                });
#pragma warning restore 612, 618
        }
    }
}
