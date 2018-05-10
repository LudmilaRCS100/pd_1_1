using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dati;
            Console.WriteLine("Ka Tevi sauc?");//izvade
            dati=Console.ReadLine();//ievade
            Console.WriteLine(dati);

            Console.WriteLine("Kāds it tagad gads?");//izvade
            string mainigais;
            mainigais=Console.ReadLine();
            int skaitlis = Convert.ToInt16(mainigais);

            Console.WriteLine("Kads Tavs ir dzimšanas datums?");//izvade
            string mainigais2;
            mainigais2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt16(mainigais2);

            Console.WriteLine("Cik Tev gadu?");//izvade



            int skaitlis3 = skaitlis - skaitlis2;
            Console.WriteLine(skaitlis3);
            
            Console.ReadLine();//ievade

            int c, a, b;
            a = 5;
            b = 2;
            c = a * b;//diametrs

            Console.WriteLine(c);

            Console.ReadLine();//ievade

            int z;
            a = 5;
            b = 2;

            float pi = 3.14f;
            float rinkalaukums = 2 * pi * a;



            Console.WriteLine(rinkalaukums);

            Console.ReadLine();//ievade

            
        }           
        
              


        
    }
}
