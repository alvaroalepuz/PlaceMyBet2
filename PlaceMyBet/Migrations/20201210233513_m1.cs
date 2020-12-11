using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casaapuestas",
                columns: table => new
                {
                    casaapuestasId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SaldoActual = table.Column<int>(nullable: false),
                    NombreBanco = table.Column<string>(nullable: true),
                    NumeroTarjeta = table.Column<int>(nullable: false),
                    emailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casaapuestas", x => x.casaapuestasId);
                });

            migrationBuilder.CreateTable(
                name: "Mercado",
                columns: table => new
                {
                    mercadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mercado = table.Column<double>(nullable: false),
                    CuotaOver = table.Column<double>(nullable: false),
                    CuotaUnder = table.Column<double>(nullable: false),
                    DineroOver = table.Column<double>(nullable: false),
                    DineroUnder = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercado", x => x.mercadoId);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    eventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreNombreEquipoLocal = table.Column<string>(nullable: true),
                    NombreNombreEquipoVisitante = table.Column<string>(nullable: true),
                    fecha = table.Column<string>(nullable: true),
                    mercadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.eventoId);
                    table.ForeignKey(
                        name: "FK_Evento_Mercado_mercadoId",
                        column: x => x.mercadoId,
                        principalTable: "Mercado",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    MercadoId = table.Column<int>(nullable: false),
                    casaapuestaRcasaapuestasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Mercado_MercadoId",
                        column: x => x.MercadoId,
                        principalTable: "Mercado",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Casaapuestas_casaapuestaRcasaapuestasId",
                        column: x => x.casaapuestaRcasaapuestasId,
                        principalTable: "Casaapuestas",
                        principalColumn: "casaapuestasId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apuesta",
                columns: table => new
                {
                    apuestaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    Dinero = table.Column<double>(nullable: false),
                    MercadoId = table.Column<int>(nullable: false),
                    emailId = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuesta", x => x.apuestaId);
                    table.ForeignKey(
                        name: "FK_Apuesta_Mercado_MercadoId",
                        column: x => x.MercadoId,
                        principalTable: "Mercado",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apuesta_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Casaapuestas",
                columns: new[] { "casaapuestasId", "NombreBanco", "NumeroTarjeta", "SaldoActual", "emailId" },
                values: new object[] { 1, "Bankia", 239458, 300, "alvaroalepuz99@gmail.com" });

            migrationBuilder.InsertData(
                table: "Mercado",
                columns: new[] { "mercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "Mercado" },
                values: new object[] { 1, 30.0, 90.0, 500.0, 100.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Apuesta",
                columns: new[] { "apuestaId", "Dinero", "MercadoId", "Tipo", "emailId", "usuarioId" },
                values: new object[] { 1, 400.0, 1, "under", "alvaroalepuz99@gmail.com", null });

            migrationBuilder.InsertData(
                table: "Evento",
                columns: new[] { "eventoId", "NombreNombreEquipoLocal", "NombreNombreEquipoVisitante", "fecha", "mercadoId" },
                values: new object[] { 1, "Barcelona", "Madrid", "06-08-2077", 1 });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "usuarioId", "Apellido", "Edad", "MercadoId", "Nombre", "casaapuestaRcasaapuestasId" },
                values: new object[] { 1, "Alepuz", 10, 1, "Alvaro", null });

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_MercadoId",
                table: "Apuesta",
                column: "MercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_usuarioId",
                table: "Apuesta",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_mercadoId",
                table: "Evento",
                column: "mercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_MercadoId",
                table: "Usuario",
                column: "MercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_casaapuestaRcasaapuestasId",
                table: "Usuario",
                column: "casaapuestaRcasaapuestasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apuesta");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Mercado");

            migrationBuilder.DropTable(
                name: "Casaapuestas");
        }
    }
}
