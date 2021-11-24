using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnaMestaID",
                table: "Radnici");

            migrationBuilder.RenameColumn(
                name: "RadnaMestaID",
                table: "Radnici",
                newName: "RadnoMesto");

            migrationBuilder.RenameIndex(
                name: "IX_Radnici_RadnaMestaID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnoMesto",
                table: "Radnici");

            migrationBuilder.RenameColumn(
                name: "RadnoMesto",
                table: "Radnici",
                newName: "RadnaMestaID");

            migrationBuilder.RenameIndex(
                name: "IX_Radnici_RadnoMesto",
                table: "Radnici",
                newName: "IX_Radnici_RadnaMestaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnaMestaID",
                table: "Radnici",
                column: "RadnaMestaID",
                principalTable: "RadnaMesta",
                principalColumn: "ID_RM",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
