using Tyuiu.SivolapEM.Sprint2.Task3.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Сиволап Е. М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
        Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
        Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x;
        Console.WriteLine("* Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res;
        res = dataService.Calculate(x);
        Console.WriteLine(res);
    }
}