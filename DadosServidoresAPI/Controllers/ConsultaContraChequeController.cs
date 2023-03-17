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
    public class ConsultaContraChequeController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaContraChequeController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        public object consultaContraChequePelaMatricula([FromQuery] string matricula, string ano, string mes, string folha)
        {
            return new ContraChequeDAO(config).PesquisaContraCheque(matricula, ano, mes, folha);

        }
    }
}
