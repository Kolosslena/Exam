using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace src
{
    class Program
    {
        private static int A = 0;
        static void Main(string[] args)
        {
            try
            {
                        Person[] People;
        Console.WriteLine("Введите размер массива");
                string read = Console.ReadLine();
                while (!Int32.TryParse(read, out A))
                {
                    Console.WriteLine("Введите целое число");
                    read = Console.ReadLine();
                }
                People = new Person[A];
                FillPeople(People);
                Sortirovka(People);
                SaveInFile(People);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private static void FillPeople(Person [] People)
        {
            for (int i = 0; i < A; i++)
            {
                People[i] = new Person();
                Console.WriteLine("Введите фамилию:", i);
                string fam = Console.ReadLine();
                while (HasStrDigits(fam))
                {
                    Console.WriteLine("Фамилия не может содержать цифр");
                    fam = Console.ReadLine();
                }
                People[i].Fam = fam;

                Console.WriteLine("Введите имя:", i);
                string name = Console.ReadLine();
                while (HasStrDigits(name))
                {
                    Console.WriteLine("Имя не может содержать цифр");
                    name = Console.ReadLine();
                }
                People[i].Name = name;

                Console.WriteLine("Введите кол-во лет:", i);
                string age=Console.ReadLine();
                bool Age;
                do
                {
                    Age = age.AsEnumerable().Any(ch => char.IsLetter(ch));
                    age = age.Replace(" ", "");
                }
                while (!Age || age == null);
            }
        }
        static public void Sortirovka(Person[] People)
        {
            Person[] p = People.AsQueryable<Person>().OrderBy(c => c.Fam).ThenBy(c => c.Name).ToArray();
        }
        static public void SaveInFile(Person[] People)
        {
            using (StreamWriter sw = new StreamWriter("file.txt"))
            {
                foreach (Person a in People)
                {
                    sw.WriteLine(a.Fam + "; " + a.Name + "; " + a.Age + "; ");
                }
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
