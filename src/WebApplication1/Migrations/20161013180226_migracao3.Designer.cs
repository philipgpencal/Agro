using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FutebaBrasil.DataBase;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(FutebaBrasilContext))]
    [Migration("20161013180226_migracao3")]
    partial class migracao3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("FutebaBrasil.Domain.Model.Jogador", b =>
                {
                    b.Property<int>("IdJogador")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdTime");

                    b.Property<string>("Nome");

                    b.Property<int>("Numero");

                    b.HasKey("IdJogador");

                    b.HasIndex("IdTime");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("FutebaBrasil.Domain.Model.Partida", b =>
                {
                    b.Property<int>("IdPartida")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Fim");

                    b.Property<DateTime>("Inicio");

                    b.Property<string>("Responsavel");

                    b.HasKey("IdPartida");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("FutebaBrasil.Domain.Model.Time", b =>
                {
                    b.Property<int>("IdTime")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("IdTime");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("FutebaBrasil.Domain.Model.Jogador", b =>
                {
                    b.HasOne("FutebaBrasil.Domain.Model.Time", "Time")
                        .WithMany("Jogadores")
                        .HasForeignKey("IdTime")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
