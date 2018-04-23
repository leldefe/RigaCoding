using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzdevumi.Kalkulators();
            // Uzdevumi.Masivi();
            //Uzdevumi.SkaitluSerija();
            // Uzdevumi.CiparuSumma();
           // Dimantins.Dimants();

            
            
            Karatavas karatavas = new Karatavas();
             karatavas.StartNewGame();

             foreach (char a in karatavas.UzminetaisVards()) //simboli '-'man liekas iekšā tajā a
             {
                 Console.Write(a);
             }
            int dzivibas = 5;
             while (!karatavas.VaiVardsIrAtminets())

             {
                 Console.WriteLine();

                 Console.WriteLine("Ievadi burtu: ");
                 string burts = Console.ReadLine();
                burts = burts.ToUpper();


                 if (karatavas.TrueNotTrue(burts[0]))
                 {
                     foreach (char a in karatavas.UzminetaisVards())
                     {
                         Console.Write(a);
                     }
                 }
                 else 
                 {
                     Console.WriteLine();
                    dzivibas--;
                     Console.WriteLine("Burts " + burts[0] + " nav pareizs, Jums atlikušas "+dzivibas+" dzīvības");
                    if (dzivibas==0)
                    {
                        Console.WriteLine("Spēle beigusies!");
                       break;
                    }
                 }
            } 
            Console.ReadLine();
        } 
    }
}
