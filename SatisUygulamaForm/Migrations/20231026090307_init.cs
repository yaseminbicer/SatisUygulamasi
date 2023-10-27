using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SatisUygulamaForm.Persistence;
using DevExpress.CodeParser;
#nullable disable

namespace SatisUygulamaForm.Migrations
{
    /// <inheritdoc />
    /// 


  
    public partial class init : Migration 
    {
        /// <inheritdoc />
        /// 
        

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusteriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ÜrünAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GenelToplam = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Birimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunGrup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlisFiyati = table.Column<double>(type: "float", nullable: true),
                    SatisFiyati = table.Column<double>(type: "float", nullable: true),
                    KdvOrani = table.Column<int>(type: "int", nullable: true),
                    UrunAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunGrubu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FisSatir",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FisSatir", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FisSatir_Fis_FisId",
                        column: x => x.FisId,
                        principalTable: "Fis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FisSatir_FisId",
                table: "FisSatir",
                column: "FisId");




        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FisSatir");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Fis");
        }
    }
}
