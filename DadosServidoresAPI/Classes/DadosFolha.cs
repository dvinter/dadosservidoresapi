using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DadosServidoresAPI.Classes;

namespace DadosServidoresAPI.Classes
{
    public class DadosFolha
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string Folha { get; set; }

        /// <summary>
        /// Retorna a Soma dos Vencimentos
        /// </summary>
        public double TotalVencimentos
        {
            get
            {
                return DescontoVencimentos.Sum(a => a.Vencimento);
            }
        }
        /// <summary>
        /// Retorna a Soma dos Descontos
        /// </summary>
        public double TotalDescontos
        {
            get
            {
                return DescontoVencimentos.Sum(a => a.Desconto);
            }
        }
        /// <summary>
        /// Retorna o total líquido (TotalVencimentos - TotalDescontos)
        /// </summary>
        public double TotalLiquido
        {
            get
            {
                return TotalVencimentos - TotalDescontos;
            }
        }

        public double SalarioBase { get; set; }
        public double IncideINSS { get; set; }
        public double FGTSBase { get; set; }
        public double FGTSMes { get; set; }
        public double IRRF { get; set; }
        public double MargemConsignavel { get; set; }

        /// <summary>
        /// Descreve a data e a folha
        /// </summary>
        public string DescricaoData
        {
            get
            {
                return string.Format("{0}/{1}", Util.MesExtenso(Mes).ToUpper(), Ano);
            }
        }
        public Empresa Empresa { get; set; }
        public Funcionario Funcionario { get; set; }
        public IList<DescontoVencimentos> DescontoVencimentos { get; set; }
    }
}
