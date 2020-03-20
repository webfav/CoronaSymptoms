using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaSymptoms.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Symptomer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Alder = table.Column<string>(nullable: true),
                    Køn = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    SymptomerBool = table.Column<bool>(nullable: false),
                    Nyser = table.Column<bool>(nullable: false),
                    Hoster = table.Column<bool>(nullable: false),
                    Feber = table.Column<bool>(nullable: false),
                    Muskelømhed = table.Column<bool>(nullable: false),
                    Diarre = table.Column<bool>(nullable: false),
                    Opkast = table.Column<bool>(nullable: false),
                    Hovedpine = table.Column<bool>(nullable: false),
                    Halsonde = table.Column<bool>(nullable: false),
                    Stakåndethed = table.Column<bool>(nullable: false),
                    Udmattet = table.Column<bool>(nullable: false),
                    Sansetab = table.Column<bool>(nullable: false),
                    Andet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptomer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Symptomer");
        }
    }
}
