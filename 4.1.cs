using System;
using System.Collections;
namespace ConsoleApplication1
{
    class Pupil
    {
        private string _fullName;
        private string _gender;
        private int _yearBirth;
        public Pupil(string fullName, string gender, int yearBirth)
        {
            _fullName = fullName;
            Gender = gender;
            _yearBirth = yearBirth;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ф.И.О: {_fullName}\nПол: {_gender}\nГод рождения: {_yearBirth}\n");
        }
        public int isMan()
        {
            if (_gender == "М" || _gender == "м")
                return 1;
            else if (_gender == "Ж" || _gender == "ж")
                return 2;
            return -1;
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value.ToLower() == "м" || value.ToLower() == "ж")
                    _gender = value;
                else
                {
                    Console.WriteLine("Пол человека введен неверно! (М/Ж)");
                    _gender = "-";
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников: ");
            int N = int.Parse(Console.ReadLine());
            ArrayList school = new ArrayList();
            ArrayList boys = new ArrayList();
            ArrayList girls = new ArrayList();
            for (int i = 0; i < N; i++)
            {
                Console.Write("\nФИО: ");
                string fn = Console.ReadLine();
                Console.Write("Пол: ");
                string g = Console.ReadLine();
                Console.Write("Год рождения: ");
                int db = Convert.ToInt32(Console.ReadLine());
                school.Add(new Pupil(fn, g, db));
            }
            Console.WriteLine("\nОбщий список: ");
            foreach (Pupil item in school)
            {
                item.PrintInfo();
                if (item.isMan() == 1)
                    boys.Add(item);
                else if (item.isMan() == 2)
                    girls.Add(item);
            }
            Console.WriteLine("\nСписок мальчиков: ");
            foreach (Pupil item in boys)
            {
                item.PrintInfo();
            }
            Console.WriteLine("\nСписок девочек: ");
            foreach (Pupil item in girls)
            {
                item.PrintInfo();
            }
            Console.WriteLine($"Количество мальчиков: {boys.Count}");
            Console.WriteLine($"Количество девочек: {girls.Count}");
        }
    }
}
