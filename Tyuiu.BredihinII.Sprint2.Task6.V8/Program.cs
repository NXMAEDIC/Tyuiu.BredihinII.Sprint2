using Tyuiu.BredihinII.Sprint2.Task6.V8.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число месяца:");
            int m = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();

            string previousDate = ds.FindDateOfPreviousDay(n, m);

            Console.WriteLine($"Предыдущий день: {previousDate}");
        }
    }
}