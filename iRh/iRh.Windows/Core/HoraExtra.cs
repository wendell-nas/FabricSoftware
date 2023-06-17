namespace iRh.Windows.Core
{
  public static class HoraExtra
    {
        public static double Calcula(double salario, double horasTrabalhadas)
        {           
            
            var valorHoraTrabalhada = (salario / 220);
            var valorHoraExtra = valorHoraTrabalhada * 0.20;
            var totalReceber = horasTrabalhadas * (valorHoraTrabalhada + valorHoraExtra);

          return totalReceber;
        }
       
    }
}
