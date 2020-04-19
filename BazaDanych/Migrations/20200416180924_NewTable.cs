using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BazaDanych.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wiek",
                table: "OsobaBliska");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "OsobaBliska",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.CreateTable(
                name: "OdczuciawDomu",
                columns: table => new
                {
                    OdczuciawDomuId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RespondentId = table.Column<int>(nullable: true),
                    Poziom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdczuciawDomu", x => x.OdczuciawDomuId);
                    table.ForeignKey(
                        name: "FK_OdczuciawDomu_Respondent_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondent",
                        principalColumn: "RespondentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdczuciawDomu_RespondentId",
                table: "OdczuciawDomu",
                column: "RespondentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdczuciawDomu");

            migrationBuilder.AlterColumn<bool>(
                name: "Nazwa",
                table: "OsobaBliska",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wiek",
                table: "OsobaBliska",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
