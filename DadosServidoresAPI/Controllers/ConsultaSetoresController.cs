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
    public class ConsultaSetoresController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaSetoresController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        [Route("SetoresExistentes")]
        public object consultaSetoresExistentes([FromQuery] string nome="")
        {
            List<Cargos> setores = new SetorDAO(config).obterDadosSetores(nome);
            return setores;
        }


        [HttpGet]
        [Route("InfoSetores")]
        public object consultaInformacoesSetores([FromQuery] string nome = "", [FromQuery] string sigSetor= "")
        {
            List<Setores> setores = new SetorDAO(config).obterInfoSetores(nome, sigSetor);
            return setores;
        }
    }
}
