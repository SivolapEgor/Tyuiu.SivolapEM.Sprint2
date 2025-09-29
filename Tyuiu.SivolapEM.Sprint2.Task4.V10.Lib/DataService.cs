using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SivolapEM.Sprint2.Task4.V10.Lib
{
    public class DataService : ISprint2Task4V10
    {
        public double Calculate(double x, double y)
        {
            double res = x * 2 < 2 ? Math.Pow(1 * 3 / Math.Pow(y, 2), x) : y + 10 * x - (5 / x);
            return Math.Round(res, 3);
        }
    }
}
