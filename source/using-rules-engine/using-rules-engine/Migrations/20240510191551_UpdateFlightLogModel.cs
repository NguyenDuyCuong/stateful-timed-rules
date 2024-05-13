using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace using_rules_engine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFlightLogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FlightLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FlightLogs_UserId",
                table: "FlightLogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightLogs_Users_UserId",
                table: "FlightLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightLogs_Users_UserId",
                table: "FlightLogs");

            migrationBuilder.DropIndex(
                name: "IX_FlightLogs_UserId",
                table: "FlightLogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlightLogs");
        }
    }
}
