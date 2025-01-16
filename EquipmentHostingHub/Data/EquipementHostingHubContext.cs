using EquipmentHostingHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentHostingHub.Data
{
	public class EquipementHostingHubContext : DbContext
	{
		public EquipementHostingHubContext(DbContextOptions<EquipementHostingHubContext> options) : base(options)
		{

		}

		public DbSet<EquipementContract> EquipementContracts { get; set; }
		public DbSet<ProcessEquipement> ProcessEquipements { get; set; }
		public DbSet<ProductionFacility> ProductionFacilities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ProductionFacility>().HasData(new ProductionFacility
			{
				ID = 1,
				Code = "GFM",
				Name = "Greenfield Manufacturing Plant",
				Area = 5000
			},
			new ProductionFacility
			{
				ID = 2,
				Code = "SIC",
				Name = "Sunrise Industrial Complex",
				Area = 8000
			},
			new ProductionFacility
			{
				ID = 3,
				Code = "BRF",
				Name = "Blue River Production Facality",
				Area = 3000
			},
			new ProductionFacility
			{
				ID = 4,
				Code = "NMH",
				Name = "Northfield Machinery Hub",
				Area = 4500
			},
			new ProductionFacility
			{
				ID = 5,
				Code = "EIE",
				Name = "EcoWorks Industrial Estate",
				Area = 6000
			},
			new ProductionFacility
			{
				ID = 6,
				Code = "CTW",
				Name = "Central Tech Works",
				Area = 7000
			},
			new ProductionFacility
			{
				ID = 7,
				Code = "SFF",
				Name = "SteelForge Foundry",
				Area = 4000
			},
			new ProductionFacility
			{
				ID = 8,
				Code = "QMF",
				Name = "Quantum Manufacturing Facality",
				Area = 7500
			},
			new ProductionFacility
			{
				ID = 9,
				Code = "PPH",
				Name = "Pinnacle Production House",
				Area = 5500
			},
			new ProductionFacility
			{
				ID = 10,
				Code = "ATH",
				Name = "AlphaTech Industrial House",
				Area = 6500
			});

			modelBuilder.Entity<ProcessEquipement>().HasData(
				new ProcessEquipement
				{
					ID = 1,
					Code = "MIX",
					Name = "Industral Mixer",
					Area = 25
				},
				new ProcessEquipement
				{
					ID = 2,
					Code = "HPR",
					Name = "Hydraulic Press",
					Area = 15
				},
				new ProcessEquipement
				{
					ID = 3,
					Code = "CNC",
					Name = "CNC Milling Machine",
					Area = 20
				},
				new ProcessEquipement
				{
					ID = 4,
					Code = "IMM",
					Name = "Injection Molding Machine",
					Area = 35
				},
				new ProcessEquipement
				{
					ID = 5,
					Code = "LCM",
					Name = "Lase Cutting Machine",
					Area = 30
				},
				new ProcessEquipement
				{
					ID = 6,
					Code = "PRN",
					Name = "3D Printer (Industrial Size)",
					Area = 12
				},
				new ProcessEquipement
				{
					ID = 7,
					Code = "PKL",
					Name = "Packaging Line",
					Area = 50
				},
				new ProcessEquipement
				{
					ID = 8,
					Code = "ARM",
					Name = "Assembly Robot Arm",
					Area = 10
				},
				new ProcessEquipement
				{
					ID = 9,
					Code = "HEX",
					Name = "Heat Exchanger",
					Area = 40
				},
				new ProcessEquipement
				{
					ID = 10,
					Code = "WJC",
					Name = "Water Jet Cutter",
					Area = 25
				},
				new ProcessEquipement
				{
					ID = 11,
					Code = "GRD",
					Name = "Heavy Duty Grinder",
					Area = 18
				},
				new ProcessEquipement
				{
					ID = 12,
					Code = "RDR",
					Name = "Rotary Dryer",
					Area = 30
				},
				new ProcessEquipement
				{
					ID = 13,
					Code = "COT",
					Name = "Cooling Tower",
					Area = 60
				},
				new ProcessEquipement
				{
					ID = 14,
					Code = "ENF",
					Name = "Electric Furnace",
					Area = 45
				},
				new ProcessEquipement
				{
					ID = 15,
					Code = "CBS",
					Name = "Conveyor Belt System",
					Area = 55
				},
				new ProcessEquipement
				{
					ID = 16,
					Code = "PNP",
					Name = "Pneumatic Press",
					Area = 20
				},
				new ProcessEquipement
				{
					ID = 17,
					Code = "ISW",
					Name = "Industrial Saw",
					Area = 10
				},
				new ProcessEquipement
				{
					ID = 18,
					Code = "VPM",
					Name = "Vacuum Pump",
					Area = 8
				},
				new ProcessEquipement
				{
					ID = 19,
					Code = "ACP",
					Name = "Air Compressor",
					Area = 12
				},
				new ProcessEquipement
				{
					ID = 20,
					Code = "SHR",
					Name = "Shredder (Industrial Size)",
					Area = 35
				},
				new ProcessEquipement
				{
					ID = 21,
					Code = "MTK",
					Name = "Mixing Tank",
					Area = 22
				},
				new ProcessEquipement
				{
					ID = 22,
					Code = "EXM",
					Name = "Extrusion Machine",
					Area = 28
				},
				new ProcessEquipement
				{
					ID = 23,
					Code = "CRM",
					Name = "Crushing Machine",
					Area = 38
				},
				new ProcessEquipement
				{
					ID = 24,
					Code = "BLS",
					Name = "Blending System",
					Area = 32
				},
				new ProcessEquipement
				{
					ID = 25,
					Code = "PSB",
					Name = "Paint Spraying Booth",
					Area = 50
				});
		}
	}
}
