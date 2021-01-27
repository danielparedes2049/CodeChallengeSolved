using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeChallenge.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: true),
                    Especie = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    LugarOrigen = table.Column<string>(nullable: true),
                    Peso = table.Column<double>(nullable: false),
                    Porcentaje = table.Column<double>(nullable: false),
                    Kilos = table.Column<double>(nullable: false),
                    CambioPiel = table.Column<int>(nullable: false),
                    TotalCarneMes = table.Column<double>(nullable: false),
                    TotalHierbaMes = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animales", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animales");
        }
    }
}
