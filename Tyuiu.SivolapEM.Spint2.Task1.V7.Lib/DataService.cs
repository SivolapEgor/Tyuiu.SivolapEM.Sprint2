using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SivolapEM.Spint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                (a + b == 211) | (c * d < 500),
                (a - b != 179) & (c + d > 100),
                (a / b < 10) || (c - d >= 0),
                (a % b > 20) && (c * 2 > d),
                !(a % b > 20) && (c * 2 <= d),
                (a / 10 >= 20) ^ (b + c >= d)
            };
        }
    }
}
