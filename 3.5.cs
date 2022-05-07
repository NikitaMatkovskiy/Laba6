using System;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Straight
        {
            public double X1, Y1, X2, Y2;
            public void Show()
            {
                if (X2 == X1)
                    Console.WriteLine("\tУравнение прямой x={0}", X1);
                else if (Y2 == Y1)
                    Console.WriteLine("\tУравнение прямой y={0}", Y1);
                else
                {
                    double a = (Y2 - Y1) / (X2 - X1);
                    double b = Y1 - a * X1;
                    if (b < 0)
                        Console.WriteLine("\tУравнение прямой y={0}x{1}", a, b);
                    else if (b == 0)
                        Console.WriteLine("\tУравнение прямой y={0}x", a);
                    else
                        Console.WriteLine("\tУравнение прямой y={0}x+{1}", a, b);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество прямых: ");
            int n = int.Parse(Console.ReadLine());
            Straight[] points = new Straight[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите координаты {0}-й прямой", i + 1);
                Console.Write("\tX1=");
                points[i].X1 = double.Parse(Console.ReadLine());
                Console.Write("\tY1=");
                points[i].Y1 = double.Parse(Console.ReadLine());
                Console.Write("\tX2=");
                points[i].X2 = double.Parse(Console.ReadLine());
                Console.Write("\tY2=");
                points[i].Y2 = double.Parse(Console.ReadLine());
                points[i].Show();
            }
            Console.ReadLine();
        }
    }
}
