using FutebaBrasil.DataBase.Mapping;
using FutebaBrasil.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace FutebaBrasil.DataBase
{
    public class FutebaBrasilContext: DbContext
    {
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<Partida> Partida { get; set; }

        public FutebaBrasilContext(DbContextOptions<FutebaBrasilContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            JogadorMapping.Mapping(builder);
            TimeMapping.Mapping(builder);
            PartidaMapping.Mapping(builder);

            base.OnModelCreating(builder);
        }
    }
}