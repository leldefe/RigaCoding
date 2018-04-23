using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //teksta izvade konsolē
            Console.WriteLine("Hello World!");
            //vardi jaraksta pedinas

            Console.WriteLine(5);
            //skaitlis bez pedinam

            Console.WriteLine(4.6);
            //atdalitajs punkts un bus decimalskaitlis

            Console.WriteLine('T');
            //viens simbols tiek vadits mazajas vienpedinas, kur nevar ievadit vairakus simbolus

            int skaitlisViens = 9223;
            Console.WriteLine(skaitlisViens);
            /*nav pēdiņās un tāpēc meklēs vērtību kodā iepriekš, butu pēdiņās dotu vārdu "skaitlisViens"
            nedrīkst būt tā, ka Console.WriteLiene(skaitlis2), ja iepriekš nav bijis būs kļūda */

            SayHello();
            OutputNumber();
            Console.ReadLine();
            /* tas readline nodrosina, ka windows ari atver un paliek atverts 
             ne tikai atver un uzreiz aizver, ka bez sitas rindas */
        }
        public static void SayHello()
            //void nozīmē tukšums - funkcija bez rezultāta
        {
            Console.WriteLine("Hello!");
            /*aplikācija izsauks to,kas pievienots augšā Main funkcijā, ja tur neko neatradīs
            tad ta arī neko neizsauks */
        }
       public static void OutputNumber()
        {
            Console.WriteLine('5');
            SayHello();
        }
        
    }
}
