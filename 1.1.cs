using System;
class Triangle
{
    private double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public void Show()
    {
        if (a == b && a == c)
            Console.WriteLine("равносторонний");
        if ((a == b && a != c) || (a != b && a == c) || (a == b && b != c))
            Console.WriteLine("равнобедренный");
        if (a != b && a != c)
            Console.WriteLine("разносторонний");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сторону а ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону б ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону с ");
        double c = double.Parse(Console.ReadLine());
        Triangle x = new Triangle(a, b, c);
        Console.Write("треугольник: ");
        x.Show();
        Console.ReadLine();
    }
}
