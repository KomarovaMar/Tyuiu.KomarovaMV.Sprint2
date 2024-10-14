using Tyuiu.KomarovaMV.Sprint2.Task4.V2.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds=new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(1.750,res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(13.000, res);
        }
    }
}