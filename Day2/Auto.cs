using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Auto 
    {
        public Auto() //šis ir konstruktors, jo nav rezultāta tipa (void)
                       //nosaukums sakrīt ar klases nosaukumu - tad tas ir konstruktors
        {
            this.Marka = "nezinams";//šis piešķir 'nezināms' markai un krasai, ja kaut kur pēc tam tas netiek pārdefinēts
            this.Krasa = "nezinams";
        }

        public string Marka; //Marka ir šīs klases īpašība, ja tā beigsies ar (), tad tābūtu funkcija
        public string Krasa;

        public void Info() //šī funkcija atgriezīs info par īpašībām
        {
            Console.WriteLine("Auto marka ir: " + this.Marka); //this pasaka, ka marka ir jameklē nevis klasē, nevis funkcijā definēts
            Console.WriteLine("Auto krāsa ir: " + Krasa); //var arī bez this, jo viņš atrod, ka funkcijā nekur nav (string Krasa="Zils"), ir klasē
        }
    }
}
