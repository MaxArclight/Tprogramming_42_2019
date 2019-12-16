using System;

namespace CourseApp
{
    public class AgeCalc
    {
        public static DateTime AgeCalcFunc(DateTime date)
        {
            DateTime curDate = DateTime.Now;
            DateTime datemin = new DateTime(2, 2, 1);
            DateTime age = new DateTime(curDate.Ticks - date.Ticks - datemin.Ticks);

           // age = new DateTime(age.Year - , age.Month - 1, age.Day);
            return age;
        }

        internal static void AgeMain()
        {
            Console.WriteLine("input year");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input month");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input day");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            if (inputDate == DateTime.Now)
            {
                throw new ArgumentException("inputDate");
            }

            DateTime output = AgeCalcFunc(inputDate);

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}