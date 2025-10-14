using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return y >= (y * y) && x <= 4;
        }
    }
}
