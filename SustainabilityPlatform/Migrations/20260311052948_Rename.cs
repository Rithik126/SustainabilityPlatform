using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SustainabilityPlatform.Migrations
{
    /// <inheritdoc />
    public partial class Rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_Appliances_ApplianceId",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_Appliances_ApplianceTypes_ApplianceTypeId",
                table: "Appliances");

            migrationBuilder.DropForeignKey(
                name: "FK_Appliances_Homes_HomeId",
                table: "Appliances");

            migrationBuilder.DropForeignKey(
                name: "FK_EnergyUsages_Appliances_ApplianceId",
                table: "EnergyUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Users_UserId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Alerts_AlertId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_SensorData_Appliances_ApplianceId",
                table: "SensorData");

            migrationBuilder.DropForeignKey(
                name: "FK_SustainabilityScores_Homes_HomeId",
                table: "SustainabilityScores");

            migrationBuilder.DropForeignKey(
                name: "FK_WaterUsages_Appliances_ApplianceId",
                table: "WaterUsages");

            migrationBuilder.DropIndex(
                name: "IX_WaterUsages_ApplianceId",
                table: "WaterUsages");

            migrationBuilder.DropIndex(
                name: "IX_SustainabilityScores_HomeId",
                table: "SustainabilityScores");

            migrationBuilder.DropIndex(
                name: "IX_SensorData_ApplianceId",
                table: "SensorData");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_AlertId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Homes_UserId",
                table: "Homes");

            migrationBuilder.DropIndex(
                name: "IX_EnergyUsages_ApplianceId",
                table: "EnergyUsages");

            migrationBuilder.DropIndex(
                name: "IX_Appliances_ApplianceTypeId",
                table: "Appliances");

            migrationBuilder.DropIndex(
                name: "IX_Appliances_HomeId",
                table: "Appliances");

            migrationBuilder.DropIndex(
                name: "IX_Alerts_ApplianceId",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "ApplianceTypeId",
                table: "Appliances");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.AddColumn<int>(
                name: "ApplianceTypeId",
                table: "Appliances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_ApplianceId",
                table: "WaterUsages",
                column: "ApplianceId");

            migrationBuilder.CreateIndex(
                name: "IX_SustainabilityScores_HomeId",
                table: "SustainabilityScores",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorData_ApplianceId",
                table: "SensorData",
                column: "ApplianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AlertId",
                table: "Notifications",
                column: "AlertId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_UserId",
                table: "Homes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyUsages_ApplianceId",
                table: "EnergyUsages",
                column: "ApplianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appliances_ApplianceTypeId",
                table: "Appliances",
                column: "ApplianceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appliances_HomeId",
                table: "Appliances",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_ApplianceId",
                table: "Alerts",
                column: "ApplianceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_Appliances_ApplianceId",
                table: "Alerts",
                column: "ApplianceId",
                principalTable: "Appliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appliances_ApplianceTypes_ApplianceTypeId",
                table: "Appliances",
                column: "ApplianceTypeId",
                principalTable: "ApplianceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appliances_Homes_HomeId",
                table: "Appliances",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnergyUsages_Appliances_ApplianceId",
                table: "EnergyUsages",
                column: "ApplianceId",
                principalTable: "Appliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Users_UserId",
                table: "Homes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Alerts_AlertId",
                table: "Notifications",
                column: "AlertId",
                principalTable: "Alerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SensorData_Appliances_ApplianceId",
                table: "SensorData",
                column: "ApplianceId",
                principalTable: "Appliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SustainabilityScores_Homes_HomeId",
                table: "SustainabilityScores",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WaterUsages_Appliances_ApplianceId",
                table: "WaterUsages",
                column: "ApplianceId",
                principalTable: "Appliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
