using System;
namespace ConsoleApplication1
{
    class Participants
    {
        private string name;
        private int years;
        private int result;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Years
        {
            get { return years; }
            set { years = value; }
        }
        public int Result
        {
            get { return result; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Недопустимое значение");
                else
                    result = value;
            }
        }
        public Participants(string name_, int years_, int result_)
        {
            Name = name_;
            Years = years_;
            Result = result_;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество участников: ");
            int n = int.Parse(Console.ReadLine());
            Participants[] pr = new Participants[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Введите информацию о {0}-м участнике ", i + 1);
                Console.Write("\tФИО: ");
                string name = Console.ReadLine();
                Console.Write("\tгод: ");
                int years = int.Parse(Console.ReadLine());
                Console.Write("\tрезультат: ");
                int result = int.Parse(Console.ReadLine());
                pr[i] = new Participants(name, years, result);
            }
            int pWin = pr[0].Result;
            for (i = 0; i < n; i++)
                if (pWin < pr[i].Result)
                    pWin = pr[i].Result;
            Console.WriteLine("Инф. победителей:");
            for (i = 0; i < n; i++)
                if (pWin == pr[i].Result)
                    Console.WriteLine("\tФИО: {0}; год: {1}; результат: {2}", pr[i].Name, pr[i].Years, pr[i].Result);
            Console.ReadKey();
        }
    }
}
