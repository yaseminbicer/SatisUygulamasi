using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SatisUygulamaForm.Migrations
{
    /// <inheritdoc />
    public partial class _2311141554 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kod",
                table: "Musteri",
                newName: "AdSoyad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdSoyad",
                table: "Musteri",
                newName: "Kod");
        }
    }
}
