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
    public class ConsultaGestoresController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaGestoresController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        public object consultaSetoresExistentes([FromQuery] string cargo = "")
        {
            List<Gestores> gestores = new GestoresDAO(config).CarregarGestores(cargo);
            return gestores;
        }
    }
}
