namespace iRh.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double Calcula(double horaMensal, double horaNoturna, double salario)
        {
            var valorHora = salario / horaMensal;
            var valorHoratrabalhada = CalculaHora(valorHora);
            var valorAdcional = horaNoturna * valorHoratrabalhada;

            return valorAdcional;
        }
        private static double CalculaHora(double valorHora)
        {
            return valorHora * 0.2;
        }
    }
}
