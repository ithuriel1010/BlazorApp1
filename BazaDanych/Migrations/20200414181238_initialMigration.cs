using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BazaDanych.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Respondent",
                columns: table => new
                {
                    RespondentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sex = table.Column<bool>(nullable: false),
                    Grupa = table.Column<bool>(nullable: false),
                    Wiek = table.Column<int>(nullable: false),
                    Wyksztalcenie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respondent", x => x.RespondentId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AwariaWiedza",
                columns: table => new
                {
                    AwariaWiedzaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwariaWiedza", x => x.AwariaWiedzaId);
                    table.ForeignKey(
                        name: "FK_AwariaWiedza_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Choroba",
                columns: table => new
                {
                    ChorobaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Nazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choroba", x => x.ChorobaId);
                    table.ForeignKey(
                        name: "FK_Choroba_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonitoringOdczucia",
                columns: table => new
                {
                    MonitoringOdczuciaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoringOdczucia", x => x.MonitoringOdczuciaId);
                    table.ForeignKey(
                        name: "FK_MonitoringOdczucia_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonitoringWiedza",
                columns: table => new
                {
                    MonitoringWiedzaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoringWiedza", x => x.MonitoringWiedzaId);
                    table.ForeignKey(
                        name: "FK_MonitoringWiedza_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OsobaBliska",
                columns: table => new
                {
                    OsobaBliskaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Nazwa = table.Column<bool>(nullable: false),
                    Wiek = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OsobaBliska", x => x.OsobaBliskaId);
                    table.ForeignKey(
                        name: "FK_OsobaBliska_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StanFizyczny",
                columns: table => new
                {
                    StanFizycznyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanFizyczny", x => x.StanFizycznyId);
                    table.ForeignKey(
                        name: "FK_StanFizyczny_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechnologiaWiedza",
                columns: table => new
                {
                    TechnologiaWiedzaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologiaWiedza", x => x.TechnologiaWiedzaId);
                    table.ForeignKey(
                        name: "FK_TechnologiaWiedza_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AwariaWiedza_RespondentId",
                table: "AwariaWiedza",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_Choroba_RespondentId",
                table: "Choroba",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringOdczucia_RespondentId",
                table: "MonitoringOdczucia",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringWiedza_RespondentId",
                table: "MonitoringWiedza",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_OsobaBliska_RespondentId",
                table: "OsobaBliska",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_StanFizyczny_RespondentId",
                table: "StanFizyczny",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnologiaWiedza_RespondentId",
                table: "TechnologiaWiedza",
                column: "RespondentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwariaWiedza");

            migrationBuilder.DropTable(
                name: "Choroba");

            migrationBuilder.DropTable(
                name: "MonitoringOdczucia");

            migrationBuilder.DropTable(
                name: "MonitoringWiedza");

            migrationBuilder.DropTable(
                name: "OsobaBliska");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "StanFizyczny");

            migrationBuilder.DropTable(
                name: "TechnologiaWiedza");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Respondent");
        }
    }
}
