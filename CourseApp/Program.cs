using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            if (a == 0 && b == 0 && x == 0)
            {
                return 0;
            }

            double upper = a - (b * x);
            upper = Math.Abs(upper);

            double lower = Math.Log10(x);
            lower = Math.Pow(lower, 3);

            double y;
            y = upper / lower;
            y = Math.Pow(y, -2);
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            double mas = (xk - xn) / dx;
            double[] y = new double[(int)mas];
            double[] preExitY = new double[1];

            if ((xk - xn) < dx)
            {
                preExitY[0] = MyFunction(a, b, xn);

                if (preExitY[0] < 0)
                {
                    throw new ArgumentOutOfRangeException("y");
                }

                return preExitY;
            }

            int i = 0;
            for (double x = xn; x <= xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);

                if (y[i] < 0)
                {
                    throw new ArgumentOutOfRangeException("y");
                }

                Console.WriteLine(y[i]);
                i++;
            }

            if ((xk - xn) / dx != y.Length)
            {
                throw new IndexOutOfRangeException("y");
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TaskA(7.2, 4.2, 1.81, 5.31, 0.7);

            const double a = 2.2;
            const double b = 3.8;
            var resSingle = MyFunction(a, b, 4);
            Console.WriteLine(resSingle);
            var x = new double[] { 1, 2, 3, 4, 5 };
            var taskBRes = TaskB(a, b, x);
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}