using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_05._04._2023_7_
{
    internal class Program
    {
        static List<Person> Ask(){
            var ans = new List<Person>();
                ans.Add(CreatePerson());
            return ans;
        }
        static Person CreatePerson()
        {
            string name, season;
            int age = 0;
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Возраст введен не корректно!");
                    Console.WriteLine("Введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
            } while ((age <= 0) && (age > 120));
            Console.WriteLine("Введите любимое время года");
            season = Console.ReadLine();
            var person = new Person();
            person.Age = age;
            person.Season = season;
            person.Name = name;
            return person;

        }


        static void Main(string[] args)
        {

            var PersonList = Ask();
            foreach (Person person in PersonList)
            {
                Console.WriteLine($"Имя {person.Name} возраст {person.Age} любимое время года {person.Season}");
            }



        }
    }
}
