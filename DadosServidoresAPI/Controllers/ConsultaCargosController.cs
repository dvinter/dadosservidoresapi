using DadosServidoresAPI.DAO;
using DadosServidoresAPI.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace DadosServidoresAPI.Controller
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ConsultaCargosController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaCargosController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        [Route("ConsultaCargos")]
        public object consultaCargosExistentes()
        {
            List<Cargos> cargos = new CargoDAO(config).obterDadosSetores();
            return cargos;
        }
        [HttpGet]
        [Route("ConsultaPeloNome")]
        public object consultaCargosExistentesPorNome([FromQuery] string nome)
        {
            List<Cargos> cargos = new CargoDAO(config).obterDadosSetores(nome);
            return cargos;
        }
    }
}
