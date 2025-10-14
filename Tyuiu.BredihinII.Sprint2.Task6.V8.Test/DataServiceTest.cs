using Tyuiu.BredihinII.Sprint2.Task6.V8.Lib;

namespace Tyuiu.BredihinII.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var result1 = ds.FindDateOfPreviousDay(3, 1);
            var result2 = ds.FindDateOfPreviousDay(5, 1);
            var result3 = ds.FindDateOfPreviousDay(3, 15);
            var result4 = ds.FindDateOfPreviousDay(1, 1);

            Assert.AreEqual("2 месяц, 28 число", result1);
            Assert.AreEqual("4 месяц, 30 число", result2);
            Assert.AreEqual("3 месяц, 14 число", result3);
            Assert.AreEqual("12 месяц, 31 число", result4);
        }
    }
}
