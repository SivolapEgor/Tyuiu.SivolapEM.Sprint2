using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SivolapEM.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool f1 = y <= 2 - Math.Pow(x, 2);
            bool f2 = y >= x;
            bool f3 = y <= x;
            bool f4 = y >= 0;
            if ((f1 && f2) || (f3 && f4 && f1)) return true;
            else return false;
        }
    }
}
