using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PocztaPrzyszlosc.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OdbiorcaDTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nazwa = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    NumerTeleofnu = table.Column<int>(nullable: false),
                    KodPocztowy = table.Column<int>(nullable: false),
                    Miasto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdbiorcaDTO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdbiorcaDTO");
        }
    }
}
