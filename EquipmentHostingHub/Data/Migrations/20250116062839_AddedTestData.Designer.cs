﻿// <auto-generated />
using EquipmentHostingHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EquipmentHostingHub.Data.Migrations
{
	[DbContext(typeof(EquipmentHostingHubContext))]
	[Migration("20250116062839_AddedTestData")]
	partial class AddedTestData
	{
		/// <inheritdoc />
		protected override void BuildTargetModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder
				.HasAnnotation("ProductVersion", "8.0.12")
				.HasAnnotation("Relational:MaxIdentifierLength", 128);

			SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

			modelBuilder.Entity("EquipmentHostingHub.Models.EquipmentContract", b =>
				{
					b.Property<int>("ID")
						.ValueGeneratedOnAdd()
						.HasColumnType("int");

					SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

					b.Property<string>("Name")
						.IsRequired()
						.HasColumnType("nvarchar(max)");

					b.Property<int>("ProcessEquipmentID")
						.HasColumnType("int");

					b.Property<int>("ProductionFacilityID")
						.HasColumnType("int");

					b.Property<int>("Quantity")
						.HasColumnType("int");

					b.HasKey("ID");

					b.HasIndex("ProcessEquipmentID");

					b.HasIndex("ProductionFacilityID");

					b.ToTable("EquipmentContracts");
				});

			modelBuilder.Entity("EquipmentHostingHub.Models.ProcessEquipment", b =>
				{
					b.Property<int>("ID")
						.ValueGeneratedOnAdd()
						.HasColumnType("int");

					SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

					b.Property<decimal>("Area")
						.HasColumnType("decimal(18,2)");

					b.Property<string>("Code")
						.IsRequired()
						.HasColumnType("nvarchar(max)");

					b.Property<string>("Name")
						.IsRequired()
						.HasColumnType("nvarchar(max)");

					b.HasKey("ID");

					b.ToTable("ProcessEquipments");

					b.HasData(
						new
						{
							ID = 1,
							Area = 25m,
							Code = "MIX",
							Name = "Industral Mixer"
						},
						new
						{
							ID = 2,
							Area = 15m,
							Code = "HPR",
							Name = "Hydraulic Press"
						},
						new
						{
							ID = 3,
							Area = 20m,
							Code = "CNC",
							Name = "CNC Milling Machine"
						},
						new
						{
							ID = 4,
							Area = 35m,
							Code = "IMM",
							Name = "Injection Molding Machine"
						},
						new
						{
							ID = 5,
							Area = 30m,
							Code = "LCM",
							Name = "Lase Cutting Machine"
						},
						new
						{
							ID = 6,
							Area = 12m,
							Code = "PRN",
							Name = "3D Printer (Industrial Size)"
						},
						new
						{
							ID = 7,
							Area = 50m,
							Code = "PKL",
							Name = "Packaging Line"
						},
						new
						{
							ID = 8,
							Area = 10m,
							Code = "ARM",
							Name = "Assembly Robot Arm"
						},
						new
						{
							ID = 9,
							Area = 40m,
							Code = "HEX",
							Name = "Heat Exchanger"
						},
						new
						{
							ID = 10,
							Area = 25m,
							Code = "WJC",
							Name = "Water Jet Cutter"
						},
						new
						{
							ID = 11,
							Area = 18m,
							Code = "GRD",
							Name = "Heavy Duty Grinder"
						},
						new
						{
							ID = 12,
							Area = 30m,
							Code = "RDR",
							Name = "Rotary Dryer"
						},
						new
						{
							ID = 13,
							Area = 60m,
							Code = "COT",
							Name = "Cooling Tower"
						},
						new
						{
							ID = 14,
							Area = 45m,
							Code = "ENF",
							Name = "Electric Furnace"
						},
						new
						{
							ID = 15,
							Area = 55m,
							Code = "CBS",
							Name = "Conveyor Belt System"
						},
						new
						{
							ID = 16,
							Area = 20m,
							Code = "PNP",
							Name = "Pneumatic Press"
						},
						new
						{
							ID = 17,
							Area = 10m,
							Code = "ISW",
							Name = "Industrial Saw"
						},
						new
						{
							ID = 18,
							Area = 8m,
							Code = "VPM",
							Name = "Vacuum Pump"
						},
						new
						{
							ID = 19,
							Area = 12m,
							Code = "ACP",
							Name = "Air Compressor"
						},
						new
						{
							ID = 20,
							Area = 35m,
							Code = "SHR",
							Name = "Shredder (Industrial Size)"
						},
						new
						{
							ID = 21,
							Area = 22m,
							Code = "MTK",
							Name = "Mixing Tank"
						},
						new
						{
							ID = 22,
							Area = 28m,
							Code = "EXM",
							Name = "Extrusion Machine"
						},
						new
						{
							ID = 23,
							Area = 38m,
							Code = "CRM",
							Name = "Crushing Machine"
						},
						new
						{
							ID = 24,
							Area = 32m,
							Code = "BLS",
							Name = "Blending System"
						},
						new
						{
							ID = 25,
							Area = 50m,
							Code = "PSB",
							Name = "Paint Spraying Booth"
						});
				});

			modelBuilder.Entity("EquipmentHostingHub.Models.ProductionFacility", b =>
				{
					b.Property<int>("ID")
						.ValueGeneratedOnAdd()
						.HasColumnType("int");

					SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

					b.Property<decimal>("Area")
						.HasColumnType("decimal(18,2)");

					b.Property<string>("Code")
						.IsRequired()
						.HasColumnType("nvarchar(max)");

					b.Property<string>("Name")
						.IsRequired()
						.HasColumnType("nvarchar(max)");

					b.HasKey("ID");

					b.ToTable("ProductionFacilities");

					b.HasData(
						new
						{
							ID = 1,
							Area = 5000m,
							Code = "GFM",
							Name = "Greenfield Manufacturing Plant"
						},
						new
						{
							ID = 2,
							Area = 8000m,
							Code = "SIC",
							Name = "Sunrise Industrial Complex"
						},
						new
						{
							ID = 3,
							Area = 3000m,
							Code = "BRF",
							Name = "Blue River Production Facality"
						},
						new
						{
							ID = 4,
							Area = 4500m,
							Code = "NMH",
							Name = "Northfield Machinery Hub"
						},
						new
						{
							ID = 5,
							Area = 6000m,
							Code = "EIE",
							Name = "EcoWorks Industrial Estate"
						},
						new
						{
							ID = 6,
							Area = 7000m,
							Code = "CTW",
							Name = "Central Tech Works"
						},
						new
						{
							ID = 7,
							Area = 4000m,
							Code = "SFF",
							Name = "SteelForge Foundry"
						},
						new
						{
							ID = 8,
							Area = 7500m,
							Code = "QMF",
							Name = "Quantum Manufacturing Facality"
						},
						new
						{
							ID = 9,
							Area = 5500m,
							Code = "PPH",
							Name = "Pinnacle Production House"
						},
						new
						{
							ID = 10,
							Area = 6500m,
							Code = "ATH",
							Name = "AlphaTech Industrial House"
						});
				});

			modelBuilder.Entity("EquipmentHostingHub.Models.EquipmentContract", b =>
				{
					b.HasOne("EquipmentHostingHub.Models.ProcessEquipment", "ProcessEquipment")
						.WithMany()
						.HasForeignKey("ProcessEquipmentID")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.HasOne("EquipmentHostingHub.Models.ProductionFacility", "ProductionFacility")
						.WithMany()
						.HasForeignKey("ProductionFacilityID")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.Navigation("ProcessEquipment");

					b.Navigation("ProductionFacility");
				});
#pragma warning restore 612, 618
		}
	}
}
