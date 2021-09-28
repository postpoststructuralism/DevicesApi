using Microsoft.EntityFrameworkCore.Migrations;

namespace DevicesApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceStatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperature = table.Column<int>(type: "int", nullable: false),
                    DeviceStatusId = table.Column<int>(type: "int", nullable: false),
                    DeviceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceStatusTypes_DeviceStatusId",
                        column: x => x.DeviceStatusId,
                        principalTable: "DeviceStatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeviceRelations",
                columns: table => new
                {
                    RootDeviceId = table.Column<int>(type: "int", nullable: false),
                    RelatedDeviceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceRelations", x => new { x.RootDeviceId, x.RelatedDeviceId });
                    table.ForeignKey(
                        name: "FK_DeviceRelations_Devices_RelatedDeviceId",
                        column: x => x.RelatedDeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceRelations_Devices_RootDeviceId",
                        column: x => x.RootDeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DeviceStatusTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Offline" }
                });

            migrationBuilder.InsertData(
                table: "DeviceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mobile" },
                    { 2, "Tablet" },
                    { 3, "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceStatusId", "DeviceTypeId", "Name", "Temperature" },
                values: new object[,]
                {
                    { 1, 1, 1, "Device 1", 0 },
                    { 4, 2, 1, "Device 4", 0 },
                    { 9, 1, 1, "Device 9", 0 },
                    { 5, 1, 2, "Device 5", 0 },
                    { 7, 2, 2, "Device 7", 0 },
                    { 8, 2, 2, "Device 8", 0 },
                    { 11, 2, 2, "Device 11", 0 },
                    { 2, 2, 3, "Device 2", 0 },
                    { 3, 1, 3, "Device 3", 0 },
                    { 6, 1, 3, "Device 6", 0 },
                    { 10, 2, 3, "Device 10", 0 }
                });

            migrationBuilder.InsertData(
                table: "DeviceRelations",
                columns: new[] { "RelatedDeviceId", "RootDeviceId" },
                values: new object[,]
                {
                    { 2, 4 },
                    { 1, 6 },
                    { 4, 6 },
                    { 7, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceRelations_RelatedDeviceId",
                table: "DeviceRelations",
                column: "RelatedDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceStatusId",
                table: "Devices",
                column: "DeviceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceRelations");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "DeviceStatusTypes");

            migrationBuilder.DropTable(
                name: "DeviceTypes");
        }
    }
}
