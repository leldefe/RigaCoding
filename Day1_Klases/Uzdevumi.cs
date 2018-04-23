using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    class Uzdevumi
    {
        public void Uzdevums1(string vards) //jaizvada tikai teikums, neko neatgriež funkcija, bet string, jo liksim vardus
        {
            //Izvada apvienotus teksa fragmentus
            //"Tavs vārds ir"
            //un mainīgā 'vards' saturu
            Console.WriteLine("Tavs vārds ir " + vards);
        }
        public void Uzdevums2(int skaitlis1, int skaitlis2)
        {
            Console.WriteLine(skaitlis1 + skaitlis2);
        }

    }

}
