using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class PropertyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Parks",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Address", "City", "State" },
                values: new object[] { "Saddle Mountain State Park Rd, Seaside, OR, 97138", "Seaside", "Oregon" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Address", "City", "State" },
                values: new object[] { "East Historic Columbia River, Bridal Veil, OR, 97010", "Bridal Veil", "Oregon" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Address", "City", "State" },
                values: new object[] { "20024 Silver Falls Hwy SE, Sublimity, OR, 97385", "Sublimity", "Oregon" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                columns: new[] { "Address", "City", "State" },
                values: new object[] { "Wallowa Lake State Park, Joseph, OR, 97846", "Joseph", "Oregon" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                columns: new[] { "Address", "City", "State" },
                values: new object[] { "Crater Lake National Park, Rim Dr, OR, 97604", "Rim Dr", "Oregon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Parks");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Parks",
                newName: "Location");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Location",
                value: "Saddle Mountain State Park Rd, Seaside, OR, 97138");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "Location",
                value: "East Historic Columbia River, Bridal Veil, OR, 97010");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "Location",
                value: "20024 Silver Falls Hwy SE, Sublimity, OR, 97385");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "Location",
                value: "Wallowa Lake State Park, Joseph, OR, 97846");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Location",
                value: "Crater Lake National Park, Rim Dr, OR, 97604");
        }
    }
}
