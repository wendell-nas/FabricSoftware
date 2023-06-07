namespace iRh.Windows.Core
{
  public static class HoraExtra
    {
        public static double Calcula(double salario, double horasTrabalhadas)
        {
            salario = horasTrabalhadas;
            double totalReceber, valorHoraExtra, valorHoraTrabalhada;

            valorHoraTrabalhada = (salario / 220);
            valorHoraExtra = valorHoraTrabalhada * 0.20;
            totalReceber = (valorHoraExtra + valorHoraTrabalhada) * horasTrabalhadas;

          return totalReceber;
        }
       
    }
}
