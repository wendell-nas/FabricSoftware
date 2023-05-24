﻿namespace iRh.Windows.Core
{
    public static class Inss
    {
        const double Faixa01 = 1302.0;
        const double Faixa02 = 2571.29;
        const double Faixa03 = 2856.94;
        const double Faixa04 = 7507.49;
        //FUNCAO  RETORNO  NOME()
        public static double Calcula(double salario)
        {
            const double Faixa01 = 1302.0;
            const double Faixa02 = 2571.29;
            const double Faixa03 = 2856.94;
            const double Faixa04 = 7507.49;

            double valorInss = 0;

            if (salario <= Faixa01)
            {
                valorInss = Core.Inss.CalculaFaixa1(salario);

            }
            else if (salario <= Faixa02)
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                valorInss = (salario - Faixa01) + descontoFaixa1;

            }
            else if (salario <= Faixa03)
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                var descontoFaixa2 = Core.Inss.CalculaFaixa2(salario);
                valorInss = 12 / 100 * (salario - Faixa02) + descontoFaixa1 + descontoFaixa2;

            }
            else if (salario <= Faixa04)
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                var descontoFaixa2 = Core.Inss.CalculaFaixa2(salario);
                var descontoFaixa3 = Core.Inss.CalculaFaixa3(salario);
                valorInss = 0.14 * (salario - Faixa03)
                    + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;

            }else
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                var descontoFaixa2 = Core.Inss.CalculaFaixa2(salario);
                var descontoFaixa3 = Core.Inss.CalculaFaixa3(salario);
                valorInss = valorInss = 0.14 * (Faixa04 - Faixa03)
                    + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }
            return valorInss;
        }

        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * salario);
        }
        private static double CalculaFaixa2(double salario)
        {
            return 0.9 * (Faixa02 - Faixa01);
        }
        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (Faixa03 - Faixa02);
        }
    }
}

