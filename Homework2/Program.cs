using System;
using 

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
            string dayOfWeekNow;


            DateTime now = new DateTime();


            Console.WriteLine("Какой сегодня день?");
            dayToday = Console.ReadLine();

            switch (dayToday)
            {
                case "Mon":
                    Console.WriteLine("Сегодня " + (Days)1 + " 1-й день недели, до выходного еще 4 дня");
                    break;

                case "Tue":
                    Console.WriteLine("Сегодня " + (Days)2 + " 2-й день недели, до выходного еще 3 дня");
                    break;

                case "Wed":
                    Console.WriteLine("Сегодня " + (Days)3 + " 3-й день недели, до выходного еще 2 дня");
                    break;

                case "Thu":
                    Console.WriteLine("Сегодня " + (Days)4 + " 4-й день недели, до выходного еще 1 день!");
                    break;

                case "Fri":
                    Console.WriteLine("Сегодня " + (Days)5 + " 5-й день недели, завтра выходной!!!");
                    break;

                case "Sat":
                    Console.WriteLine("Сегодня " + (Days)6 + " 6-й день недели, сегодня можно лечь попозже");
                    break;

                case "Sun":
                    Console.WriteLine("Сегодня " + (Days)7 + " 7-й день недели, завтра на работку!");
                    break;

                default:
                    Console.WriteLine("Введите существующий день!");
                    break;
            }



        }
    }
}
