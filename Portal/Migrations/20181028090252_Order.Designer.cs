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
    [Migration("20181028090252_Order")]
    partial class Order
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

            modelBuilder.Entity("Portal.Models.ClientMaster", b =>
                {
                    b.Property<long>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<long>("CityID");

                    b.Property<string>("ClientCode");

                    b.Property<string>("ClientName");

                    b.Property<string>("ContactPerson");

                    b.Property<long>("DistrictID");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("MobileNo");

                    b.Property<long>("StateID");

                    b.HasKey("ClientID");

                    b.HasIndex("CityID");

                    b.HasIndex("DistrictID");

                    b.HasIndex("StateID");

                    b.ToTable("ClientMasters");
                });

            modelBuilder.Entity("Portal.Models.ClientType", b =>
                {
                    b.Property<long>("ClientTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientTypeName");

                    b.Property<long>("ProductID");

                    b.HasKey("ClientTypeID");

                    b.HasIndex("ProductID");

                    b.ToTable("ClientTypes");
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

            modelBuilder.Entity("Portal.Models.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientID");

                    b.Property<long>("ClientTypeID");

                    b.Property<DateTime?>("DeadlineDate");

                    b.Property<int>("HardwareQauntity");

                    b.Property<DateTime?>("OrderDate");

                    b.Property<string>("OrderNumber");

                    b.Property<long>("OrderStatusID");

                    b.Property<long>("ProductID");

                    b.HasKey("OrderID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ClientTypeID");

                    b.HasIndex("OrderStatusID");

                    b.HasIndex("ProductID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Portal.Models.OrderStatus", b =>
                {
                    b.Property<long>("OrderStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status");

                    b.HasKey("OrderStatusID");

                    b.ToTable("OrderStatuss");
                });

            modelBuilder.Entity("Portal.Models.ProductMaster", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HostedSubUrl");

                    b.Property<string>("HostedUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ProductCode");

                    b.Property<string>("ProductName");

                    b.HasKey("ProductID");

                    b.ToTable("ProductMasters");
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

            modelBuilder.Entity("Portal.Models.ClientMaster", b =>
                {
                    b.HasOne("Portal.Models.CityMaster", "CityMaster")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.DistrictMaster", "DistrictMaster")
                        .WithMany()
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.StateMaster", "StateMaster")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.ClientType", b =>
                {
                    b.HasOne("Portal.Models.ProductMaster", "ProductMaster")
                        .WithMany()
                        .HasForeignKey("ProductID")
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

            modelBuilder.Entity("Portal.Models.Order", b =>
                {
                    b.HasOne("Portal.Models.ClientMaster", "ClientMaster")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ClientType", "ClientType")
                        .WithMany()
                        .HasForeignKey("ClientTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ProductMaster", "ProductMaster")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
