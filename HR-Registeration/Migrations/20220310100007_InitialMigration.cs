using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Registeration.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AnalysisLab",
                schema: "dbo",
                columns: table => new
                {
                    Analysis_Lab_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Analysis_Lab_Name = table.Column<string>(type: "Varchar(150)", nullable: false),
                    Analysis_Lab_Address = table.Column<string>(type: "Varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisLab", x => x.Analysis_Lab_ID);
                });

            migrationBuilder.CreateTable(
                name: "RaysLab",
                schema: "dbo",
                columns: table => new
                {
                    Rays_Lab_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rays_Lab_Name = table.Column<string>(type: "Varchar(150)", nullable: false),
                    Rays_Lab_Address = table.Column<string>(type: "Varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaysLab", x => x.Rays_Lab_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalysisLab",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RaysLab",
                schema: "dbo");
        }
    }
}
