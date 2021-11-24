using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class @null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_TipoviObracuna_TipObracunaID_Obracun",
                table: "Radnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_VrsteZaposlenja_VrstaZaposlenjaID_VZ",
                table: "Radnici");

            migrationBuilder.AlterColumn<int>(
                name: "VrstaZaposlenjaID_VZ",
                table: "Radnici",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "TipObracunaID_Obracun",
                table: "Radnici",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "SSS",
                table: "Radnici",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_TipoviObracuna_TipObracunaID_Obracun",
                table: "Radnici",
                column: "TipObracunaID_Obracun",
                principalTable: "TipoviObracuna",
                principalColumn: "ID_Obracun");

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_VrsteZaposlenja_VrstaZaposlenjaID_VZ",
                table: "Radnici",
                column: "VrstaZaposlenjaID_VZ",
                principalTable: "VrsteZaposlenja",
                principalColumn: "ID_VZ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_TipoviObracuna_TipObracunaID_Obracun",
                table: "Radnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_VrsteZaposlenja_VrstaZaposlenjaID_VZ",
                table: "Radnici");

            migrationBuilder.AlterColumn<int>(
                name: "VrstaZaposlenjaID_VZ",
                table: "Radnici",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipObracunaID_Obracun",
                table: "Radnici",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SSS",
                table: "Radnici",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_TipoviObracuna_TipObracunaID_Obracun",
                table: "Radnici",
                column: "TipObracunaID_Obracun",
                principalTable: "TipoviObracuna",
                principalColumn: "ID_Obracun",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_VrsteZaposlenja_VrstaZaposlenjaID_VZ",
                table: "Radnici",
                column: "VrstaZaposlenjaID_VZ",
                principalTable: "VrsteZaposlenja",
                principalColumn: "ID_VZ",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
