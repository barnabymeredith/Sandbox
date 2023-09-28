using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sandbox.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpearmanDbos",
                columns: table => new
                {
                    SpearmanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HealthPoints = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpearmanDbos", x => x.SpearmanId);
                });

            migrationBuilder.CreateTable(
                name: "Spears",
                columns: table => new
                {
                    SpearId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Material = table.Column<int>(type: "INTEGER", nullable: false),
                    SpearmanDboSpearmanId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spears", x => x.SpearId);
                    table.ForeignKey(
                        name: "FK_Spears_SpearmanDbos_SpearmanDboSpearmanId",
                        column: x => x.SpearmanDboSpearmanId,
                        principalTable: "SpearmanDbos",
                        principalColumn: "SpearmanId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spears_SpearmanDboSpearmanId",
                table: "Spears",
                column: "SpearmanDboSpearmanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spears");

            migrationBuilder.DropTable(
                name: "SpearmanDbos");
        }
    }
}
