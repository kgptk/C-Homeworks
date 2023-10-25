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
            /*
            Доработайте приложение генеалогического дерева таким образом чтобы программа выводила 
            на экран близких родственников(жену/ мужа). Продумайте способ более красивого 
            вывода с использованием горизонтальных и вертикальных черточек.
            */

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
