using Microsoft.EntityFrameworkCore.Migrations;

namespace ObliDA.EntityFrameworkCore.Migrations
{
    public partial class AddForecastsToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WeatherForecasts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecasts_UserId",
                table: "WeatherForecasts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherForecasts_Users_UserId",
                table: "WeatherForecasts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherForecasts_Users_UserId",
                table: "WeatherForecasts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_WeatherForecasts_UserId",
                table: "WeatherForecasts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WeatherForecasts");
        }
    }
}
