using FutebaBrasil.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace FutebaBrasil.DataBase.Mapping
{
    public class JogadorMapping
    {
        public static void Mapping(ModelBuilder builder)
        {
            builder.Entity<Jogador>().HasKey(m => m.IdJogador);
        }
    }
}