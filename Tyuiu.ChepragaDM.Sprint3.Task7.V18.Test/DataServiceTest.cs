using Tyuiu.ChepragaDM.Sprint3.Task7.V18.Lib;

namespace Tyuiu.ChepragaDM.Sprint3.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            int len = y - x + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 7.76;
            wait[1] = 7.36;
            wait[2] = 7.26;
            wait[3] = 7.9;
            wait[4] = 15.88;
            wait[5] = 2.0;
            wait[6] = 4.35;
            wait[7] = 5.63;
            wait[8] = 6.49;
            wait[9] = 6.49;
            wait[10] = 6.32;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(x, y);
            CollectionAssert.AreEqual(wait, res);
           
        }
    }
}
