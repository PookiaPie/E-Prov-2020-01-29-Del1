using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29_Del1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();     //skapar en student i main
            
            Console.WriteLine(@"
Welcome to super hero acadamy!!! What is your name dear?
[Wright down your name and press enter]");

            string nm = s1.GetName();       //gör så att man kan namnge sin student samt sammarkoppkar den till en console readline.

            nm = Console.ReadLine();

            Console.WriteLine("OH!! WOUNDERFULL Weclome " + nm);

            

            Console.ReadLine();

        }
    }
}
