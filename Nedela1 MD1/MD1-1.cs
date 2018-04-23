using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedela1_MD1
{
    class MD1_1
    {

        // 1.UZDEVUMS

        /*public void Pilngadiba()
        {
            Console.Write("Ievadi vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine());

            if (vecums == 18)
            {
                Console.WriteLine("Persona ir pilngadīga");
            }
            else if (vecums > 18)
            {
                Console.WriteLine("Persona ir pilngadīga");
            }
            else
            {
                Console.WriteLine("Persona ir nepilngadīga");
            } 
            }*/


        //2. UZDEVUMS


        /*  public void VidVertiba()
          {
              Console.Write("Ievadi pirmo skaitli: ");
              int skaitlis1 = Convert.ToInt32(Console.ReadLine());

              Console.Write("Ievadi otro skaitli: ");
              int skaitlis2 = Convert.ToInt32(Console.ReadLine());

              Console.Write("Ievadi trešo skaitli: ");
              int skaitlis3 = Convert.ToInt32(Console.ReadLine());

              int summa = skaitlis1 + skaitlis2 + skaitlis3;


              double videjais = (double) summa / 3;
              Console.WriteLine("Vidējā vērtība ir " + videjais);
           
          }
          */


        //3.UZDEVUMS

        /* public void GraduKonvertesana()
      {
          Console.Write("Ievadi grādus: ");
          int skaitlis = Convert.ToInt32(Console.ReadLine());
          Console.Write("Ievadi C vai F: ");
          string CF = Console.ReadLine();
            //mazos burtus pārvērtīs par lielajiem
            CF = CF.ToUpper();

          double gradiF = skaitlis * 9 / 5 + 32;        //teoretiski uz tafeles bija double gradiF
          double gradiC = (skaitlis - 32) * 5 / 9;

          if (CF == "C")
          {
              Console.Write("Grādi pēc F ir " + (double)gradiF + "F");
          }
          else if (CF == "F")
          {
              Console.Write("Grādi pēc F ir " + (double)gradiC + "C");
          } 
          else
            {
                Console.Write("Nezināma mērvienība");
            }
         } 
         */


        //4.UZDEVUMS
        /*
         public void Intervals()
    {
        Console.Write("Ievadi skaitli: ");
        int skaitlis = Convert.ToInt32(Console.ReadLine());


        if (skaitlis >= (-50) && skaitlis <= 50)
        {
            Console.Write("Skaitlis atrodas intervālā starp -50 un 50");
        }
        else
        {
            Console.Write("Skaitlis neatrodas intervālā starp -50 un 50");
        } 
        } */

        //1.variants
        /*
        if (skaitlis >= -50)
        { 
            if (skaitlis <= 50)
            {
            Console.Write (Skaitlis atrodas intervālā starp -50 un 50");
            }
            else
            {
            Console.Write("Skaitlis neatrodas intervālā starp -50 un 50");
            }
        }

        else
        {
        Console.Write("Skaitlis neatrodas intervālā starp -50 un 50");
        }

        //2.variants

        if (skaitlis >= -50)
        {
            if (skaitlis <= 50)
            {
            Console.Write("Skaitlis neatrodas intervālā starp -50 un 50");
            return; //šis pārtrauc funkcijas tālāko izpildi
            }
        }
        Console.Write("Skaitlis neatrodas intervālā starp -50 un 50");
        }
        }
        } */
        //5.UZDEVUMS

        /* public void ParaNepara()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis%2 ==0) // % veselā daļa, kas paliek neizdalīta, piemēram 4/2=2 un atlikums 0; 5/2=2 atlikums 1
            {
                Console.Write("Skaitlis ir pāra skaitlis");
            }
            else
            {
                Console.Write("Skaitlis nav pāra skaitlis");
            } 
        } */


        //6.UZDEVUMS

        /*
    public void MinMax()
    {
        Console.Write("Ievadi pirmo skaitli: ");
        int skaitlis1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ievadi otro skaitli: ");
        int skaitlis2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ievadi trešo skaitli: ");
        int skaitlis3 = Convert.ToInt32(Console.ReadLine());

        int[] array1 = { skaitlis1, skaitlis2, skaitlis3 };
        Console.WriteLine("Ievadīto skaitļu minimālā vērtība: " + array1.Min());
        Console.WriteLine("Ievadīto skaitļu maksimālā vērtība: " + array1.Max());
    }
    */

        //UZDEVUMS #12

        /* public void Atrumi()
         {
             Console.Write("Ievadi attālumu metros: ");
             int attalums = Convert.ToInt32(Console.ReadLine());

             Console.Write("Ievadi patērēto laiku stundās: ");
             int laiksh = Convert.ToInt32(Console.ReadLine());

             Console.Write("Ievadi patērēto laiku minūtēs: ");
             int laiksmin = Convert.ToInt32(Console.ReadLine());

             Console.Write("Ievadi patērēto laiku sekundēs: ");
             int laikssec = Convert.ToInt32(Console.ReadLine());

             int KopejaisLaikssec = ((laiksh * 3600) + (laiksmin * 60) + laikssec);
             Console.WriteLine("Kopējais laiks(s): " + KopejaisLaikssec);

             double atrumsMetriSec = (double)attalums/KopejaisLaikssec;
             Console.WriteLine("Atrums m/s: " + atrumsMetriSec);

             double attalumskm = attalums / 1000d; //f vai d nozīmē, ka izmantots decimālā tipa skaitlis
             Console.WriteLine("Attalums km: " + attalumskm);

             double atrumsKmH = attalumskm / (KopejaisLaikssec /3600);
             Console.WriteLine("Atrums km/h: " + atrumsKmH);

             double attalumsJudzes = attalumskm * 0.621371;
             Console.WriteLine("Attalums judzes: " + attalumsJudzes);

         } */


    }
}








        


        
    

