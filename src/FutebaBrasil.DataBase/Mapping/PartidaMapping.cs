namespace FutebaBrasil.DataBase.Mapping
{
    using Domain.Model;
    using Microsoft.EntityFrameworkCore;

    public class PartidaMapping
    {
        public static void Mapping(ModelBuilder builder)
        {
            builder.Entity<Partida>().HasKey(m => m.IdPartida);
        }
    }
}