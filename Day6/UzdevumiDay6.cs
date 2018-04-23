using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class UzdevumiDay6
    {
        public static void Trijsturis() //static lieto, lai izveidotu statiskas vērtības, funkcijas kurām padod datus, bet nav jāzin ievades vērtība, tāpat,kā int
        {
            Console.Write("Ievadi rindu skaitu N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int rinda = 1; rinda <= n; rinda++)
            {
                Console.WriteLine(); //Šis pārmet jaunā rindā
                //for (int kolona = 1; kolona <= rinda; kolona++)//sākumā kolona ir 1, tad tā sasniedz rindas vērtību (attēlojas tik skaitļi, cik - kura rinda tā ir pēc kārtas) un palielinās par vienu vienību
                //ja gribētu, lai trijstūris ir kājām gaisā, tad 
                  for (int kolona = n - rinda; kolona>= 1; kolona--)
                {
                    Console.Write(kolona);
                }
            }
        }
    }
}
