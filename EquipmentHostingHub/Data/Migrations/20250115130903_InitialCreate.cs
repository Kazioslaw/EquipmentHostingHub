using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentHostingHub.Data.Migrations
{
	/// <inheritdoc />
	public partial class InitialCreate : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "ProcessEquipments",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ProcessEquipments", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "ProductionFacilities",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ProductionFacilities", x => x.ID);
				});

			migrationBuilder.CreateTable(
				name: "EquipmentContracts",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Quantity = table.Column<int>(type: "int", nullable: false),
					ProcessEquipmentID = table.Column<int>(type: "int", nullable: false),
					ProductionFacilityID = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_EquipmentContracts", x => x.ID);
					table.ForeignKey(
						name: "FK_EquipmentContracts_ProcessEquipments_ProcessEquipmentID",
						column: x => x.ProcessEquipmentID,
						principalTable: "ProcessEquipments",
						principalColumn: "ID",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_EquipmentContracts_ProductionFacilities_ProductionFacilityID",
						column: x => x.ProductionFacilityID,
						principalTable: "ProductionFacilities",
						principalColumn: "ID",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_EquipmentContracts_ProcessEquipmentID",
				table: "EquipmentContracts",
				column: "ProcessEquipmentID");

			migrationBuilder.CreateIndex(
				name: "IX_EquipmentContracts_ProductionFacilityID",
				table: "EquipmentContracts",
				column: "ProductionFacilityID");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "EquipmentContracts");

			migrationBuilder.DropTable(
				name: "ProcessEquipments");

			migrationBuilder.DropTable(
				name: "ProductionFacilities");
		}
	}
}
