using Tyuiu.KomarovaMV.Sprint2.Task1.V19.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            bool[] res= new bool[6];
            res =ds.GetLogicOperations(a, b, c, d);
            bool[] check= new bool[6] { true, false, true,false,true,false};
            CollectionAssert.AreEqual(check, res);
        }
    }
}