using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.OgorodnikDV.Sprint3.Task3.V28.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "f35hyt";
            char chr = 'r';
            string expected = "frrhyt"; // ќжидаема€ строка после замены

            // Act
            string actual = ds.ReplaceNumOnChar(value, chr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}