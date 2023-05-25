namespace iRh.Windows.Core
{
    public static class ValeTransporte
    {
        public static double Calcula(double salario)
        {
            double porcentagem = 0.06;
            double valorPassagem = 0;
            

            var valorValeTransporte = valorPassagem;
            var calculoValeTransporte = salario * porcentagem;


            return calculoValeTransporte;
        }
        private static double CalculaVale(double salario)
        {
            return salario * 0.06;
        }
    }
}
   
