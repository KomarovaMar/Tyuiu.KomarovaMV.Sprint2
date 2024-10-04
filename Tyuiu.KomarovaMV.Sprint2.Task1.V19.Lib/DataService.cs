using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomarovaMV.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a != b) | (c == d);
            result[1] = (a >= c)&(b > d);
            result[2] = (a < d) || (c == d);
            result[3] = (c == d) && (a > b);
            result[4] = !(a <= b);
            result[5] = (a >= c)^(b !=d);
            return result;
        }
    }
}
