using Tyuiu.KomarovaMV.Sprint2.Task5.V10.Lib;
namespace Tyuiu.KomarovaMV.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            string res = ds.FindDateOfPreviousDay(24, 1, 1);
            Assert.AreEqual("31.12.2023",res);
        }
    }
}