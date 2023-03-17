using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DadosServidoresAPI.Classes;
using DadosServidoresAPI.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace DadosServidoresAPI.Controller
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ConsultaServidorController : ControllerBase
    {
        private readonly IConfiguration config;

        public ConsultaServidorController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpGet]
        [Route("ConsultaPelaMatricula")]
        public object consultaDadosServidor([FromQuery] string matricula)
        {
            try
            {
                List<Servidores> servidores = new List<Servidores>();
                Int32.Parse(matricula);
                string txPesquisaAux = matricula.Substring(0, 6);
                List<Servidores> servidoresAux = new ServidoresDAO(config).ObterDadosServidor(txPesquisaAux);
                foreach (Servidores servidor in servidoresAux)
                {
                    if (servidor.matriculaVinculo == matricula)
                    {
                        servidores.Add(servidor);
                        return servidores;
                    }
                }
                return servidoresAux;

            }
            catch (Exception e)
            {
               
                return null;
            }
        }
        [HttpGet]
        [Route("ConsultaPeloNome")]
        public object consultaDadosServidorPeloNome([FromQuery] string nome)
        {
            
                List<Servidores> servidores = new ServidoresDAO(config).ObterDadosServidor(nome);
                return servidores;
            
        }

        [HttpGet]
        [Route("ConsultaPeloCargo")]
        public object consultaDadosPeloCargo([FromQuery] string regime = "", string padraoSalarial = "", string cargaHoraria = "", string cargo = "", string setor = "", string dataAdmissao = "", string dataDemissao = "")
        {

            List<Servidores> servidoresAux = new ServidoresDAO(config).ObterDadosServidorPeloCargo(regime, padraoSalarial, cargaHoraria, cargo, setor, dataAdmissao, dataDemissao);
            return servidoresAux;


        }
        [HttpGet]
        [Route("ConsultaPeloFiltro")]
        public object ConsultaPeloFiltro([FromQuery] string regime = "", string padraoSalarial = "", string cargaHoraria = "", string cargo = "", string setor = "", string dataAdmissao = "", string dataDemissao = "")
        {

            List<Servidores> servidoresAux = new ServidoresDAO(config).ObterDadosServidorPeloCargo(regime, padraoSalarial, cargaHoraria, cargo, setor, dataAdmissao, dataDemissao);
            return servidoresAux;


        }
        [HttpGet]
        [Route("ConsultaQuantidade")]
        public object consultaQuantidadeServidor([FromQuery] string regime = "", string padraoSalarial = "", string cargaHoraria = "", string cargo = "", string setor = "", string dataAdmissao = "", string dataDemissao = "")
        {

            int qntidade = new ServidoresDAO(config).ObterQuantidadeServidor(regime, padraoSalarial, cargaHoraria, cargo, setor, dataAdmissao, dataDemissao);
            return qntidade;


        }
    }
}
