using Microsoft.EntityFrameworkCore.Migrations;

namespace PocztaPrzyszlosc.EntityFramework.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nadawca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    NumerTeleofnu = table.Column<int>(nullable: false),
                    KodPocztowy = table.Column<int>(nullable: false),
                    Miasto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nadawca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Odbiorca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    NumerTeleofnu = table.Column<int>(nullable: false),
                    KodPocztowy = table.Column<int>(nullable: false),
                    Miasto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odbiorca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paczka",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PocztaDoDomu = table.Column<bool>(nullable: false),
                    PocztaDoPoczty = table.Column<bool>(nullable: false),
                    Priorytet = table.Column<bool>(nullable: false),
                    Rozmiar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paczka", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nadawca");

            migrationBuilder.DropTable(
                name: "Odbiorca");

            migrationBuilder.DropTable(
                name: "Paczka");
        }
    }
}
