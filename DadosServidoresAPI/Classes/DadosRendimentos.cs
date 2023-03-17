using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosServidoresAPI.Classes
{
    public class DadosRendimentos
    {
        public int AnoCalendario { get; set; }
        public int AnoExercicio { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Natureza { get; set; }
        public double TotalRendimentos { get; set; }
        public double ContribuicaoPrevidenciaria { get; set; }
        public double ContribuicaoPrevidenciariaPrivada { get; set; }
        public double PensaoAlimenticia { get; set; }
        public double ImpostoRetidoFonte { get; set; }
        public double ParcelaIsentoProventoAposentadoria { get; set; }
        public double Diarias { get; set; }
        public double PensaoProventos { get; set; }
        public double Lucros { get; set; }
        public double ValoresTitular { get; set; }
        public double Rescisao { get; set; }
        public string Outros07Descricao { get; set; }
        public double Outros07 { get; set; }
        public double DecimoTerceiro { get; set; }
        public double IRRF13 { get; set; }
        public double Outros02 { get; set; }
        public string InformacoesComplementares01 { get; set; }
        public string InformacoesComplementares02 { get; set; }
        public string InformacoesComplementares03 { get; set; }
        public string ResponsavelInformacoes { get; set; }

        public Empresa Empresa { get; set; }
        public IList<RendimentoAcumulado> RendimentosAcumulados { get; set; }

        public DadosRendimentos()
        {
            RendimentosAcumulados = new List<RendimentoAcumulado>();
            InformacoesComplementares01 = "";
            InformacoesComplementares02 = "";
            InformacoesComplementares03 = "";
        }

    }
}
