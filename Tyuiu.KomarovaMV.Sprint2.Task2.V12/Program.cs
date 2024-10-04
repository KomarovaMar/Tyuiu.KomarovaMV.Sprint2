using Tyuiu.KomarovaMV.Sprint2.Task2.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #2                                                                *");
        Console.WriteLine("* Вариант #12                                                               *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры     *");
        Console.WriteLine("*и вычисляет находится ли точка с координатами X,Y в заштрихованной области.*");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Введите значение координаты х:");
        int x= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение координаты y:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        if (ds.CheckDotInShadedArea(x, y))
        {
            Console.WriteLine("Точка лежит в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не лежит в заштрихованной области");
        }

        }
}