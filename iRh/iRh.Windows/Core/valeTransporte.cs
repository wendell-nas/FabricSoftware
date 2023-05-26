namespace iRh.Windows.Core
{
    public static class ValeTransporte
    {
        public static double Calcula(double salario, double valorPassagem, double quantidadeVales)
        {
            double porcentagem = 0.06;

            var descontoVt = salario * porcentagem;

            return descontoVt;
        }
        private static double CalculaVale(double salario)
        {
            return salario * 0.06;
        }
    }
}
   
