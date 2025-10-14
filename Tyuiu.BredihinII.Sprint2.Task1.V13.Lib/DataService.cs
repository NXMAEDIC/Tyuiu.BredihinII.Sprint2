using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                (b < a || c > d),
                (a != b || c > d),
                (a < b && !(c == d)),
                (a > b || (c <= d ^ (a != b))),
                (a >= d || (b > a && c > d)),
                (a == b && c < d)
            };
        }
    }
}
