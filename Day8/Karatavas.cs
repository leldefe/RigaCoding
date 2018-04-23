using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
   public class Karatavas
    {
       string[] varduMasivs = new string[]
        {"MALA", "ALA", "ZIRGS", "SUNS"};
        string vards;
        char[] uzminiVardu; //pateicu kāda tipa mainīgais tas būs
        

        /* public static void Piemers ()
        {
            char c = 'Z';
            if(c>= 'A' && c<= 'Z')
            { Console.Write("lielais burts"); }
        } */
        public void StartNewGame()
        {
            varduMasivs = varduMasivs.OrderBy(c => Guid.NewGuid()).ToArray();
            vards = varduMasivs[0];
            uzminiVardu = new char[vards.Length]; //te es iedevu mainīgajam vērtību
            for (int i = 0; i < vards.Length; i++)
            {
                uzminiVardu [i]= '-';
            }
        }
        public char [] UzminetaisVards()
        {
            return uzminiVardu;

        }
        public bool TrueNotTrue(char b) //tas char b ir lietotāja minējums, te ierakstījām, jo gribam saņemt parametru, ievadam visus parametru, kas nepieciešami, lai saņemtu to funkciju
        {
            
            bool pareizi = false;
            for (int i = 0; i < vards.Length; i++)
                
            {
                char simbols = vards[i];
                if (simbols == b)
                {
                    pareizi = true;
                    uzminiVardu[i] = b;
                }
                

            }
            
            return pareizi;

        }
                
        public bool VaiVardsIrAtminets()
        {
            
            bool vardsAtminets = true;
            
            
                vardsAtminets = new String(uzminiVardu) == vards; //pārvērtām simbolu masīvu uz string
                                                                  //Console.Write("Vards atminets!");

                return vardsAtminets;
            
        }
            

    }


    
}
