using Tyuiu.KomarovaMV.Sprint2.Task0.V20.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService ();
            int x = 1075;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x,y);
            bool[] check = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(check,res);
        }
    }
}