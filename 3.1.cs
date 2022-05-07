using System;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Triangle
        {
            public double a, b, c;
            public Triangle(double A, double B, double C)
            {
                a = A;
                b = B;
                c = C;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите количество треугольников: ");
                int n = int.Parse(Console.ReadLine());
                Triangle[] triangles = new Triangle[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("введите стороны стороны треугольника", i + 1);
                    Console.Write("\ta=");
                    triangles[i].a = double.Parse(Console.ReadLine());
                    Console.Write("\tb=");
                    triangles[i].b = double.Parse(Console.ReadLine());
                    Console.Write("\tc=");
                    triangles[i].c = double.Parse(Console.ReadLine());

                }
                int k1 = 0;
                int k2 = 0;
                int k3 = 0;
                for (int i = 0; i < n; i++)
                {
                    if (triangles[i].a == triangles[i].b && triangles[i].b == triangles[i].c) { k1 = k1 + 1; }
                    if ((triangles[i].a != triangles[i].b && triangles[i].b == triangles[i].c) || (triangles[i].a == triangles[i].b && triangles[i].b != triangles[i].c) || triangles[i].a == triangles[i].c && triangles[i].b != triangles[i].c) { k2 = k2 + 1; }
                    if (triangles[i].a != triangles[i].b && triangles[i].b != triangles[i].c) { k3 = k3 + 1; }
                }
                Console.WriteLine("количество равносторонних=" +k1);
                Console.WriteLine("количество равнобедренных=" +k2);
                Console.WriteLine("количество разносторонних=" +k3);
                Console.ReadLine();
            }
        }
    }
    }