using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{ //Masivs var but skaitlu masīvs, tas var būt teksta masīv, tur arī norāda, kāda tipamasīvs tas būs
    //Katram masīva elementam ir savs numurs un numerācija sākas no nulles. Masīva1. elements ir 0 elements
    //Veidojot masīvu jāpasaka, cik elementi iekšā būs, bet visus elementus var neizpildīt, bet vairāk elementus nedrīks aizpildīt
    //tiklīdz izveidojam masīvu, atmiņā tiek rezervēta vieta priekš 8 elementiem (0-7) un devīto nekādi nevar ielikt

    class Masivi
    {
        /* public static void Piemeri()
        {
            int?[] skaitluMasivs = new int?[8]; //kvadrātiekavas nozīmē, ka masiva tips, new-jauns objekts un otras [] pasaka, ka būs masīvs no 8 elementiem
            int skaitlis = 0; //šo skaitli programma neizmanto, jo neesam nekur izmantojuši un bez šīs rindas programma strādās

            //elementu aizpilde
            skaitluMasivs[0] = 1;
            skaitluMasivs[1] = 2;

            //..
            skaitluMasivs[7] = 8;
            //skaitluMasivs[8] = 9; //šī rinda izmestu kļūdu, jo ir tkai 8 vietas

            int[] skaitluMasivs2 = new int[] //var vēl vairāk saīsināt un noņemt to new int[] pavisam un tāpat strādās
            {
                1,3,50,100,500
            }; //semikols aiz figūriekavām, jo tā ir definīcija

            for (int i = 0; i < skaitluMasivs.Length; i++) //cikls, kuršsākas no nulles, jo masīvs sākas ar nulli, cikls darbojas tik ilgi, līdz sasniedz masīva garumu un katru rezi palielina sk par 1
            {
                int? skaitlisNoMasiva = skaitluMasivs[i];

                if (skaitlisNoMasiva.HasValue)
                {
                    Console.WriteLine(skaitlisNoMasiva);
                }
                else
                {
                    Console.WriteLine("Nav vērtības ");
                }
                
            }
            
        }
        public static void Piemers2()
        {
            List<int> skaitluSaraksts = new List<int>();//List jeb saraksts ir dinamisks masīvs un tam jebkurā brīdī var pievienot jaunu elementu vai idzēst elementu
            skaitluSaraksts.Add(5);
            skaitluSaraksts.Add(7);
            skaitluSaraksts.Add(20);

            List<int> skaitluSaraksts2 = new List<int>()
            {
                5,7,20
            };
            skaitluSaraksts2.Add(100);
            skaitluSaraksts2.AddRange(new[] { 45, 2090, 20 });

            skaitluSaraksts2 = skaitluSaraksts2
                .Where(s => s != 100) //sakārtos sarakstu tā, lai s vērtībām piešķiras s un != nozīmē nav vienāds ar 100 un !! nozīmē, ka ir vienāds
                .OrderBy(s => s) //sakārto augošā secībā OrderByDescending būs sakārtot dilstošā secībā
                .ToList(); //pasaka, lai iepriekšējās kārtošanasdarbības tiktu izpildītas

            foreach (int skaitlis in skaitluSaraksts2) //iziet cauri visam masīvam,ņem vērtību un liek iekšā tajā skaitlis
            {                                           // tas pats, kas šitas "for (int i = 0; i < skaitluMasivs.Length; i++)" tikai īsāk
                Console.WriteLine(skaitlis);
            }

        } */

        /* public static void ApgrieztsMasivs()
        {
            //1. paprasam Lietoājam ievadīt, cik skaitļus viņš norādīs
            //2.paprasām tik skaitļus N ievadīt

            Console.Write("Cik skaitļus ievadīsi? ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] skaitli = new int[N]; //definējam masīvu, kura izmērs ir N

            for (int i=0; i<N; i++)
            {
                Console.Write("Ievadiet " + i + ". skaitli ");
                skaitli[i] = Convert.ToInt32(Console.ReadLine()); //pārsaucam int skaitli ar masīva nosaukumu un liekam [i], jo i pozīcijā tas masīvs liksies iekšā
            }
            //izvadīsim masīvu pretējā secībā
            for (int i = N-1; i>=0; i--) //N-1, jo masīvā ir N elementi, bet vietas ir par vienu mazāk, jo sākas no nulles
            {
                Console.WriteLine(skaitli[i]);
            }
            
           
        } */

        public static void VaiIrMasiva()
        {
            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            
            
           /* for (int i=0; i<masivs.Length; i++) 
            {
                if (masivs[i]==skaitlis)
                {
                    Console.Write("Skaitlis ir atrasts");
                    Console.Write("Pozīcija = " +i);
                    return;
                }
            }
            Console.WriteLine("Skaitlis nav atrasts!"); */

            //īsāk to var uzrakstīt šādi:
            int pozicija = Array.IndexOf(masivs, skaitlis);//šī funkcija vienmēr atgriež skaitlisku vērtību, ja elements nav atrasts, atgriež -1
            
            if (pozicija == -1)
            {
                Console.WriteLine("Skaitlis nav atrasts!");
            }
            else { Console.WriteLine(pozicija); }
        }
    }
}
