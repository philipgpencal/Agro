using System;
using FutebaBrasil.Domain.IServices;
using FutebaBrasil.DataBase;

namespace FutebaBrasil.Core.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using FutebaBrasil.Domain.Model;

    public class PartidaService : IPartidaService
    {
        private readonly FutebaBrasilContext _context;

        public PartidaService(FutebaBrasilContext context)
        {
            this._context = context;
        }

        public List<Partida> RecuperarTodasPartidas()
        {
            return _context.Partida.ToList();
        }

        public bool SalvarPartida(string responsavel, DateTime inicio, DateTime fim)
        {
            var partida = new Partida { Responsavel = responsavel, Inicio = DateTime.Now, Fim = DateTime.Now };

            _context.Partida.Add(partida);
            _context.SaveChanges();

            return true;
        }
    }
}
