using System;
namespace ConsoleApplication1
{
    class Triangle
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public bool Logika()
        {
            bool res = (a < 0) || (b < 0) || (c < 0);
            if (res == true)
            {
                Console.WriteLine("Такого треугольника не существует");

            }
            else
            {
                Console.WriteLine("Треугольник существует");
            }
            return res;
        }
        class RectangTriangle : Triangle
        {
            public RectangTriangle(double a, double b, double c) : base(a, b, c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void Show()
            {
                if (a == b && a == c)
                    Console.WriteLine("равносторонний");
                if (a == b && a != c)
                    Console.WriteLine("равнобедренный");
                if (a != b && a != c)
                    Console.WriteLine("разносторонний");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите катет а ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите катет б ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите гипотенузу с ");
                double c = double.Parse(Console.ReadLine());
                RectangTriangle x = new RectangTriangle(a, b, c);
                if (x.Logika() == false) { x.Show(); }
                else { x.Logika(); }
                Console.ReadLine();
            }
        }
    }
}
