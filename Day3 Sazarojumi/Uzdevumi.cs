using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Sazarojumi
{
    class Uzdevumi
    {
        /* public void VienadiSkaitli()
         {
             //1.Paprasīt ievadīt skaitli 1
             Console.Write("Ievadi pirmo skaitli: ");
             //2.Nolasa ievadīto vērtību
             int skaitlis1 = Convert.ToInt32(Console.ReadLine());
             //3.Paprasīt ievadīt skaitli 2
             Console.Write("Ievadi otro skaitli: ");
             //4.Nolasa ievadīto vērtību
             int skaitlis2 = Convert.ToInt32(Console.ReadLine());
             //5.Salīdzina vai skaitļi ir vienādi
             if(skaitlis1==skaitlis2)
             {
                 Console.WriteLine("Skaitļi ir vienādi");
             }
             else
             {
                 Console.WriteLine("Skaitļi nav vienādi");
             } */
        public void Menesi()
        {
            Console.Write("Ievadi mēneša nosaukumu: ");
            string menesis = Console.ReadLine();

            if (menesis == "Feb")
            {
                Console.WriteLine("28 dienas");
            }
            else if (menesis == "Apr") 
            {
                Console.WriteLine("30 dienas");
            }
            else if (menesis == "Jūn") 
            {
                Console.WriteLine("30 dienas");
            }
            else if (menesis == "Sept") 
            {
                Console.WriteLine("30 dienas");
            }
            else if (menesis == "Nov")
            {
                Console.WriteLine("30 dienas");
            }
            //vai apvienojot else if(menesis =="Apr"||menesis=="Jun"....
            //Console.WriteLine("30 dienas");
            else
            {
                Console.WriteLine("31 diena");
            }

        }
    }
    }

