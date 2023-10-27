using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SatisUygulamaForm.Migrations
{
    /// <inheritdoc />
    public partial class Update202310271502 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yonnetici",
                table: "Kullanici",
                newName: "Yonetici");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yonetici",
                table: "Kullanici",
                newName: "Yonnetici");
        }
    }
}
