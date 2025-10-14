using Tyuiu.BredihinII.Sprint2.Task0.V11.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            var ds = new DataService();
            int x = 8105;
            int y = 275;

            var result = ds.GetCompareOperations(x, y);

            Assert.AreEqual(true, result[0]);
            Assert.AreEqual(false, result[1]);
            Assert.AreEqual(true, result[2]);
            Assert.AreEqual(false, result[3]);
            Assert.AreEqual(true, result[4]);
            Assert.AreEqual(false, result[5]);
        }
    }
}
