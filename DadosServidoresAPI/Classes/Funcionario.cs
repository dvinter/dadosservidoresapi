using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosServidoresAPI.Classes
{
    public class Funcionario
    {
        public string SiglaSecretaria { get; set; }
        public string NomeDivisao { get; set; }
        public string NomeSessao { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string CodigoCargo { get; set; }
        public string NomeCargo { get; set; }
        public string CodigoCusto { get; set; }
        public string NomeCusto { get; set; }
        public string CodigoAgencia { get; set; }
        public string NomeAgencia { get; set; }
        public string CodigoBanco { get; set; }
        public string NomeBanco { get; set; }
        public string ContaCorrente { get; set; }
        public string ProsicaoProgressao { get; set; }
        public string CPF { get; set; }
        public DateTime Admissao { get; set; }
    }
}
