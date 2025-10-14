using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (m > 1)
            {
                m = m - 1;
                return $"{m:D2}.{n:D2}";
            }

            int previousMonth = (n == 1) ? 12 : n - 1;
            int previousDay = daysInMonth[previousMonth - 1];

            return $"{previousDay:D2}.{previousMonth:D2}";
        }
    }
}
