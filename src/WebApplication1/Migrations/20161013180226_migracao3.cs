using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class migracao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    IdPartida = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Fim = table.Column<DateTime>(nullable: false),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Responsavel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.IdPartida);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partida");
        }
    }
}
