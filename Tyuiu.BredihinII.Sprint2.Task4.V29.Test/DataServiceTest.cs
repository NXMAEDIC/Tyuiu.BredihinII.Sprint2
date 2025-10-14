using Tyuiu.BredihinII.Sprint2.Task4.V29.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var result1 = ds.Calculate(5, 5);
            var result2 = ds.Calculate(8, 1);

            Assert.AreEqual(-7, result1);
            Assert.AreEqual(62, result2);
        }
    }
}
