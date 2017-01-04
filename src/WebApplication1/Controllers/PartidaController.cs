using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FutebaBrasil.Api.Controllers
{
    using FutebaBrasil.Domain.IServices;
    using FutebaBrasil.Domain.Model;

    [Route("api/[controller]")]
    public class PartidaController : Controller
    {
        private readonly IPartidaService _partidaService;
        public PartidaController(IPartidaService partidaService)
        {
            _partidaService = partidaService;
        }

        // GET api/partida/SalvarPartida
        [HttpGet]
        [Route("SalvarPartida")]
        public IEnumerable<string> SalvarPartida()
        {
            this._partidaService.SalvarPartida("teste", new DateTime(), new DateTime());

            return new string[] { "value1", "value2" };   
        }

        // GET api/partida/RecuperarTodasPartidas
        [HttpGet]
        [Route("RecuperarTodasPartidas")]
        public List<Partida> RecuperarTodasPartidas()
        {
            return this._partidaService.RecuperarTodasPartidas();
        }
    }
}
