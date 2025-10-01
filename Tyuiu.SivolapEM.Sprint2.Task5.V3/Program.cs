using Tyuiu.SivolapEM.Sprint2.Task5.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Сиволап Егор Максимович | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая в зависимости от порядкового номера дня     *");
        Console.WriteLine("* недели (1, 2, …, 7) выводит на экран его название (понедельник,         *");
        Console.WriteLine("* вторник, …, воскресенье).                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Введите день (1-7): ");
        int k;
        k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindDayName(k));
    }
}