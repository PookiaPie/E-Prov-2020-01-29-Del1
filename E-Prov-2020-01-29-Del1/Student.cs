using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29_Del1
{
    class Student: Catagory
    {
        //klassen är ihoppkopplad till catagory vilket gör så att både students och dummys kan låna trades från catagory
        public Student()
        {
            hp = generator.Next(60, 100);
            inteligans = generator.Next(10, 20);
            name = "";

            Console.WriteLine("This is " + name + ", has " + hp + " and inteligans of " + inteligans + " points! ");        //fungerar inte än!
        }
        public string GetName()
        {
            return name;
        }

    }
}
