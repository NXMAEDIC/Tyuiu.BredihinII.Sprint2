using Tyuiu.BredihinII.Sprint2.Task1.V13.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            var result = ds.GetLogicOperations(a, b, c, d);

            Assert.AreEqual(true, result[0]);
            Assert.AreEqual(true, result[1]);
            Assert.AreEqual(true, result[2]);
            Assert.AreEqual(true, result[3]);
            Assert.AreEqual(true, result[4]);
            Assert.AreEqual(false, result[5]);
        }
    }
}
