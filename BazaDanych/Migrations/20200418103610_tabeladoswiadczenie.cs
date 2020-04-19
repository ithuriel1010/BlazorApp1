using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BazaDanych.Migrations
{
    public partial class tabeladoswiadczenie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoswiadczenieZSeniorem",
                columns: table => new
                {
                    DoswiadczenieZSenioremId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoswiadczenieZSeniorem", x => x.DoswiadczenieZSenioremId);
                    table.ForeignKey(
                        name: "FK_DoswiadczenieZSeniorem_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoswiadczenieZSeniorem_RespondentId",
                table: "DoswiadczenieZSeniorem",
                column: "RespondentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoswiadczenieZSeniorem");
        }
    }
}
