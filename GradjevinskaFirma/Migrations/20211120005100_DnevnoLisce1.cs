using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class DnevnoLisce1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Datum",
                table: "DnevniIzvestaji",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datum",
                table: "DnevniIzvestaji");
        }
    }
}
