using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = (Math.Pow(x, 2)) + Math.Pow((x + 1) / (x - 1), 2);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) + 13;
            }
            else if (x > -23 && x < 2)
            {
                y = Math.Pow((1 + 1) / Math.Pow(x, 2), 2) - 23;
            }
            else if (x < -23)
            {
                y = x + 10 * Math.Pow(-1 / x, 2);
            }

            return Math.Round(y, 3);
        }
    }
}
