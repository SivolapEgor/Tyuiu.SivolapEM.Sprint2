using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SivolapEM.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suit = "";
            string rank = "";

            switch (value2)
            {
                case 1: suit = "пик"; break;
                case 2: suit = "треф"; break;
                case 3: suit = "бубен"; break;
                case 4: suit = "червей"; break;
                default: Console.WriteLine("Неверный номер масти!"); break;
            }

            switch (value1)
            {
                case 6: rank = "Шестерка"; break;
                case 7: rank = "Семерка"; break;
                case 8: rank = "Восьмерка"; break;
                case 9: rank = "Девятка"; break;
                case 10: rank = "Десятка"; break;
                case 11: rank = "Валет"; break;
                case 12: rank = "Дама"; break;
                case 13: rank = "Король"; break;
                case 14: rank = "Туз"; break;
                default: Console.WriteLine("Неверный номер достоинства!"); break;
            }

            return $"{rank} {suit}";
        }
    }
}
