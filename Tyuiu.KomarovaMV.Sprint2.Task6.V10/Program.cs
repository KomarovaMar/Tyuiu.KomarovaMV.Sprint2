using Tyuiu.KomarovaMV.Sprint2.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #10                                                               *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Дата некоторого дня характеризуется тремя натуральными числами: g (год),   *");
        Console.WriteLine("*m (порядковый номер месяца) и n (число). По заданным g, n и m определить   *");
        Console.WriteLine("* дату предыдущего дня.                                                     *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Введите год:");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        string res;
        if ((n < 1 || n > 31) || (m < 1 || m > 12)) { res = "Данные введены неккоректно!"; }
        else { res = ds.FindDateOfPreviousDay(g, m, n); }
        Console.WriteLine(res);
    }
}