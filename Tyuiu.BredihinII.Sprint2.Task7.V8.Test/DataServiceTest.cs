using Tyuiu.BredihinII.Sprint2.Task7.V8.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(1, 2);
            Assert.IsTrue(result);
        }
    }
}
