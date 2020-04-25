using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во людей:");
            var PeopleCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Person[] Person = new Person[PeopleCount];
            for (int i = 0; i >= PeopleCount; i++)
            {
                Console.WriteLine("Введите имя:");
                Person[i].Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                Person[i].Fam = Console.ReadLine();
                Console.WriteLine("Введите кол-во лет:");
                var count = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(count))
                {

                }
            }
        }
    }
}
