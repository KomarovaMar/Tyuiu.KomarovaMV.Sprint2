using Tyuiu.KomarovaMV.Sprint2.Task7.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #1                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные (вещественные*");
        Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y в            *");
        Console.WriteLine("* заштрихованной области.                                                   *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Введите x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        bool res=ds.CheckDotInShadedArea(x,y);
        if (res) { Console.WriteLine("Точка находиться в заштрихованной области"); }
        else { Console.WriteLine("Точка не находиться в заштрихованной области"); }


    }
}