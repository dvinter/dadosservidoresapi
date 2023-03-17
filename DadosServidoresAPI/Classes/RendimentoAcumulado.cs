using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosServidoresAPI.Classes
{
    public class RendimentoAcumulado
    {
        public int Id { get; set; }
        public int QuantidadeMeses { get; set; }
        public string Processo { get; set; }
        public string Natureza { get; set; }
        public double TotalRendimentos { get; set; }
        public double DespesaAcaoJudicial { get; set; }
        public double ContribuicaoPrevidenciaria { get; set; }
        public double PensaoAlimenticia { get; set; }
        public double ImpostoRetidoFonte { get; set; }
        public double Molestia { get; set; }
    }
}
