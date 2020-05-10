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
    [Migration("20181113145617_Dispatch_B")]
    partial class Dispatch_B
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

                    b.Property<string>("Picode");

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

            modelBuilder.Entity("Portal.Models.Company", b =>
                {
                    b.Property<long>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<string>("Logo");

                    b.Property<string>("Name");

                    b.Property<string>("RegisteredAddress");

                    b.Property<string>("WarehouseAddress");

                    b.Property<string>("Website");

                    b.HasKey("CompanyID");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("Portal.Models.DeviceMaster", b =>
                {
                    b.Property<long>("DeviceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("DeviceName");

                    b.Property<string>("HardwareType");

                    b.Property<int>("Stock");

                    b.HasKey("DeviceID");

                    b.ToTable("DeviceMasters");
                });

            modelBuilder.Entity("Portal.Models.Dispatch", b =>
                {
                    b.Property<long>("DispatchID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CityID");

                    b.Property<long>("ClientID");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DispatchDate");

                    b.Property<string>("DispatchNumber");

                    b.Property<long>("DistrictID");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDispatched");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ShippingAddress");

                    b.Property<long>("StateID");

                    b.HasKey("DispatchID");

                    b.HasIndex("CityID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DistrictID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.HasIndex("StateID");

                    b.ToTable("Dispatchs");
                });

            modelBuilder.Entity("Portal.Models.DispatchDetail", b =>
                {
                    b.Property<long>("DispatchDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DispatchID");

                    b.Property<long>("InventoryID");

                    b.HasKey("DispatchDetailID");

                    b.HasIndex("DispatchID");

                    b.HasIndex("InventoryID");

                    b.ToTable("DispatchDetails");
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

            modelBuilder.Entity("Portal.Models.Invoice", b =>
                {
                    b.Property<long>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientID");

                    b.Property<string>("ContactPerson");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DueDate");

                    b.Property<string>("InvoiceNumber");

                    b.Property<bool>("IsDraft");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<long>("OrderID");

                    b.Property<DateTime?>("PaymentDate");

                    b.Property<long?>("PaymentModeID");

                    b.Property<long>("PaymentStatusID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReferenceNumber");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("InvoiceID");

                    b.HasIndex("ClientID");

                    b.HasIndex("OrderID");

                    b.HasIndex("PaymentModeID");

                    b.HasIndex("PaymentStatusID");

                    b.HasIndex("ProductID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Portal.Models.InvoiceDetail", b =>
                {
                    b.Property<long>("InvoiceDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<long?>("InventoryID");

                    b.Property<long?>("InvoiceHeaderID");

                    b.Property<long>("InvoiceID");

                    b.HasKey("InvoiceDetailID");

                    b.HasIndex("InventoryID");

                    b.HasIndex("InvoiceHeaderID");

                    b.HasIndex("InvoiceID");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("Portal.Models.InvoiceHeader", b =>
                {
                    b.Property<long>("InvoiceHeaderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("Header");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSoftware");

                    b.Property<long?>("ProductID");

                    b.Property<int>("SequenceNo");

                    b.HasKey("InvoiceHeaderID");

                    b.HasIndex("ProductID");

                    b.ToTable("InvoiceHeaders");
                });

            modelBuilder.Entity("Portal.Models.License", b =>
                {
                    b.Property<long>("LicenseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientID");

                    b.Property<DateTime?>("LicenseDueDate");

                    b.Property<long>("ProductID");

                    b.Property<int>("TotalLicense");

                    b.HasKey("LicenseID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ProductID");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("Portal.Models.MenuMaster", b =>
                {
                    b.Property<long>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsMobile");

                    b.Property<string>("MenuName");

                    b.Property<long>("ParentMenuID");

                    b.Property<int>("SequenceNo");

                    b.Property<string>("Url");

                    b.HasKey("MenuID");

                    b.ToTable("MenuMasters");
                });

            modelBuilder.Entity("Portal.Models.MenuProfileLink", b =>
                {
                    b.Property<long>("MenuProfileLinkID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("MenuID");

                    b.Property<long>("ProfileID");

                    b.HasKey("MenuProfileLinkID");

                    b.HasIndex("MenuID");

                    b.HasIndex("ProfileID");

                    b.ToTable("MenuProfileLinks");
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

            modelBuilder.Entity("Portal.Models.PaymentMode", b =>
                {
                    b.Property<long>("PaymentModeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mode");

                    b.HasKey("PaymentModeID");

                    b.ToTable("PaymentModes");
                });

            modelBuilder.Entity("Portal.Models.PaymentStatus", b =>
                {
                    b.Property<long>("PaymentStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status");

                    b.HasKey("PaymentStatusID");

                    b.ToTable("PaymentStatuss");
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

            modelBuilder.Entity("Portal.Models.ProfileMaster", b =>
                {
                    b.Property<long>("ProfileID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProfileName");

                    b.HasKey("ProfileID");

                    b.ToTable("ProfileMasters");
                });

            modelBuilder.Entity("Portal.Models.SpareMaster", b =>
                {
                    b.Property<long>("SpareID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

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

            modelBuilder.Entity("Portal.Models.UserMaster", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ClientID");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsMobile");

                    b.Property<string>("MobileNo");

                    b.Property<string>("Name");

                    b.Property<string>("OTP");

                    b.Property<string>("Password");

                    b.Property<long>("ProfileID");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ProfileID");

                    b.ToTable("UserMasters");
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

            modelBuilder.Entity("Portal.Models.Dispatch", b =>
                {
                    b.HasOne("Portal.Models.CityMaster", "CityMaster")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ClientMaster", "ClientMaster")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.DistrictMaster", "DistrictMaster")
                        .WithMany()
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ProductMaster", "ProductMaster")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.StateMaster", "StateMaster")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.DispatchDetail", b =>
                {
                    b.HasOne("Portal.Models.Dispatch", "Dispatch")
                        .WithMany("DispatchDetails")
                        .HasForeignKey("DispatchID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.InventoryMaster", "InventoryMaster")
                        .WithMany()
                        .HasForeignKey("InventoryID")
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

            modelBuilder.Entity("Portal.Models.Invoice", b =>
                {
                    b.HasOne("Portal.Models.ClientMaster", "ClientMaster")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.PaymentMode", "PaymentMode")
                        .WithMany()
                        .HasForeignKey("PaymentModeID");

                    b.HasOne("Portal.Models.PaymentStatus", "PaymentStatus")
                        .WithMany()
                        .HasForeignKey("PaymentStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ProductMaster", "ProductMaster")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.InvoiceDetail", b =>
                {
                    b.HasOne("Portal.Models.InventoryMaster", "InventoryMaster")
                        .WithMany()
                        .HasForeignKey("InventoryID");

                    b.HasOne("Portal.Models.InvoiceHeader", "InvoiceHeader")
                        .WithMany()
                        .HasForeignKey("InvoiceHeaderID");

                    b.HasOne("Portal.Models.Invoice", "Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.InvoiceHeader", b =>
                {
                    b.HasOne("Portal.Models.ProductMaster", "ProductMaster")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("Portal.Models.License", b =>
                {
                    b.HasOne("Portal.Models.ClientMaster", "ClientMaster")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ProductMaster", "ProductMaster")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Models.MenuProfileLink", b =>
                {
                    b.HasOne("Portal.Models.MenuMaster", "MenuMaster")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.Models.ProfileMaster", "ProfileMaster")
                        .WithMany()
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("Portal.Models.UserMaster", b =>
                {
                    b.HasOne("Portal.Models.ClientMaster", "ClientMaster")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("Portal.Models.ProfileMaster", "ProfileMaster")
                        .WithMany()
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
