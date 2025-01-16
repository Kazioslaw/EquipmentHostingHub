using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EquipmentHostingHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ProductionFacilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ProcessEquipements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ProcessEquipements",
                columns: new[] { "ID", "Area", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 25m, "MIX", "Industral Mixer" },
                    { 2, 15m, "HPR", "Hydraulic Press" },
                    { 3, 20m, "CNC", "CNC Milling Machine" },
                    { 4, 35m, "IMM", "Injection Molding Machine" },
                    { 5, 30m, "LCM", "Lase Cutting Machine" },
                    { 6, 12m, "PRN", "3D Printer (Industrial Size)" },
                    { 7, 50m, "PKL", "Packaging Line" },
                    { 8, 10m, "ARM", "Assembly Robot Arm" },
                    { 9, 40m, "HEX", "Heat Exchanger" },
                    { 10, 25m, "WJC", "Water Jet Cutter" },
                    { 11, 18m, "GRD", "Heavy Duty Grinder" },
                    { 12, 30m, "RDR", "Rotary Dryer" },
                    { 13, 60m, "COT", "Cooling Tower" },
                    { 14, 45m, "ENF", "Electric Furnace" },
                    { 15, 55m, "CBS", "Conveyor Belt System" },
                    { 16, 20m, "PNP", "Pneumatic Press" },
                    { 17, 10m, "ISW", "Industrial Saw" },
                    { 18, 8m, "VPM", "Vacuum Pump" },
                    { 19, 12m, "ACP", "Air Compressor" },
                    { 20, 35m, "SHR", "Shredder (Industrial Size)" },
                    { 21, 22m, "MTK", "Mixing Tank" },
                    { 22, 28m, "EXM", "Extrusion Machine" },
                    { 23, 38m, "CRM", "Crushing Machine" },
                    { 24, 32m, "BLS", "Blending System" },
                    { 25, 50m, "PSB", "Paint Spraying Booth" }
                });

            migrationBuilder.InsertData(
                table: "ProductionFacilities",
                columns: new[] { "ID", "Area", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 5000m, "GFM", "Greenfield Manufacturing Plant" },
                    { 2, 8000m, "SIC", "Sunrise Industrial Complex" },
                    { 3, 3000m, "BRF", "Blue River Production Facality" },
                    { 4, 4500m, "NMH", "Northfield Machinery Hub" },
                    { 5, 6000m, "EIE", "EcoWorks Industrial Estate" },
                    { 6, 7000m, "CTW", "Central Tech Works" },
                    { 7, 4000m, "SFF", "SteelForge Foundry" },
                    { 8, 7500m, "QMF", "Quantum Manufacturing Facality" },
                    { 9, 5500m, "PPH", "Pinnacle Production House" },
                    { 10, 6500m, "ATH", "AlphaTech Industrial House" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProcessEquipements",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ProductionFacilities");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ProcessEquipements");
        }
    }
}
