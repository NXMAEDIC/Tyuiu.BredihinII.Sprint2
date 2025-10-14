using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                (x == y * 30 - 145),
                (x != y * 30 - 145),
                (x > y * 20),
                (x < y * 10),
                (x >= y * 5),
                (x <= y * 10)
            };
        }
    }
}
