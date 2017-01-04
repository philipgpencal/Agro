using FutebaBrasil.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace FutebaBrasil.DataBase.Mapping
{
    public class TimeMapping
    {
        public static void Mapping(ModelBuilder builder)
        {
            builder.Entity<Time>().HasKey(m => m.IdTime);
        }
    }
}