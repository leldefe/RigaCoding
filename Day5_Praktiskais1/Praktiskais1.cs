using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Praktiskais1
{
    class Praktiskais1
    {
        /*
        public void DilstosaVirkne()
        {
            Console.Write("Ievadi skaitu N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 1; i=i-1) // sanāk, ka ievades būs no 1 līdz sasniedz n
            {
                Console.Write(i+",");
            } */

        /*
    public void Modinatajs()
    {
        Console.Write("Ievadi Nedelas dienu (apzīmēta kā P, O, T, C, Pk, Se, Sv): ");
        string diena = Console.ReadLine();
        Console.Write("Atvaļinājums Jā (ierakstīt J), Nē (ierakstīt N): ");
        string atvalinajums = Console.ReadLine();
        diena = diena.ToUpper();
        atvalinajums = atvalinajums.ToUpper();

        //šeit pasniedzējs rakstīja:
      /*
        if (diena == "P" || diena == "O"|| diena == "T"|| diena == "C"|| diena == "Pk")
        {
            if (atvalinajums=="Jā")
            {
            Console.Write("10:00");
            {
            else
            {
            Console.Write("7:00");
            }
        }
        else if (diena == "Se" || diena == "Sv")
        {
           if (atvalinajums=="Jā")
            {
            Console.Write("OFF");       //saīnājumā Console.Write(atvalinajums=="Jā" ? "OFF": "10:00")  un te jālasa tā,"ja izpildās "Jā",tad liek "OFF", ja nav patiess "Jā", tad izpildās tas, kas aiz kola
            {
            else
            {
            Console.Write("10:00");
            } 
        }
        else
        {
        Console.Write("Netaļauta vērtība") */


        //Un te sākas mas uzdevuma risinājums:

        /*
        if (diena == "P" && atvalinajums=="N")
        {
            Console.Write("7:00");
        }
        else if (diena == "O" && atvalinajums == "N")
        {
            Console.Write("7:00");
        }
        else if (diena == "T" && atvalinajums == "N")
        {
            Console.Write("7:00");
        }
        else if (diena == "C" && atvalinajums == "N")
        {
            Console.Write("7:00");
        }
        else if (diena == "Pk" && atvalinajums == "N")
        {
            Console.Write("7:00");
        }

        else if (diena == "Se" && atvalinajums == "N")
        {
            Console.Write("10:00");
        }
        else if (diena == "Sv" && atvalinajums == "N")
        {
            Console.Write("10:00");
        }
        else if (diena == "P" && atvalinajums == "J")
        {
            Console.Write("10:00");
        }
        else if (diena == "O" && atvalinajums == "J")
        {
            Console.Write("10:00");
        }
        else if (diena == "T" && atvalinajums == "J")
        {
            Console.Write("10:00");
        }
        else if (diena == "C" && atvalinajums == "J")
        {
            Console.Write("10:00");
        }
        else if (diena == "Pk" && atvalinajums == "J")
        {
            Console.Write("10:00");
        }
        else
        {
            Console.Write("OFF");
        }
    } */

        /*
    public void AtrumaParkapejs()
    {
        Console.Write("Vai Šodien ir dzimšanas diena (Jā = J/Nē = N): ");
        string diena = Console.ReadLine();
        Console.Write("Ievadiet ātrumu: ");
        int atrums = Convert.ToInt32(Console.ReadLine());
        diena = diena.ToUpper();

        //ja dzimšanas diena nē:
        //atrums<=60 = 0
        //atrums=[61;80]=1
        //atrums>80=2
        //ja dzimšanas diena jā:
        //atrums<=65 = 0
        //atrums=[66;85]=1
        //atrums>85=2

        //pasniedzēja risinājums:
        /*
         if (diena=="Jā")
         {
         atrums = atrums -5; //īsāk var uzrakstīt "atrums-=5"
         }
         if(atrums>80)
         {
         Console.Write("2 - liels sods");
         {
         else if (atrums >= 61 && atrums <= 80);
         {
         Console.Write("1 - mazs sods");
         {
         else
         {
         Console.WriteLine("0 - nav sods");
         }
     } */

        //Mans risinājums:
        /*
        if (diena == "N" && atrums <= 60)
        {
            Console.Write("Sods = 0");

        }
        else if (diena == "N" && (atrums >= 61 && atrums <= 80))
        {
            Console.Write("Sods = 1");
        }
        else if (diena == "N" && atrums > 80)
        {
            Console.Write("Sods = 2");
        }
        else if (diena == "J" && atrums <= 65)
        {
            Console.Write("Sods = 0");
        }
        else if (diena == "J" && (atrums >= 66 && atrums <= 85))
        {
            Console.Write("Sods = 1");
        }
        else
        {
            Console.Write("Sods = 2");
        }

    } */


        /*
    public void FizzBuzz()
    {
        //Sākuma vērtība A
        //Beigu vērtība B
        //if skaitlis%3 console write Fizz
        //if skaitlis%5 console write Buzz
        //if skaitlis%3 && skaitlis%5 console write FizzBuzz

        Console.Write("Ievadiet sākuma vērtību A: ");
        int skaitlisA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ievadiet beigu vērtību B: ");
        int skaitlisB = Convert.ToInt32(Console.ReadLine());

        for (int i = skaitlisA; i <= skaitlisB; i++)// sanāk, ka ievades būs no skailisA līdz sasniedz skaitlisB
        {
            if ((i % 3 == 0) && (i % 5 == 0)) //šis jāievieto pirms visām citām pārbaudēm, jo, ja noliks, piemēram, aiz %3, tad tas izpildītos pirmais un mēs šajā garajā pārbaudē nemaz neietu
            {
                Console.WriteLine(" FizzBuzz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write(" Buzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write(" Fizz ");
            } 
            else
            {
                Console.Write(" " + i + " ");
            }
            //Šeit pasniedzējs iemeta Console.Write(", "); lai skaitļi un vērtības atdalās viens no otra
        }


    } */

        /*
         public void Neveiksmigais13()
         {
             //"Ievadi skaitli n: "
             //if n = 13 izvadam ievadīto skaitļu summu
     /* //Pasniedzēja varienats:
      int   = 0;

        while(true)
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

        if(skaitlis==13)
        {
        break //break nostrādā tikai uz attiecīgo ciklu, ja būtu cikls ciklā, tad nostrādātu tikai uz to, kurā tas atrodas. "return" izmet no visas funkcijas vispār ārā
        }
        else//var arī elese nerakstīr,jo ciks ar "break"ir pārtraukts
        {
        summa +=skaitlis;
        //summa = summa + skaitlis;
        }
    }
    Console.WriteLine("Summa ir "+summa);
    } */

    //un te ir mans variants
    /*
             int summa = 0;
             bool nelaimigais = true;
             while (nelaimigais)

             {
                 Console.Write("Ievadi skaitli: ");
                 int skaitlis = Convert.ToInt32(Console.ReadLine());

                 summa = summa + skaitlis;

                 if (skaitlis == 13)
                 {
                     nelaimigais = false;
                     Console.WriteLine("Summa ir " + summa);
                 }
                 else if (skaitlis >= 0 && skaitlis <= 100)
                 {
                     nelaimigais = true;
                 }
                 else
                 {
                     Console.Write("Skaitlis ārpus robežām");
                 }

             }
         }  */

        /*
        public void Acite()

            //atgriezt skaitli, kurš tuvāk 21 un to nepārsniedz
            //atgriezt 0, ja abas vērtības pārsniedz 21
        {
            Console.Write("Ievadiet skaitli 1: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadiet skaitli 2: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            if (skaitlis1<=21 && skaitlis2<=21)
            {
                if (skaitlis1>skaitlis2)
                {
                    Console.Write(skaitlis1);
                }
                if (skaitlis2>skaitlis1)
                {
                    Console.Write(skaitlis2);
                }
            }
            else if (skaitlis1 > 21&& skaitlis2>21)
            {
                Console.Write("0");
            }
        } */

    }

}

