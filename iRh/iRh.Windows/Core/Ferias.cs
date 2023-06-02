namespace iRh.Windows.Core
{
   public static class Ferias
    {
        public static double Calcula(double salario)
        {            
            var tercoFerias = salario / 3;
            var totalBruto = salario + tercoFerias;
            var valorTotal = totalBruto - salario;

            return valorTotal;
        }
    }
}
