using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Uzdevumi
    {
        public void Starpiba(int skaitlis1, int skaitlis2)
        {
            int starpiba = skaitlis1 - skaitlis2;
            Console.WriteLine(starpiba);
        }
        public void Reizinajums(int skaitlis1, int skaitlis2, int skaitlis3)
        {
            int reizinajums = skaitlis1 * skaitlis2 * skaitlis3;
            Console.WriteLine(reizinajums);
        }
        public void SkaitluMaina(int sk1, int sk2)
        {
            Console.WriteLine("Sk1 = " + sk1); //5
            Console.WriteLine("Sk2 = " + sk2); //6

            int sk1VecaVertiba = sk1;
            sk1 = sk2;
            sk2 = sk1VecaVertiba; //apstrade

            Console.WriteLine("Sk1 = " + sk1); //6
            Console.WriteLine("Sk2 = " + sk2); //5
        }
        public void Aprekini(int sk1, int sk2)
        {
            //1.skaitlu summa
            Console.WriteLine(sk1+sk2);
            //2.skaitlu starpiba
            Console.WriteLine(sk1 - sk2);
            //3.skaitlu reizinajums
            Console.WriteLine(sk1 * sk2);
            //4.skaitlu dalijums
            double dalijums = (double)sk1 / sk2; //var ari šitā rakstīt, lai būtu ar komatiem
            Console.WriteLine(dalijums);
            Console.WriteLine((double)sk1 / sk2); //double nozimē, ka jādala ar daļskaitli, rezultāts būs ar komatu
            //5.skaitlu atlikums
            Console.WriteLine(sk1 % sk2); //dalījuma atlikums (c# division with remainder)
        }

        public void IevadiVardu() //definējam jaunu funkciju, ks nesaņem parametrus un neatgriež vērtību
                                  //šī funkcija paprasīs lietotājam, lai ievada vārdu
        {
            Console.Write("Ievadi Vardu: "); //šis uzrakstīsies uz ekrāna, lieku Write nevis WriteLine, lai ievade/kursors ir/paliek tajā pašā rindā
            string vards = Console.ReadLine(); //nolasa ievadīto tekstu

            Console.WriteLine("Tevi sauc " + vards); //teksta izvade un kursors pāriet jaunā rindā

            Console.Write("Ievadi skaitli: "); //liek ievadīt skaitli
          
            int skaitlis = Convert.ToInt32(Console.ReadLine());//liku priekšā convert, jo read line var nolasīt tikai tekstu, pārveidojam uz veselu skaitli
            Console.WriteLine("Skaitlis ir " + skaitlis); //izvada rezultātu 
        }
        public void Gradi()
        {
            Console.Write("Ievadi grādus pēc Celsija: ");
            int gradi = Convert.ToInt32(Console.ReadLine());
            double gradiF = gradi * 9 / 5 + 32;
            int gradiK = gradi + 273;
            Console.WriteLine("Gradi pec F: " + gradiF);
            Console.WriteLine("Gradi pec K: " + gradiK);
        }
        }

    }


