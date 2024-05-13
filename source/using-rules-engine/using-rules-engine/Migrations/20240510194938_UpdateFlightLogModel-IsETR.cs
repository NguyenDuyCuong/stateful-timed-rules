using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace using_rules_engine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFlightLogModelIsETR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsETR",
                table: "FlightLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsETR",
                table: "FlightLogs");
        }
    }
}
