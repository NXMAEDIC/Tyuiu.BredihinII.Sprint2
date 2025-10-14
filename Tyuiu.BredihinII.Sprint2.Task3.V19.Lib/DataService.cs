using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y = 0;

            // Условие: x > 1
            if (x > 1)
            {
                y = Math.Pow(x, 2) + Math.Pow((x + 1) / (x - 1), x);  // Степень x в скобках
            }
            // Условие: x == 0
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) + 13) / (Math.Pow(x, 2) + Math.Sin(Math.Pow(x, 2)) + 9);  // Исправлено в знаменателе
            }
            // Условие: -23 < x < 2
            else if (x > -23 && x < 2)
            {
                y = Math.Pow((1 + 1 / Math.Pow(x, 2)), x);  // Степень x в скобках
            }
            // Условие: x < -23
            else if (x < -23)
            {
                y = x + 10 * x - (1 / x);  // Формула осталась неизменной
            }

            // Округляем до трех знаков после запятой
            return Math.Round(y, 3);
        }
    }
}
