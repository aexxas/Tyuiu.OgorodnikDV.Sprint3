using Tyuiu.OgorodnikDV.Sprint3.Task6.V28.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void  ValidGetSumSumSeries()
        {
            DataService ds = new();
            Assert.AreEqual(15, ds.GetSumTheDivisors(13, 19));
        }
    }
}