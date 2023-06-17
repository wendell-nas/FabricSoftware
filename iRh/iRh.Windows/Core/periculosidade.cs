namespace iRh.Windows.Core
{
    public static class periculosidade
    {
        public static double Calcula(double salario, double horaTrabalhada)
        {   
            var adicionalPericulosidade = (salario / 220) * 0.30 * horaTrabalhada;

            return adicionalPericulosidade;
        }

    }
}
