using Tyuiu.ChepragaDM.Sprint3.Task0.V14.Lib;
namespace Tyuiu.ChepragaDM.Sprint3.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1;
            int finish = 5; 
            int value = 2;
            double wait = ds.GetMultiplySeries(value, start, finish);
            Assert.AreEqual(14400, wait);
        }
    }
}
