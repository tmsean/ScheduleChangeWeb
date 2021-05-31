using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleChange.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCSubMessages");

            migrationBuilder.DropTable(
                name: "SC_SITATEXes");

            migrationBuilder.CreateTable(
                name: "SITATEXes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destinations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SMI = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageEnd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SITATEXes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubMessages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SITATEX_ID = table.Column<int>(type: "int", nullable: false),
                    SITATEXID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMessages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubMessages_SITATEXes_SITATEXID",
                        column: x => x.SITATEXID,
                        principalTable: "SITATEXes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubMessages_SITATEXID",
                table: "SubMessages",
                column: "SITATEXID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubMessages");

            migrationBuilder.DropTable(
                name: "SITATEXes");

            migrationBuilder.CreateTable(
                name: "SC_SITATEXes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destinations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMI = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SC_SITATEXes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SCSubMessages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCC_SITATEXID = table.Column<int>(type: "int", nullable: false),
                    SC_SITATEXID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCSubMessages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SCSubMessages_SC_SITATEXes_SC_SITATEXID",
                        column: x => x.SC_SITATEXID,
                        principalTable: "SC_SITATEXes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SCSubMessages_SC_SITATEXID",
                table: "SCSubMessages",
                column: "SC_SITATEXID");
        }
    }
}
