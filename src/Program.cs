using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        private static int A = 0;
        private static Person[] People;
        static void Main(string[] args)
        {
            A = Convert.ToInt32(Console.ReadLine());
            People = new Person[A];
        }
        private static void ReadA()
        {
            Console.WriteLine("Введите целочисленный размер массива:");
            string read = Console.ReadLine();
            while (!Int32.TryParse(read, out A))
            {
                Console.WriteLine("Некорректный ввод");
                read = Console.ReadLine();
            }
        }
        private static void FillPeople()
        {
            for (int i = 0; i < People.Length; i++)
            {
                Console.WriteLine("Введите" + (i + 1) + "й элемент массива");
                People[i] = new Person();
                Console.WriteLine("Введите фамилию:");
                string fam = Console.ReadLine();
                while (HasStrDigits(fam))
                {
                    Console.WriteLine("Фамилия не может содержать цифр");
                    fam = Console.ReadLine();
                }
                People[i].Fam = fam;

                Console.WriteLine("Введите имя:");
                string name = Console.ReadLine();
                while (HasStrDigits(name))
                {
                    Console.WriteLine("Имя не может содержать цифр");
                    name = Console.ReadLine();
                }
                People[i].Name = name;

                string read = Console.ReadLine();
                bool Read = read.AsEnumerable().Any(ch => char.IsLetter(ch));
                if (!Read)
                    People[i].Age = Convert.ToInt32(read);
                else
                {
                    Console.WriteLine("Год не должен содержать буквы")
                }
                while (Read) ;
            }
        }
        private static bool HasStrDigits(string str)
        {
            bool resp = false;
            for(int i=0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    resp = true;
                }
            }
            return resp;
        }
    }
}
