using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class association : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_passengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneId",
                table: "MyFlight");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "MyFlight");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "My Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengersPassportNumber",
                table: "My Reservation",
                newName: "IX_My Reservation_passengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_My Reservation",
                table: "My Reservation",
                columns: new[] { "FlightsFlightId", "passengersPassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK");

            migrationBuilder.AddForeignKey(
                name: "FK_My Reservation_MyFlight_FlightsFlightId",
                table: "My Reservation",
                column: "FlightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_My Reservation_Passengers_passengersPassportNumber",
                table: "My Reservation",
                column: "passengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_My Reservation_MyFlight_FlightsFlightId",
                table: "My Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_My Reservation_Passengers_passengersPassportNumber",
                table: "My Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_My Reservation",
                table: "My Reservation");

            migrationBuilder.RenameTable(
                name: "My Reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_My Reservation_passengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "passengersPassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_passengersPassportNumber",
                table: "FlightPassenger",
                column: "passengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
