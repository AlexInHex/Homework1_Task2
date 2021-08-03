using System;

namespace Homework2
{
    class Program
    {

        
            enum Days
        {
            Monday = 1, 
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            string dayToday;


            DateTime dt = DateTime.Now;
            DayOfWeek day = dt.DayOfWeek;
            

            Console.WriteLine("Какой сегодня день?");
            dayToday = Console.ReadLine();

            switch (dayToday)
            {
                case "Mon":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Сегодня " + (Days)1 + " 1-й день недели, до выходного еще 4 дня");
                    if (day == DayOfWeek.Monday)
                        Console.WriteLine("Сегодня ПОНЕДЕЛЬНИК!!!");
                    break;

                case "Tue":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Сегодня " + (Days)2 + " 2-й день недели, до выходного еще 3 дня");
                    if (day == DayOfWeek.Tuesday)
                        Console.WriteLine("Сегодня ВТОРНИК!!!");
                    break;

                case "Wed":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Сегодня " + (Days)3 + " 3-й день недели, до выходного еще 2 дня");
                    if (day == DayOfWeek.Wednesday)
                        Console.WriteLine("Сегодня СРЕДА!!!");
                    break;

                case "Thu":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Сегодня " + (Days)4 + " 4-й день недели, до выходного еще 1 день!");
                    if (day == DayOfWeek.Thursday)
                        Console.WriteLine("Сегодня Четверг!!!");
                    break;

                case "Fri":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Сегодня " + (Days)5 + " 5-й день недели, завтра выходной!!!");
                    if (day == DayOfWeek.Friday)
                        Console.WriteLine("Сегодня ПЯТНИЦА!!!");
                    break;

                case "Sat":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Сегодня " + (Days)6 + " 6-й день недели, сегодня можно лечь попозже");
                    if (day == DayOfWeek.Saturday)
                        Console.WriteLine("Сегодня СУББОТА!!!");
                    break;

                case "Sun":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Сегодня " + (Days)7 + " 7-й день недели, завтра на работку!");
                    if (day == DayOfWeek.Sunday)
                        Console.WriteLine("Сегодня ВОСКРЕСЕНЬЕ!!!");
                    break;

                default:
                    Console.WriteLine("Введите существующий день!");
                    break;
            }



        }
    }
}
