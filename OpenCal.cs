using System;
using System.Globalization;

class Calendar
{
    static void Main()
    {
        // Get the current date.
        DateTime thisDay = DateTime.Today;

        // Get the first and last day of the month.
        DateTime firstDay = new DateTime(thisDay.Year, thisDay.Month, 1);
        DateTime lastDay = new DateTime(thisDay.Year, thisDay.Month,
                                        DateTime.DaysInMonth(thisDay.Year, thisDay.Month));

        // Get the first day of the week for the first day of the month.
        int firstDayOfWeek = (int)firstDay.DayOfWeek;

        // Get the last day of the week for the last day of the month.
        int lastDayOfWeek = (int)lastDay.DayOfWeek;

        // Get the number of days to display before the first day of the month.
        int daysBefore = firstDayOfWeek;

        // Get the number of days to display after the last day of the month.
        int daysAfter = 6 - lastDayOfWeek;

        // Get the total number of days to display.
        int daysToDisplay = DateTime.DaysInMonth(thisDay.Year, thisDay.Month) + daysBefore + daysAfter;

        // Display the calendar header.
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Display the days that come before the first day of the month.
        for (int i = 1; i <= daysBefore; i++)
        {
            Console.Write("    ");
        }

        // Display the days of the month.
        for (int i = 1; i <= DateTime.DaysInMonth(thisDay.Year, thisDay.Month); i++)
        {
            Console.Write("{0,3} ", i);

            // Start a new line after every 7 days.
            if ((i + daysBefore) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        // Display the days that come after the last day of the month.
        for (int i = 1; i <= daysAfter; i++)
        {
            Console.Write("    ");

            // Start a new line after every 7 days.
            if ((DateTime.DaysInMonth(thisDay.Year, thisDay.Month) + daysBefore + i) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        // Wait for the user to press a key before exiting.
        Console.ReadKey();
    }
}
