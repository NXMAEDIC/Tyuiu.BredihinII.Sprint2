using Tyuiu.BredihinII.Sprint2.Task5.V7.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var result1 = ds.FindMonthName(1990, 10);
            var result2 = ds.FindMonthName(1990, 14);
            var result3 = ds.FindMonthName(1990, 25);

            Assert.AreEqual("Декабрь", result1);
            Assert.AreEqual("Март", result2);
            Assert.AreEqual("Февраль", result3);
        }
    }
}
