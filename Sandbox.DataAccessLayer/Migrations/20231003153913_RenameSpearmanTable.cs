using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sandbox.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class RenameSpearmanTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpearmanDbos_Spears_SpearId",
                table: "SpearmanDbos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpearmanDbos",
                table: "SpearmanDbos");

            migrationBuilder.RenameTable(
                name: "SpearmanDbos",
                newName: "Spearman");

            migrationBuilder.RenameIndex(
                name: "IX_SpearmanDbos_SpearId",
                table: "Spearman",
                newName: "IX_Spearman_SpearId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spearman",
                table: "Spearman",
                column: "SpearmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spearman_Spears_SpearId",
                table: "Spearman",
                column: "SpearId",
                principalTable: "Spears",
                principalColumn: "SpearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spearman_Spears_SpearId",
                table: "Spearman");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spearman",
                table: "Spearman");

            migrationBuilder.RenameTable(
                name: "Spearman",
                newName: "SpearmanDbos");

            migrationBuilder.RenameIndex(
                name: "IX_Spearman_SpearId",
                table: "SpearmanDbos",
                newName: "IX_SpearmanDbos_SpearId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpearmanDbos",
                table: "SpearmanDbos",
                column: "SpearmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpearmanDbos_Spears_SpearId",
                table: "SpearmanDbos",
                column: "SpearId",
                principalTable: "Spears",
                principalColumn: "SpearId");
        }
    }
}
