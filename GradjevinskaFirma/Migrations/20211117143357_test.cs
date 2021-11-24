using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnaMestaID_RM",
                table: "Radnici");

            migrationBuilder.RenameColumn(
                name: "RadnaMestaID_RM",
                table: "Radnici",
                newName: "RadnaMestaID");

            migrationBuilder.RenameIndex(
                name: "IX_Radnici_RadnaMestaID_RM",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_RadnaMesta_RadnaMestaID",
                table: "Radnici");

            migrationBuilder.RenameColumn(
                name: "RadnaMestaID",
                table: "Radnici",
                newName: "RadnaMestaID_RM");

            migrationBuilder.RenameIndex(
                name: "IX_Radnici_RadnaMestaID",
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
    }
}
