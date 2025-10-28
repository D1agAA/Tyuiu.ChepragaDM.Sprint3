using Tyuiu.ChepragaDM.Sprint3.Task5.V13.Lib;

namespace Tyuiu.ChepragaDM.Sprint3.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x, i, i1, k, k1;
            x = 5;
            i = 1;
            i1 = 3;
            k = 1;
            k1 = 12;
            var res = ds.GetSumSumSeries(x,i,k,i1,k1);
            Assert.AreEqual(127.212, res);
            
        }
    }
}
