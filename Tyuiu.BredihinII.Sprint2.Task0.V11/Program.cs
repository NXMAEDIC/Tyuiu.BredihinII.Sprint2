using Tyuiu.BredihinII.Sprint2.Task0.V11.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 8105;
            int y = 275;

            var result = ds.GetCompareOperations(x, y);

            Console.WriteLine("Результат:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}