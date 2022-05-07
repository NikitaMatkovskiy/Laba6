using System;
class Circle
{
    private double x, y, r;
    public Circle(double x, double y, double r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }
    public void Show()
    {
        {
            if (x >= 0 && x - r <= 0 || x <= 0 && x + r >= 0) Console.WriteLine("Пересекает ось OX");
            if (y >= 0 && y - r <= 0 || y <= 0 && y + r >= 0) Console.WriteLine("Пересекает ось OY");
            else Console.WriteLine("не пересекает");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите x ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите y ");
        double y = double.Parse(Console.ReadLine());
        Console.Write("Введите r ");
        double r = double.Parse(Console.ReadLine());
        Circle a = new Circle(x, y, r);
        a.Show();
        Console.ReadLine();
    }
}
