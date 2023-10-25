using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFamily
{
    public enum Gender
    {
        Male,
        Famale
    }
    internal class Human
    {
        //private string Name { get; set; }
        //public  Gender Sex { get; set; }
        //public Human Spouse { get; set; }
       
        private Human spouse;
        
        public Human Spouse
        {
            get
            {
                if (spouse != null)
                {
                    return spouse;
                }
                else
                {
                    //Console.WriteLine("Cупруг/а не указан/а!");
                    return null;    
                }
            }

            set { spouse = value; }
        }


        private Gender sex;

        public Gender Sex
        {
            get { return sex; }
            set { sex = value; }
        }


        private string name;

        public string Name
        {
            get { return name;}
            set { name = value;}
        }

        public Human(string name, Gender sex, Human spouse)
        {
            Name = name;
            Sex = sex;
            Spouse = spouse;
        }

        public Human(string name, Gender sex) 
        { 
            Name = name;
            Sex = sex;
            Spouse = null;
        }

        public static bool Marriage(Human men, Human women)
        {
            bool flag = false;
            if (men.Spouse == null && women.Spouse ==null && men.Sex != women.Sex)
            {
                men.Spouse = women;
                women.Spouse = men;
                flag = true;
            }
            else
            {
                Console.WriteLine("Брак невозможен!");
            }
            return flag;    
        }

        public StringBuilder MarriageInfo()
        {
            StringBuilder stringOut = new StringBuilder();
            if (this.Spouse != null)
            {
                
                stringOut.Append("Cупруги: \n");
                stringOut.Append("~~~ ");
                stringOut.Append(this.Name);
                stringOut.Append(" + ");
                stringOut.Append(this.Spouse.Name);
                stringOut.Append("~~~ ");


            }
            else
            {
                stringOut.Append("Супруга нет!");
            }
            return stringOut;

        } 

        public override string ToString()
        {
            return $"Имя: {this.Name} \n" +
                $"Пол: {this.Sex}";
        }


    }
}
