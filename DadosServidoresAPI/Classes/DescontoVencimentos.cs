using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosServidoresAPI.Classes
{
    public class DescontoVencimentos
    {
        public string CodigoVende { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
        public double IncideINSS { get; set; }
        public double Vencimento { get; set; }
        public double Desconto { get; set; }
        public string MatriculaVinculo { get; set; }

    }
}
