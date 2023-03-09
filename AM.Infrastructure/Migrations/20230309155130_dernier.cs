using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dernier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "My Reservation");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    passanFK = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Prix = table.Column<double>(type: "float(2)", precision: 2, scale: 3, nullable: false),
                    Siege = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    PassengerPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.passanFK, x.FlightFK });
                    table.ForeignKey(
                        name: "FK_Ticket_MyFlight_FlightId",
                        column: x => x.FlightId,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passenger_PassengerPassportNumber",
                        column: x => x.PassengerPassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerPassportNumber",
                table: "Ticket",
                column: "PassengerPassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.CreateTable(
                name: "My Reservation",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    passengersPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My Reservation", x => new { x.FlightsFlightId, x.passengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_My Reservation_MyFlight_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_My Reservation_Passenger_passengersPassportNumber",
                        column: x => x.passengersPassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_My Reservation_passengersPassportNumber",
                table: "My Reservation",
                column: "passengersPassportNumber");
        }
    }
}
