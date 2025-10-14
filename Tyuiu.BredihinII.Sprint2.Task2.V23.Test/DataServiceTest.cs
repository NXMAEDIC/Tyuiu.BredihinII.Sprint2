using Tyuiu.BredihinII.Sprint2.Task2.V23.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestPointInShadedArea_ValidPoint()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
        }
    }
}
