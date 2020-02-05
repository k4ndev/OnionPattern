using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    AddedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Poster = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alboms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    AddedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    RelaiseDate = table.Column<DateTime>(nullable: false),
                    Poster = table.Column<string>(maxLength: 150, nullable: true),
                    Desc = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ArtistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alboms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alboms_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    AddedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    File = table.Column<string>(maxLength: 150, nullable: false),
                    Poster = table.Column<string>(maxLength: 150, nullable: true),
                    ListeningCount = table.Column<int>(nullable: false, defaultValue: 0),
                    CaDownload = table.Column<bool>(nullable: false, defaultValue: false),
                    Duration = table.Column<int>(nullable: false),
                    AlbomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musics_Alboms_AlbomId",
                        column: x => x.AlbomId,
                        principalTable: "Alboms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alboms_ArtistId",
                table: "Alboms",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_AlbomId",
                table: "Musics",
                column: "AlbomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musics");

            migrationBuilder.DropTable(
                name: "Alboms");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
