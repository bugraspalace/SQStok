using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQStok.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pozisyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozisyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkaKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaKategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkaKategori_Kategories_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkaKategori_Markas_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Kategories_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_Markas_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BirimPozisyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimID = table.Column<int>(type: "int", nullable: false),
                    PozisyonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirimPozisyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirimPozisyons_Birims_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BirimPozisyons_Pozisyons_PozisyonID",
                        column: x => x.PozisyonID,
                        principalTable: "Pozisyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TCNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirimID = table.Column<int>(type: "int", nullable: false),
                    PozisyonID = table.Column<int>(type: "int", nullable: false),
                    GirisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CikisTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personels_Birims_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personels_Pozisyons_PozisyonID",
                        column: x => x.PozisyonID,
                        principalTable: "Pozisyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uruns_Kategories_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uruns_Markas_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uruns_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Envanters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envanters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envanters_Uruns_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotograflar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotografVeri = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograflar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fotograflar_Uruns_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokHarekets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlimSatim = table.Column<bool>(type: "bit", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokHarekets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokHarekets_Uruns_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BirimPozisyons_BirimID",
                table: "BirimPozisyons",
                column: "BirimID");

            migrationBuilder.CreateIndex(
                name: "IX_BirimPozisyons_PozisyonID",
                table: "BirimPozisyons",
                column: "PozisyonID");

            migrationBuilder.CreateIndex(
                name: "IX_Envanters_UrunID",
                table: "Envanters",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Fotograflar_UrunID",
                table: "Fotograflar",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_MarkaKategori_KategoriId",
                table: "MarkaKategori",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkaKategori_MarkaId",
                table: "MarkaKategori",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_KategoriId",
                table: "Models",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkaId",
                table: "Models",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_BirimID",
                table: "Personels",
                column: "BirimID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_PozisyonID",
                table: "Personels",
                column: "PozisyonID");

            migrationBuilder.CreateIndex(
                name: "IX_StokHarekets_UrunID",
                table: "StokHarekets",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_KategoriId",
                table: "Uruns",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_MarkaId",
                table: "Uruns",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_ModelId",
                table: "Uruns",
                column: "ModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirimPozisyons");

            migrationBuilder.DropTable(
                name: "Envanters");

            migrationBuilder.DropTable(
                name: "Fotograflar");

            migrationBuilder.DropTable(
                name: "MarkaKategori");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "StokHarekets");

            migrationBuilder.DropTable(
                name: "Birims");

            migrationBuilder.DropTable(
                name: "Pozisyons");

            migrationBuilder.DropTable(
                name: "Uruns");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Kategories");

            migrationBuilder.DropTable(
                name: "Markas");
        }
    }
}
