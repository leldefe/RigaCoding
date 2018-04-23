using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            //UzdevumiDay6.SkaitlisPieci();

            Piemers();

        }

        public static void Piemers()
        {
            /* Console.Write("Ievadi dienu: ");
             string diena = Console.ReadLine();

             switch(diena)
             {
                 case "P":
                 case "O":
                 case "T":
                 case "C":
                 case "Pk":
                     Console.WriteLine("Ir darba diena.");
                     if (diena=="Pk")
                     {
                         Console.WriteLine("Piektdiena");
                     }
                     break; //tad, kad viss zem šitā case ir pabeigts, tad ņemam šo
                 case "Se":
                 case "Sv":
                     Console.WriteLine("Ir brīvdiena.");
                     break;
                 default:
                     Console.WriteLine("Nezināma diena.");
                     break;

             } */

            /* Console.Write("Ievadi Valsti: ");
             string valsts = Console.ReadLine();

             switch (valsts.ToLower())
             {
                 case "igaunija":
                     Console.WriteLine("Tallina");
                     break;
                 case "somija":
                     Console.WriteLine("Helsinki");
                     break;
                 case "ukraina":
                     Console.WriteLine("Kijeva");
                     break;
                 case "zviedrija":
                     Console.WriteLine("Stokholma");
                     break;
                 case "krievija":
                     Console.WriteLine("Maskava");
                     break;
                 default:
                     Console.WriteLine("Nezināma valsts");
                     break;
             } */


            /*  try
              {
                  Console.Write("Ievadi vērtību d1: ");
                  int d1 = Convert.ToInt32(Console.ReadLine());
                  Console.Write("Ievadi vērtību d2: ");
                  int d2 = Convert.ToInt32(Console.ReadLine());
                  Console.Write("Ievadi darbību '+','-', '*', '/': ");
                  string darbiba = Console.ReadLine();
                  //pasniedzējs te ierakstīja 'double rezultats;'
                  switch (darbiba)
                  {
                      case "+":
                          Console.WriteLine(d1 + d2); //rezultats=d1+d2;
                          break;
                      case "-":
                          Console.WriteLine(d1 - d2);//rezultats=d1-d2;
                          break;
                      case "*":
                          Console.WriteLine(d1 * d2);//rezultats=d1*d2;
                          break;
                      case "/":
                          //if (d2==0) {Console.Write("Darbība nav atļauta!"); return;}
                          Console.WriteLine((double)d1 / (double)d2);//rezultats=(double)d1/d2;
                          break;
                      default:
                          Console.WriteLine("Nezināma darbība");
                          Piemers();
                          return;
                          // break;  //Ja te nebūtu tas Piemērs() rindu augstāk, tad ar šito return izies un balle beidzās,šajā gadījumāatgriezīsies uz augšu un varēs ievadīt atkal

                  }
              }


              //Console.Write("Rezultāts ="+rezultats);
              catch (Exception ex)
              {
                  Console.Write("Neatbilstoša vērtība");
                  Piemers();
              } */

            Console.WriteLine("Cik skaitļus ievadīsi? ");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[skaits];

            for (int i = 0; i < skaits; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());

            }
            //Atrast masīva lielāko un mazāko vērtību
            int min = masivs[0]; //pielīdzinam min ar pirmo skaitli no masīva un to pašu daram ar max
            int max = masivs[0];//pielīdzina jebkuram masīva skaitlim, var rakstīt arī masivs[1], bet galvenais, lai tas ir no masīva
            foreach (int skaitlis in masivs) //for each nozīmē, ka iet cauri katram masīva elementam
            {
                if (skaitlis<min) //salīdzina ar masīva 1.skaitli
                {
                    min = skaitlis; //ja ir mazāks tad tas kļūst par jauno min un for each dodas tālāk
                }
                else if (skaitlis>max)
                {
                    max = skaitlis;
                }
                

            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);

                Console.ReadLine();

        }
        
        
    }
    
}
