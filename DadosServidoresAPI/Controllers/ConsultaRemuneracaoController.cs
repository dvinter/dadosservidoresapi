using DadosServidoresAPI.DAO;
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
    public class ConsultaRemuneracaoController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaRemuneracaoController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        public object consultaRemuneracaoPelaMatricula([FromQuery] string matricula)
        {
            return new ServidoresDAO(config).ObterRemuneracao(matricula);
            
        }
    }
}
