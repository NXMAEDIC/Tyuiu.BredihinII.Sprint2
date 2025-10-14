using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15)
            {
                throw new ArgumentOutOfRangeException("Координаты должны быть в пределах от 1 до 15");
            }

            return grid[y - 1, x - 1];
        }
        private static readonly bool[,] grid = new bool[15, 15]
        {
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, true, true, true, false, false, false, true, true, true, true, false, false, false },
            { false, false, true, true, true, false, false, false, true, true, true, true, false, false, false },
            { false, false, true, true, true, true, true, true, true, true, true, true, false, false, false },
            { false, false, false, false, false, false, true, true, true, true, true, true, true, true, false },
            { false, false, false, false, false, false, true, true, true, true, true, true, true, true, false },
            { false, false, false, false, false, false, true, true, true, true, true, true, true, true, false },
            { false, false, false, false, false, true, true, true, true, true, true, true, true, false, false },
            { false, false, false, false, false, true, true, true, true, true, true, true, true, false, false },
            { false, false, true, true, true, true, true, true, true, true, true, true, true, false, false },
            { false, false, false, false, false, false, true, true, true, true, false, true, true, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }
        };
    }
}
