using System;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Straight
        {
            public double A, B, C;
            public double V()
            {
                double V;
                V = A * B * C;
                return V;
            }
            public double S()
            {
                double S;
                S = 2 * (A * B + B * C + C * A);
                return S;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество параллелепипедов: ");
            int n = int.Parse(Console.ReadLine());
            Straight[] points = new Straight[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("введите стороны и высоту параллелепипеда", i + 1);
                Console.Write("\ta=");
                points[i].A = double.Parse(Console.ReadLine());
                Console.Write("\tb=");
                points[i].B = double.Parse(Console.ReadLine());
                Console.Write("\tc=");
                points[i].C = double.Parse(Console.ReadLine());

            }
            double Vmin = points[0].V();
            double Smax = points[0].S();
            for (int i = 0; i < n; i++)
            {
                if (Vmin > points[i].V())
                {
                    Vmin = points[i].V();
                }
            }
            Console.WriteLine("\t наименьший объем {0}", Vmin);
            for (int i = 0; i < n; i++)
            {
                if (Smax < points[i].S())
                {
                    Smax = points[i].S();
                }
            }
            Console.WriteLine("\t наибольшая площадь {0}", Smax);
            Console.ReadLine();
        }
    }
}
