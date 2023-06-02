using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class IRRF
    {
        const double salarioLimite1 = 1903.99;
        const double salarioLimite2 = 2826.66;
        const double salarioLimite3 = 3751.06;
        const double salarioLimite4 = 4664.68;
        const double aliquota1 = 7.5;
        const double aliquota2 = 15.00;
        const double aliquota3 = 22.5;
        const double aliquota4 = 27.5;
        const double valorADeduzir1 = 142.80;
        const double valorADeduzir2 = 354.80;
        const double valorADeduzir3 = 636.13;
        const double valorADeduzir4 = 869.36;
     
        public static double Calcula(double salario)
        {
            double irrf = 0;

            if (salario < salarioLimite1)
            {

            }
            else if (salario < salarioLimite2)
            {
                irrf = salario * CalculaLimite1(aliquota1);
            }
            else if (salario < salarioLimite3)
            {
                irrf = salario * CalculaLimite2(aliquota2);
            }
            else if (salario < salarioLimite4)
            {
                irrf = salario * CalculaLimite3(aliquota3);
            }
            else
            {
                irrf = salario * CalculaLimite4(aliquota3);
            }
            return irrf;
        }
        private static double CalculaLimite1(double aliquota1)
        {
            return (aliquota1 / 100) - valorADeduzir1;
        }
        private static double CalculaLimite2(double aliquota2)
        {
            return (aliquota2 / 100) - valorADeduzir2;
        }
        private static double CalculaLimite3(double aliquota3)
        {
            return (aliquota3 / 100) - valorADeduzir3;
        }
        private static double CalculaLimite4(double aliquota4)
        {
            return (aliquota4 / 100) - valorADeduzir4;
     }
    }
}
