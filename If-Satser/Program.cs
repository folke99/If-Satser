using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.WriteLine("mata in ditt mönster djup på dina bildeck");
            var svar = double.Parse(Console.ReadLine());

            if (svar>1.6) {
                Console.WriteLine("Lagligt deck!");
              }
           
            else{
                Console.WriteLine("Olagliga teck");
            }

            Console.ReadKey();
           

            //Övning 2

            Console.WriteLine("Skriv din ålder");

            var svar = int.Parse(Console.ReadLine());


            if (svar > 99)
            {
                Console.WriteLine("olaglig ålder!");
            }
            else if(svar < 99)
            {
                Console.WriteLine("Blå färg");
            }

            else if (svar < 26)
            {
                Console.WriteLine("Röd färg");
            }
            else if (svar < 19)
            {
                Console.WriteLine("Grön färg");
            }
            else
            {
                Console.WriteLine("Vit Färg");
            }

            Console.ReadKey();

            
            //Övning 3

            Console.WriteLine("Mata in två tal");
            var svar = double.Parse(Console.ReadLine());
            var svar2 = double.Parse(Console.ReadLine());

            if (svar > svar2)
            {
                Console.WriteLine(svar + " är störst");

            }

            else if (svar == svar2)
            {
                Console.WriteLine("Talen är lika");
            }

            else{
                Console.WriteLine(svar2 + " är störst");
            }

            Console.ReadKey();
            */

            //Övning 4

            Console.WriteLine("Mata in ett tal");

            var svar = int.Parse(Console.ReadLine());

            svar = svar % 7;
            
            if(svar > 0)
            {
                Console.WriteLine("talet är inte jämt delbart resten är: " + svar);

            }

            else
            {
                Console.WriteLine("Talet är jämt delbart!");
            }

            Console.ReadKey();
                        

        }
    }
}
