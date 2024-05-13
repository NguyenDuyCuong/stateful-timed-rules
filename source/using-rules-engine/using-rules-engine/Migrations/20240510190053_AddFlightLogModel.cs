using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace using_rules_engine.Migrations
{
    /// <inheritdoc />
    public partial class AddFlightLogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightNumber = table.Column<string>(type: "TEXT", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Augmented = table.Column<bool>(type: "INTEGER", nullable: false),
                    TakeOff = table.Column<bool>(type: "INTEGER", nullable: false),
                    Landing = table.Column<bool>(type: "INTEGER", nullable: false),
                    TakeOffLocation = table.Column<string>(type: "TEXT", nullable: true),
                    LandingLocation = table.Column<string>(type: "TEXT", nullable: true),
                    FlightHours = table.Column<int>(type: "INTEGER", nullable: false),
                    RightSeat = table.Column<bool>(type: "INTEGER", nullable: false),
                    ETOPS = table.Column<bool>(type: "INTEGER", nullable: false),
                    Rank = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    Training = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightLogs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightLogs");
        }
    }
}
