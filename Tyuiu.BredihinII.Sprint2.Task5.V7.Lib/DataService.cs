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
                0 => "Январь",
                1 => "Февраль",
                2 => "Март",
                3 => "Апрель",
                4 => "Май",
                5 => "Июнь",
                6 => "Июль",
                7 => "Август",
                8 => "Сентябрь",
                9 => "Октябрь",
                10 => "Ноябрь",
                11 => "Декабрь",
                _ => "Неизвестный месяц"
            };

            return monthName;
        }
    }
}

