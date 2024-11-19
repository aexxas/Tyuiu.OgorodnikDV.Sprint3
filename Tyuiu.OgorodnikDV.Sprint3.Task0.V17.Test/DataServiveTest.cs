using Tyuiu.OgorodnikDV.Sprint3.Task0.V17.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1; int end = 10;
            var res = ds.GetSumSeries(start, end);
            Assert.AreEqual(-0.709, res);
        }
    }
}