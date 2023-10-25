using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFamily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human woman = new Human("Анастасия", Gender.Male);
            Human man = new Human("Andrey", Gender.Male);
            woman.Name = "Настя";
            woman.Sex = Gender.Famale;

            if (Human.Marriage(man, woman))
            {
                Console.WriteLine(man.MarriageInfo());
            }
            Console.ReadKey();
        }
    }
}
