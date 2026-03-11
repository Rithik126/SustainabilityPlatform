using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SustainabilityPlatform.Migrations
{
    /// <inheritdoc />
    public partial class Renametype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Appliances",
                newName: "ApplianceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplianceId",
                table: "Appliances",
                newName: "TypeId");
        }
    }
}
