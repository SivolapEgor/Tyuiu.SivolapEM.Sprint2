using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SivolapEM.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y == 3 && ((x >= 3 && x <= 5) || x == 9))
                return true;

            if (y == 4 && ((x >= 3 && x <= 5) || x == 9))
                return true;

            if (y == 5 && ((x >= 3 && x <= 5)))
                return true;

            if (y == 6 && ((x >= 6 && x <= 9) || x == 3 || x == 13))
                return true;

            if (y == 7 && ((x >= 6 && x <= 9) || x == 13))
                return true;

            if (y == 8 && (x >= 6 && x <= 13))
                return true;

            if (y == 9 && (x == 6 || (x >= 9 && x <= 12)))
                return true;

            if (y == 10 && (x == 6 || (x >= 9 && x <= 12)))
                return true;

            if (y == 11 && ((x >= 3 && x <= 6) || (x >= 9 && x <= 12)))
                return true;

            if (y == 12 && (x >= 9 && x <= 12))
                return true;

            if (y == 13 && (x >= 10 && x <= 12))
                return true;

            return false;
        }
    }
}
