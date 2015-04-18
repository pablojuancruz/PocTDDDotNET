using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTDD
{
    public class CalculoFinanceiro
    {

        public static double CalcularValorComJurosCompostos(double valorEmprestimo, int numMeses, double percTaxa)
        {

            return  Math.Round(valorEmprestimo * Math.Pow(1 + (percTaxa / 100), numMeses), 2);
        }
    }
}



