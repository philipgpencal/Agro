using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class migracao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    IdTime = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.IdTime);
                });

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    IdJogador = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdTime = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.IdJogador);
                    table.ForeignKey(
                        name: "FK_Jogador_Time_IdTime",
                        column: x => x.IdTime,
                        principalTable: "Time",
                        principalColumn: "IdTime",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_IdTime",
                table: "Jogador",
                column: "IdTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
