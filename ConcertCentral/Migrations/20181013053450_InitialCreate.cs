using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConcertCentral.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Band",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    EstablishmentDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    NoOfMembers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventPlanner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    StreetAddressOne = table.Column<string>(nullable: false),
                    StreetAddressTwo = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPlanner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Concert",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Venue = table.Column<string>(nullable: false),
                    ConcertDate = table.Column<DateTime>(nullable: false),
                    ParkingAvailability = table.Column<bool>(nullable: false),
                    MinPrice = table.Column<decimal>(nullable: false),
                    MaxPrice = table.Column<decimal>(nullable: false),
                    SeatsAvailable = table.Column<int>(nullable: false),
                    BandId = table.Column<int>(nullable: false),
                    EventPlannerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concert", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Concert_Band_BandId",
                        column: x => x.BandId,
                        principalTable: "Band",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Concert_EventPlanner_EventPlannerId",
                        column: x => x.EventPlannerId,
                        principalTable: "EventPlanner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concert_BandId",
                table: "Concert",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Concert_EventPlannerId",
                table: "Concert",
                column: "EventPlannerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concert");

            migrationBuilder.DropTable(
                name: "ContactUsForm");

            migrationBuilder.DropTable(
                name: "Band");

            migrationBuilder.DropTable(
                name: "EventPlanner");
        }
    }
}
