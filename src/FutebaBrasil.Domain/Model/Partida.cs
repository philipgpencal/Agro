using System;

namespace FutebaBrasil.Domain.Model
{
    public class Partida
    {
        public int IdPartida { get; set; }

        public string Responsavel { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }
    }
}
