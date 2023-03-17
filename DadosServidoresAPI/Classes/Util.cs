using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace DadosServidoresAPI.Classes
{
    public static class Util
    {
        /// <summary>
        /// Obtem o Nome por extenso
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string MesExtenso(int mes)
        {
            return new DateTime(2000, mes, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br"));
        }

        /// <summary>
        /// Converte um objeto para double
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static float ToFloat(this object objeto)
        {
            var valor = (objeto ?? "0").ToString();
            if (string.IsNullOrEmpty(valor))
            {
                valor = "0";
            }
            return float.Parse(valor);
        }

        /// <summary>
        /// Converte um objeto para int
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static int ToInt(this object objeto)
        {
            var valor = (objeto ?? "0").ToString();
            if (string.IsNullOrEmpty(valor))
            {
                valor = "0";
            }
            return int.Parse(valor);
        }
    }
}
