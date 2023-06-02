namespace iRh.Windows.Core
{
    public static class Pis
    {
        public static double Calcula(double tempoDeEmpresa, double tempoDePis, double salario)
        {
            var mesesTrabalhados = tempoDeEmpresa;
            var valorPis = salario / 12 * mesesTrabalhados;

            return valorPis;
        }
    }
}
