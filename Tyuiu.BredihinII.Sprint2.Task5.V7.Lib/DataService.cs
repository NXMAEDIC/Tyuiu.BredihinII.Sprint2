using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BredihinII.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int monthIndex = (n ) % 12;
            int monthsPassed = (n ) / 12;

            int currentMonthDays = daysInMonth[monthIndex];

            int dayOfMonth = 1 + 2;

            if (dayOfMonth > currentMonthDays)
            {
                dayOfMonth -= currentMonthDays;
                monthIndex = (monthIndex + 1) % 12;
            }

            string monthName = monthIndex switch
            {
                0 => "январь",
                1 => "февраль",
                2 => "март",
                3 => "апрель",
                4 => "май",
                5 => "июнь",
                6 => "июль",
                7 => "август",
                8 => "сентябрь",
                9 => "октябрь",
                10 => "ноябрь",
                11 => "декабрь",
                _ => "Неизвестный месяц"
            };

            return monthName;
        }
    }
}

