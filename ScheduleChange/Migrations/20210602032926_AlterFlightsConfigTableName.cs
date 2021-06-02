using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleChange.Migrations
{
    public partial class AlterFlightsConfigTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Configs",
                table: "Configs");

            migrationBuilder.RenameTable(
                name: "Configs",
                newName: "FlightConfigs");

            migrationBuilder.RenameColumn(
                name: "Todate",
                table: "FlightConfigs",
                newName: "ToDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "FlightConfigs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateBy",
                table: "FlightConfigs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FlightConfigs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CreateBy",
                table: "FlightConfigs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightConfigs",
                table: "FlightConfigs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightConfigs",
                table: "FlightConfigs");

            migrationBuilder.RenameTable(
                name: "FlightConfigs",
                newName: "Configs");

            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "Configs",
                newName: "Todate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Configs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateBy",
                table: "Configs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Configs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreateBy",
                table: "Configs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configs",
                table: "Configs",
                column: "Id");
        }
    }
}
