using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Darbinieks
    {
        

        public string Vards;
        public string Uzvards;
        public long DzGads;
        public string Epasts;
        public string Talrunis;
        public Adrese Dzivesvieta; //izveidojām savu tipu "Adrese", jo tāsatur gan string, gan int
        public Nodala AktualaNodala;
        public Nodala IeprieksejaNodala;
    
        public void TeikumsViens()
        {
            Console.WriteLine("Mani sauc " + Vards + " " + Uzvards + ", es dzīvoju " + Dzivesvieta.PilnaAdrese());
        }
        public void TeikumsDivi()
        {
            Console.WriteLine("Mani sauc " + Vards + " un es pārgāju uz " + AktualaNodala.Nosaukums + " no " + IeprieksejaNodala.Nosaukums + " kura atradās " + IeprieksejaNodala.AtrasanasVieta.PilnaAdrese());
        }
    }
}
