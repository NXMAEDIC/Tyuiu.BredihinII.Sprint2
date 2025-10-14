using Tyuiu.BredihinII.Sprint2.Task3.V19.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(27.25, ds.Calculate(5), 0.001);
        }
    }
}
