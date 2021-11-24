using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RadnaMesta",
                columns: table => new
                {
                    ID_RM = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RM = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadnaMesta", x => x.ID_RM);
                });

            migrationBuilder.CreateTable(
                name: "TipoviObracuna",
                columns: table => new
                {
                    ID_Obracun = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Obracun = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviObracuna", x => x.ID_Obracun);
                });

            migrationBuilder.CreateTable(
                name: "VrsteZaposlenja",
                columns: table => new
                {
                    ID_VZ = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VZ = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrsteZaposlenja", x => x.ID_VZ);
                });

            migrationBuilder.CreateTable(
                name: "Radnici",
                columns: table => new
                {
                    ID_Radnici = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JMBG = table.Column<string>(type: "TEXT", nullable: false),
                    PrezimeIme = table.Column<string>(type: "TEXT", nullable: false),
                    SSS = table.Column<string>(type: "TEXT", nullable: false),
                    TipObracunaID_Obracun = table.Column<int>(type: "INTEGER", nullable: false),
                    RadnaMestaID_RM = table.Column<int>(type: "INTEGER", nullable: false),
                    VrstaZaposlenjaID_VZ = table.Column<int>(type: "INTEGER", nullable: false),
                    PocetakOsiguranja = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    PrestanakOsiguranja = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnici", x => x.ID_Radnici);
                    table.ForeignKey(
                        name: "FK_Radnici_RadnaMesta_RadnaMestaID_RM",
                        column: x => x.RadnaMestaID_RM,
                        principalTable: "RadnaMesta",
                        principalColumn: "ID_RM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Radnici_TipoviObracuna_TipObracunaID_Obracun",
                        column: x => x.TipObracunaID_Obracun,
                        principalTable: "TipoviObracuna",
                        principalColumn: "ID_Obracun",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Radnici_VrsteZaposlenja_VrstaZaposlenjaID_VZ",
                        column: x => x.VrstaZaposlenjaID_VZ,
                        principalTable: "VrsteZaposlenja",
                        principalColumn: "ID_VZ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Radnici_RadnaMestaID_RM",
                table: "Radnici",
                column: "RadnaMestaID_RM");

            migrationBuilder.CreateIndex(
                name: "IX_Radnici_TipObracunaID_Obracun",
                table: "Radnici",
                column: "TipObracunaID_Obracun");

            migrationBuilder.CreateIndex(
                name: "IX_Radnici_VrstaZaposlenjaID_VZ",
                table: "Radnici",
                column: "VrstaZaposlenjaID_VZ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Radnici");

            migrationBuilder.DropTable(
                name: "RadnaMesta");

            migrationBuilder.DropTable(
                name: "TipoviObracuna");

            migrationBuilder.DropTable(
                name: "VrsteZaposlenja");
        }
    }
}
