using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Piemeri();
        }

        public static void Piemeri()
        {   //i++ jeb i = i + 1
            //i sākotnējā vērtība ir 40
            //pildīt tik ilgi,kamēr i ir mazāks vai vienāds ar 50
            //katru reizi i aug par 2
            for (int i = 40; i <= 50; i=i+2)
            {
                Console.WriteLine("i= " + i);
            }

            int n = 10;
            //pildīt kamēr n ir lielāks vai vienāds ar 0
            while(n>=0)
            {
                Console.WriteLine("n= " + n);
                n = n - 3;
            }

            bool turpinat = true;
            while(turpinat)
            {
                Console.Write("Ievadi skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vai turpināt ievadi (j/n)? ");
                string atbilde = Console.ReadLine();
                atbilde = atbilde.ToLower();

                if(atbilde=="j")
                {
                    turpinat = true;
                }
                else if (atbilde=="n")
                {
                    turpinat = false;
                }
                else
                {
                    Console.WriteLine("Atbilde nav zināma");
                }
            }*/

            /* Uzdevumi Uzd1 = new Uzdevumi();
             Uzd1.Gadi(); */

            /* Uzdevumi Uzd2 = new Uzdevumi();
            Uzd2.Nskaitli(); */

            Uzdevumi Uzd3 = new Uzdevumi();
            Uzd3.Rezgis();

            Console.ReadLine();
        }
    }
}
