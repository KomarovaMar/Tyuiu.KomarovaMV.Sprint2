using Tyuiu.KomarovaMV.Sprint2.Task1.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #19                                                               *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Написать программу из операций сравнений и логических операций,а так же    *");
        Console.WriteLine("*арифметических выражений, которая вернет                                   *");
        Console.WriteLine("*последовательность(массив):(True, False, True, False, True, False)         *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*a=696; b=354; c=423; d=957                                                 *");
        Console.WriteLine("*****************************************************************************");
        int a = 696;
        int b = 354;
        int c = 423;
        int d = 957;
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}