using System;
namespace ConsoleApplication1
{
    class Participants
    {
        private string name;
        private int rost;
        private int ves;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Rost
        {
            get { return rost; }
            set { rost = value; }
        }
        public int Ves
        {
            get { return ves; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Недопустимое значение");
                else
                    ves = value;
            }
        }
        public Participants(string name_, int rost_, int ves_)
        {
            Name = name_;
            Rost = rost_;
            Ves = ves_;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество спортсменов: ");
            int n = int.Parse(Console.ReadLine());
            Participants[] pr = new Participants[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Введите информацию о {0}-м участнике ", i + 1);
                Console.Write("\tФИО: ");
                string name = Console.ReadLine();
                Console.Write("\tрост: ");
                int rost = int.Parse(Console.ReadLine());
                Console.Write("\tвес: ");
                int ves = int.Parse(Console.ReadLine());
                pr[i] = new Participants(name, rost, ves);
            }
            for (i = 0; i < n; i++)
                if (pr[i].Ves > 70)

                    Console.WriteLine("\tФИО: {0}; номер группы: {1}; результат: {2}", pr[i].Name, pr[i].Rost, pr[i].Ves);
            Console.ReadKey();
        }
    }
}
