using Tyuiu.BredihinII.Sprint2.Task4.V29.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double result = ds.Calculate(x, y);

            Console.WriteLine($"Результат вычисления: {result}");
        }
    }
}