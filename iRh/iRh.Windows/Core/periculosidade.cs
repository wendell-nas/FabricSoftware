namespace iRh.Windows.Core
{
    public static class periculosidade
    {
        public static double Calcula(double salario)
        {   
            var adicionalPericulosidade = salario * 0.3;

            return adicionalPericulosidade;
        }

    }
}
