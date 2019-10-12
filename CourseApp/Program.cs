using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Program
    {
        public static double FuncthionZnach(double x)
        {
            double result = Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 0.25) + Math.Pow(Math.Log10(Math.Pow(x, 2)), 0.33);
            return result;
        }

        public static double[] FuncthionForShag(double x_natch, double x_konch, double x_shag)
        {
            var result = new double[(int)((x_konch - x_natch) / x_shag) + 1];
            int kolch = 0;
            for (double i = x_natch; i <= x_konch; i += x_shag)
            {
                result[kolch] = FuncthionZnach(i);
                kolch++;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            double x1 = 1.84;
            double x2 = 2.71;
            double x3 = 3.81;
            double x4 = 4.56;
            double x5 = 5.62;
            Console.WriteLine($"Задание A:");
            foreach (double element in FuncthionForShag(1.25, 3.25, 0.4))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"\nЗадание B:");
            Console.WriteLine($"y[{x1}] = {FuncthionZnach(1.84)}");
            Console.WriteLine($"y[{x2}] = {FuncthionZnach(2.71)}");
            Console.WriteLine($"y[{x3}] = {FuncthionZnach(3.81)}");
            Console.WriteLine($"y[{x4}] = {FuncthionZnach(4.56)}");
            Console.WriteLine($"y[{x5}] = {FuncthionZnach(5.62)}");
            Console.ReadLine();
        }
    }
}
