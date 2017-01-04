using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebaBrasil.Domain.Model
{
    public class Jogador
    {
        public int IdJogador { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public int IdTime { get; set; }
        public Time Time { get; set; }
    }
}
