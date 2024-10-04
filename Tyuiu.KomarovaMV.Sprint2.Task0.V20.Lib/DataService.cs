using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomarovaMV.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = y+800 == x;
            result[1] = y+800!=x;
            result[2] = y < x;
            result[3] = y > x;
            result[4] = y <= x;
            result[5] = y >= x;
            return result;
        }
    }
}
