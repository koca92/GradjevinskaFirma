using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    public partial class DnevnoLisce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DnevniIzvestaji",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GradilisteID = table.Column<int>(type: "INTEGER", nullable: false),
                    Napomena = table.Column<string>(type: "TEXT", nullable: false),
                    PodnosilacID_Radnici = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DnevniIzvestaji", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DnevniIzvestaji_Gradilista_GradilisteID",
                        column: x => x.GradilisteID,
                        principalTable: "Gradilista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DnevniIzvestaji_Radnici_PodnosilacID_Radnici",
                        column: x => x.PodnosilacID_Radnici,
                        principalTable: "Radnici",
                        principalColumn: "ID_Radnici",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "radniSati",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DnevniIzvestajID = table.Column<int>(type: "INTEGER", nullable: false),
                    RadnikID_Radnici = table.Column<int>(type: "INTEGER", nullable: false),
                    Sati = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_radniSati", x => x.ID);
                    table.ForeignKey(
                        name: "FK_radniSati_DnevniIzvestaji_DnevniIzvestajID",
                        column: x => x.DnevniIzvestajID,
                        principalTable: "DnevniIzvestaji",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_radniSati_Radnici_RadnikID_Radnici",
                        column: x => x.RadnikID_Radnici,
                        principalTable: "Radnici",
                        principalColumn: "ID_Radnici",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DnevniIzvestaji_GradilisteID",
                table: "DnevniIzvestaji",
                column: "GradilisteID");

            migrationBuilder.CreateIndex(
                name: "IX_DnevniIzvestaji_PodnosilacID_Radnici",
                table: "DnevniIzvestaji",
                column: "PodnosilacID_Radnici");

            migrationBuilder.CreateIndex(
                name: "IX_radniSati_DnevniIzvestajID",
                table: "radniSati",
                column: "DnevniIzvestajID");

            migrationBuilder.CreateIndex(
                name: "IX_radniSati_RadnikID_Radnici",
                table: "radniSati",
                column: "RadnikID_Radnici");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "radniSati");

            migrationBuilder.DropTable(
                name: "DnevniIzvestaji");
        }
    }
}
