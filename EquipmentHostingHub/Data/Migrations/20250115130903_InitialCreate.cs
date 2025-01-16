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
                name: "ProcessEquipements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessEquipements", x => x.ID);
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
                name: "EquipementContracts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProcessEquipementID = table.Column<int>(type: "int", nullable: false),
                    ProductionFacilityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipementContracts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EquipementContracts_ProcessEquipements_ProcessEquipementID",
                        column: x => x.ProcessEquipementID,
                        principalTable: "ProcessEquipements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipementContracts_ProductionFacilities_ProductionFacilityID",
                        column: x => x.ProductionFacilityID,
                        principalTable: "ProductionFacilities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipementContracts_ProcessEquipementID",
                table: "EquipementContracts",
                column: "ProcessEquipementID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipementContracts_ProductionFacilityID",
                table: "EquipementContracts",
                column: "ProductionFacilityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipementContracts");

            migrationBuilder.DropTable(
                name: "ProcessEquipements");

            migrationBuilder.DropTable(
                name: "ProductionFacilities");
        }
    }
}
