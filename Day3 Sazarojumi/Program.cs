using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Sazarojumi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uzdevumi Uzd1 = new Uzdevumi();
            Uzd1.VienadiSkaitli(); */

            Uzdevumi Uzd2 = new Uzdevumi();
            Uzd2.Menesi();

            Console.ReadLine();
        }
        
        
        /* public void Piemers()
        {
            int skaitlis = 6;

            bool vaiIrVienadsArPieci = skaitlis == 5;

            if (skaitlis > 5)
            {
                Console.WriteLine("Skaitlis ir lielāks par 5");
            }
            else if (vaiIrVienadsArPieci)       //ar 2 vienādības zīmēm pārbaudam vai ir vienāds. Ar vienu = piešķiram vērtību)
            {                                   //(skaitlis==5) vai arī iekavās liek šito un bez bool augšā
                Console.WriteLine("Skaitlis vienāds ar 5");
            }
            else
            {
                Console.WriteLine("Skaitlis nav lielāks par 5");
            } */

        }


    }

