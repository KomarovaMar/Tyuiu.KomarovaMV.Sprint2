using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomarovaMV.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((3 <= x && x <= 5) && (3 <= y && y <= 7)) || ((6 <= x && x <= 12) && (5 <= y && y <= 8)) || ((9 <= x && x <= 12) && (3 <= y && y <= 4)) || ((x == 13) && (6 <= y && y <= 8)) || ((11 <= x && x <= 12) && (9 <= y && y <= 12)) || ((6 <= x && x <= 7) && (9 <= y && y <= 12)) || ((3 <= x && x <= 5) && (y == 11)) || ((x == 7) && (y == 12)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
