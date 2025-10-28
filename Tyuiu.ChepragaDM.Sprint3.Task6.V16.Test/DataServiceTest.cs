using Tyuiu.ChepragaDM.Sprint3.Task6.V16.Lib;

namespace Tyuiu.ChepragaDM.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 16;
            var res = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(42, res);
        }
    }
}
