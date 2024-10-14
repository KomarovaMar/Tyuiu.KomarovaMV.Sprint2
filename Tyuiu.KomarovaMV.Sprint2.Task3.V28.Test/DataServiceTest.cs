using Tyuiu.KomarovaMV.Sprint2.Task3.V28.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds= new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            Assert.AreEqual(5.996, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(-5.000, res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.001, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -35;
            double res = ds.Calculate(x);
            Assert.AreEqual(-384.800, res);
        }
    }
}