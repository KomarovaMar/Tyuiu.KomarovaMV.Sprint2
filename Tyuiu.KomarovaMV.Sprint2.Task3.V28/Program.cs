using Tyuiu.KomarovaMV.Sprint2.Task3.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #3                                                                *");
        Console.WriteLine("* Вариант #28                                                               *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции Y с .     *");
        Console.WriteLine("*использованием вложенных оператор if-else, где пользователь вводит значение*");
        Console.WriteLine("*переменной X с клавиатуры.                                                 *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Введите значение х:");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine(res);
    }
}