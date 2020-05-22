using System;

namespace CourseApp
{
    public class AgeCalc
    {
        public static DateTime AgeInput()
        {
            Console.WriteLine("input year");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input month");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input day");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            return inputDate;
        }

        public static DateTime AgeCalcFunc(DateTime date, DateTime curDate)
        {
            if (date > curDate)
            {
                throw new IndexOutOfRangeException();
            }

            if (date == curDate)
            {
                throw new ArgumentException();
            }

            DateTime datemin = new DateTime(2, 2, 1);
            DateTime age = new DateTime(curDate.Ticks - date.Ticks - datemin.Ticks);
            return age;
        }

        internal static void AgeMain()
        {
            DateTime nowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime output = AgeCalcFunc(AgeInput(), nowDate);

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}