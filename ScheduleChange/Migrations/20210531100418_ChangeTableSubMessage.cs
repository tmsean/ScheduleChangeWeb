using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleChange.Migrations
{
    public partial class ChangeTableSubMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMessages_SITATEXes_SITATEXID",
                table: "SubMessages");

            migrationBuilder.DropColumn(
                name: "SITATEX_ID",
                table: "SubMessages");

            migrationBuilder.AlterColumn<int>(
                name: "SITATEXID",
                table: "SubMessages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubMessages_SITATEXes_SITATEXID",
                table: "SubMessages",
                column: "SITATEXID",
                principalTable: "SITATEXes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMessages_SITATEXes_SITATEXID",
                table: "SubMessages");

            migrationBuilder.AlterColumn<int>(
                name: "SITATEXID",
                table: "SubMessages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SITATEX_ID",
                table: "SubMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SubMessages_SITATEXes_SITATEXID",
                table: "SubMessages",
                column: "SITATEXID",
                principalTable: "SITATEXes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
