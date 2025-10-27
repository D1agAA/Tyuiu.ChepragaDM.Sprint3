using Tyuiu.ChepragaDM.Sprint3.Task2.V8.Lib;

namespace Tyuiu.ChepragaDM.Sprint3.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 15;
            var wait = ds.GetMultiplySeries(x, y);
            Assert.AreEqual(0.001, wait);
        }
    }
}
