using Microsoft.EntityFrameworkCore.Migrations;

namespace DevicesApi.Migrations
{
    public partial class CleanupSeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.InsertData(
                table: "DeviceRelations",
                columns: new[] { "RelatedDeviceId", "RootDeviceId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 7, 11 },
                    { 3, 10 },
                    { 2, 10 },
                    { 1, 10 },
                    { 4, 9 },
                    { 10, 9 },
                    { 7, 9 },
                    { 3, 8 },
                    { 9, 8 },
                    { 11, 8 },
                    { 6, 7 },
                    { 5, 7 },
                    { 4, 7 },
                    { 9, 6 },
                    { 8, 11 },
                    { 2, 6 },
                    { 10, 5 },
                    { 7, 5 },
                    { 6, 5 },
                    { 11, 4 },
                    { 10, 4 },
                    { 9, 4 },
                    { 8, 3 },
                    { 7, 3 },
                    { 4, 3 },
                    { 10, 2 },
                    { 9, 2 },
                    { 8, 2 },
                    { 8, 1 },
                    { 7, 1 },
                    { 3, 6 },
                    { 9, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "DeviceRelations",
                keyColumns: new[] { "RelatedDeviceId", "RootDeviceId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.InsertData(
                table: "DeviceRelations",
                columns: new[] { "RelatedDeviceId", "RootDeviceId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 4, 6 },
                    { 7, 6 },
                    { 2, 4 }
                });
        }
    }
}
