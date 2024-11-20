using Tyuiu.OgorodnikDV.Sprint3.Task2.V15.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesTest()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int Start = 1;
            int End = 20;
            double wait = 0.298;

            double res = ds.GetSumSeries(a, Start, End);
            Assert.AreEqual(wait, res);
        }
    }
}