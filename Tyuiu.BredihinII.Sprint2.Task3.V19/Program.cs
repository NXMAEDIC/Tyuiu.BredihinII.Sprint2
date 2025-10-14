

using Tyuiu.BredihinII.Sprint2.Task3.V19.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение X:");

            if (double.TryParse(Console.ReadLine(), out double x))
            {
                double y = ds.Calculate(x);
                Console.WriteLine($"Значение функции Y при X = {x} равно: {y}");
            }
            else
            {
                Console.WriteLine("Введено некорректное значение.");
            }
        }
    }
}