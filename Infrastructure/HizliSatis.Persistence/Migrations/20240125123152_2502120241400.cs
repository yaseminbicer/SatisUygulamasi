using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SatisUygulamaForm.Migrations
{
    /// <inheritdoc />
    public partial class _2502120241400 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisSatir_Stok_StokId",
                table: "FisSatir");

            migrationBuilder.DropIndex(
                name: "IX_FisSatir_StokId",
                table: "FisSatir");

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.CreateIndex(
                name: "IX_FisSatir_StokId",
                table: "FisSatir",
                column: "StokId");

            migrationBuilder.AddForeignKey(
                name: "FK_FisSatir_Stok_StokId",
                table: "FisSatir",
                column: "StokId",
                principalTable: "Stok",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
