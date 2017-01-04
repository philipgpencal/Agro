namespace FutebaBrasil.Domain.IServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Security.Cryptography.X509Certificates;
    using FutebaBrasil.Domain.Model;

    public interface IPartidaService
    {
        bool SalvarPartida(string responsavel, DateTime inicio, DateTime fim);

        List<Partida> RecuperarTodasPartidas();
    }
}
