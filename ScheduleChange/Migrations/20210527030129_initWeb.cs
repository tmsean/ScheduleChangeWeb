using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleChange.Migrations
{
    public partial class initWeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SCCRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Airline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OffPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OffTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    DayChangeIndicator = table.Column<int>(type: "int", nullable: false),
                    EquipType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipConfig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overbooking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtectionPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIPNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCCRequests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCCRequests");
        }
    }
}
