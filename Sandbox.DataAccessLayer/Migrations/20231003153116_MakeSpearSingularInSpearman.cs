using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sandbox.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class MakeSpearSingularInSpearman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spears_SpearmanDbos_SpearmanDboSpearmanId",
                table: "Spears");

            migrationBuilder.DropIndex(
                name: "IX_Spears_SpearmanDboSpearmanId",
                table: "Spears");

            migrationBuilder.DropColumn(
                name: "SpearmanDboSpearmanId",
                table: "Spears");

            migrationBuilder.AddColumn<int>(
                name: "SpearId",
                table: "SpearmanDbos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpearmanDbos_SpearId",
                table: "SpearmanDbos",
                column: "SpearId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpearmanDbos_Spears_SpearId",
                table: "SpearmanDbos",
                column: "SpearId",
                principalTable: "Spears",
                principalColumn: "SpearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpearmanDbos_Spears_SpearId",
                table: "SpearmanDbos");

            migrationBuilder.DropIndex(
                name: "IX_SpearmanDbos_SpearId",
                table: "SpearmanDbos");

            migrationBuilder.DropColumn(
                name: "SpearId",
                table: "SpearmanDbos");

            migrationBuilder.AddColumn<int>(
                name: "SpearmanDboSpearmanId",
                table: "Spears",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spears_SpearmanDboSpearmanId",
                table: "Spears",
                column: "SpearmanDboSpearmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spears_SpearmanDbos_SpearmanDboSpearmanId",
                table: "Spears",
                column: "SpearmanDboSpearmanId",
                principalTable: "SpearmanDbos",
                principalColumn: "SpearmanId");
        }
    }
}
