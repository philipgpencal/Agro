using System.Collections.Generic;

namespace FutebaBrasil.Domain.Model
{
    public class Time
    {
        public int IdTime { get; set; }
        public string Nome { get; set; }

        public List<Jogador> Jogadores { get; set; }
    }
}