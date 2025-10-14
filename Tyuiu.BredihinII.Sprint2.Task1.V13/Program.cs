using Tyuiu.BredihinII.Sprint2.Task1.V13.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            var result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Результат:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}