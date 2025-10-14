
using Tyuiu.BredihinII.Sprint2.Task2.V23.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите координаты X и Y:");

            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            if (ds.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine("Точка находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области.");
            }
        }
    }
}