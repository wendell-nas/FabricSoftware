namespace iRh.Windows.Core
{
    public static class Fgts
    {
        public static double CalculaFgts(double salario)
        {
            var fgtsMensal = CalculaFgtsMensal(salario);
            return fgtsMensal;
        }
        
        private static double CalculaFgtsMensal(double salario)
        {
            return salario * 8.0 / 100;
        }

    }
}
