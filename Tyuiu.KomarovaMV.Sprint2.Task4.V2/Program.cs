using Tyuiu.KomarovaMV.Sprint2.Task4.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #4                                                                *");
        Console.WriteLine("* Вариант #2                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции   с .     *");
        Console.WriteLine("*использованием тернарного оператора, где пользователь вводит значение      *");
        Console.WriteLine("*переменных X и Y с клавиатуры.                                             *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Введите значение X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x,y);
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine(res);
    }
}