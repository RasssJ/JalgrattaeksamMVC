using Microsoft.EntityFrameworkCore.Migrations;

namespace JalgrattaeksamMVC.Data.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LubaViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teooria = table.Column<int>(type: "int", nullable: false),
                    Slaalom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tänav = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luba = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LubaViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LubaViewModel");
        }
    }
}
