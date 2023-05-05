using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaUyg
{
     class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba(50, 30);
            Console.WriteLine(araba.gosterge());
            araba.sur();
            Console.WriteLine(araba.gosterge());
            araba.set_Hız(100);
            araba.sur();
            Console.WriteLine(araba.gosterge());
            araba.set_Hız(120); 
            araba.sur();
            Console.WriteLine(araba.gosterge());
            araba.set_Hız(150);
            araba.sur();
            Console.WriteLine(araba.gosterge());

        }
    }
}
