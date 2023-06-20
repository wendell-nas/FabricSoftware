namespace iRh.Windows.Core
{
    public static class periculosidade
    {
        public static double Calcula(double salario, double horaTrabalhadas)
        {   
            var adicionalPericulosidade = (salario / 220) * 0.30 * horaTrabalhadas;

            return adicionalPericulosidade;
        }

    }
}
