using Tyuiu.KomarovaMV.Sprint2.Task7.V1.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.85;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x,y));
        }
    }
}