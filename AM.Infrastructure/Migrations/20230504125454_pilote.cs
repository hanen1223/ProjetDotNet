using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class pilote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pilote",
                table: "MyFlight",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pilote",
                table: "MyFlight");
        }
    }
}
