using Tyuiu.OgorodnikDV.Sprint3.Task4.V8.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            int s = 1;
            int e = 2;
            Assert.AreEqual(4.558, ds.Calculate(s, e));

        }
    }
}