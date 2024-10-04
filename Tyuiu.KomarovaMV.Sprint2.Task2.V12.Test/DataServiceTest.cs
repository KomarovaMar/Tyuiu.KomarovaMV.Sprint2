using Tyuiu.KomarovaMV.Sprint2.Task2.V12.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 12;
            bool res=ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}