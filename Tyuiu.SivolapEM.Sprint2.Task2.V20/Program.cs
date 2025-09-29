using Tyuiu.SivolapEM.Sprint2.Task2.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Сиволап Е. М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил:Сиволап Егор Максимович | ИИПб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в                     *");
        Console.WriteLine("* заштрихованной области.                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("* Введите X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите Y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool inShadedArea = dataService.CheckDotInShadedArea(x, y);

        Console.WriteLine($"\nТочка ({x}, {y}) " + (inShadedArea ? "НАХОДИТСЯ" : "НЕ НАХОДИТСЯ") + " в заштрихованной области.");
    }
}