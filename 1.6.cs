using System;
class point
{
    private double x, y;
    public point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public void Show()
    {
        if ((x > 0) && (y > 0))
            Console.Write("Точка в первой координатной четверти");
        if ((x < 0) && (y > 0))
            Console.Write("Точка в второй координатной четверти");
        if ((x < 0) && (y < 0))
            Console.Write("Точка в третьей координатной четверти");
        if ((x > 0) && (y < 0))
            Console.Write("Точка в четвертой координатной четверти");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите точку х= ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите точку у= ");
        double y = double.Parse(Console.ReadLine());
        point a = new point(x, y);
        a.Show();
        Console.ReadLine();
    }
}
