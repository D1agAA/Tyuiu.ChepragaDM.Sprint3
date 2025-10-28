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

            wait[0] = 2.33;
            wait[1] = 1.93;
            wait[2] = 1.75;
            wait[3] = 2.07;
            wait[4] = 6.53;
            wait[5] = -1.00;
            wait[6] = 0.65;
            wait[7] = 1.89;
            wait[8] = 2.49;
            wait[9] = 2.09;
            wait[10] = 1.70;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(x, y);
            CollectionAssert.AreEqual(wait, res);
           
        }
    }
}
