using DadosServidoresAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace DadosServidoresAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ConsultaAbonoController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaAbonoController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        public object consultaAbonosPelaMatricula([FromQuery] string matricula)
        {
            return new AbonoDAO(config).PesquisaAbonoAnoAtual(matricula);

        }
    }
}
