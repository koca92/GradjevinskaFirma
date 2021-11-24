using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class Test11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnoMesto",
                table: "Radnici");

            migrationBuilder.RenameColumn(
                name: "RadnoMesto",
                table: "Radnici",
                newName: "RadnaMestaID_RM");

            migrationBuilder.RenameIndex(
                name: "IX_Radnici_RadnoMesto",
                table: "Radnici",
                newName: "IX_Radnici_RadnaMestaID_RM");

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnaMestaID_RM",
                table: "Radnici",
                column: "RadnaMestaID_RM",
                principalTable: "RadnaMesta",
                principalColumn: "ID_RM",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnaMestaID_RM",
                table: "Radnici");

            migrationBuilder.RenameColumn(
                name: "RadnaMestaID_RM",
                table: "Radnici",
                newName: "RadnoMesto");

            migrationBuilder.RenameIndex(
                name: "IX_Radnici_RadnaMestaID_RM",
                table: "Radnici",
                newName: "IX_Radnici_RadnoMesto");

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnoMesto",
                table: "Radnici",
                column: "RadnoMesto",
                principalTable: "RadnaMesta",
                principalColumn: "ID_RM",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
