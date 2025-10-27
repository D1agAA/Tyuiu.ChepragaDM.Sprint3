using Tyuiu.ChepragaDM.Sprint3.Task3.V30.Lib;

namespace Tyuiu.ChepragaDM.Sprint3.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            char c = 'y';
            string str = "fyyklbtyn ygrc vfyyyyh";
            var wait = ds.GetMaxCharCount(str, c);
            Assert.AreEqual(4, wait);
        }
    }
}
