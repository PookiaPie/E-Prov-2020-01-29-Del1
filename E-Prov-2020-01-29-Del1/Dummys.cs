using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29_Del1
{
    class Dummys:Catagory
    {
        //klassen är ihoppkopplad till catagory vilket gör så att både students och dummys kan låna trades från catagory
        public Dummys()
        {
            hp = generator.Next(80, 100);
            inteligans = generator.Next(1, 7);

            Console.WriteLine("This is a dummy, it has " + hp + " and inteligans of " + inteligans + " points! ");
        }

    }
}
