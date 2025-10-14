using Tyuiu.BredihinII.Sprint2.Task5.V7.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество месяцев, прошедших с 1990 года: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int startYear = 1990;
            DataService ds = new DataService();

            string monthName = ds.FindMonthName(startYear, n);

            Console.WriteLine($"Название месяца: {monthName}");
        }
    }
}