using System.Data;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomarovaMV.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string dat;
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1: g--; m = 12; n = 31;
                            break;
                         default: m--;
                            switch (m)
                            {
                                case 2: n = 28;
                                    break;
                                case 12:
                                case 10:
                                case 8:
                                case 7:
                                case 5:
                                case 3:
                                case 1:
                                    n = 31;
                                    break;
                                case 11:
                                case 9:
                                case 6:
                                case 4:
                                    n = 30;
                                    break;
                                default:
                                    throw new ArgumentException("Месяц должен быть от 1 до 12");
                            }
                            break;
                    }
                    break;
                default:
                    n--;
                    break;


            }
            dat ="Вчерашняя дата:"+n+"."+m+"."+g;
            return dat;
            }
        
        }
    }

