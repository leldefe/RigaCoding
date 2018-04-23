using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Uzdevumi
    {
        /* public void Gadi()
         {
             //1.paprasa ievadīt gadaskaitli
             //2.Nolasa ievadīto gadaskaitli
             //3.izvada visus gada skaitļus no ievadītā līdz 2018
             Console.Write("Ievadi gada skaitli: ");
             int gskaitlis = Convert.ToInt32(Console.ReadLine());

             for (int gads=gskaitlis; gads<=DateTime.Now.Year; gads++)
             {
                 Console.WriteLine(gads + ". gads");
             } */

       /* public void Nskaitli()
        {
            Console.Write("Ievadi skaitu N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i <= n; i++) // sanāk, ka ievades būs no 1 līdz sasniedz n
            {
                Console.Write("Ievadi " + i + " skaitli: ");
                //nolasa katru ievadīto vērtību
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa = summa + skaitlis; //vai arī: summa +=skaitlis
            }
            Console.WriteLine("Summa ir " + summa);
            Console.WriteLine("Vidējā vērtība ir " + (summa / n));
        } */

        public void Rezgis()
        {
            Console.Write("Ievadi skaitu N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //ciks attēlos N rindas
            for (int rinda = 1; rinda <= n; rinda++) 
            {
                Console.WriteLine(); //Šis pārmet jaunā rindā
                for(int kolona = 1; kolona <= n; kolona++) //Šis cikls izvada N simboluskatrā rindā
                {
                    Console.Write("#");
                }
                //Console.WriteLine(); vai arī te rakstam un katras rindas beigās pārmetamies jaunā rindā
                
            }
        }
    }
}
        
        

    

