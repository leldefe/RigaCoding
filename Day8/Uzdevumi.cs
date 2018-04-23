using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Uzdevumi
    {
        /* public static void Kalkulators()
        {
            Console.WriteLine("Ievadi skaitlis 1 ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi skaitlis 2 ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            double rezultats;

            {
                Console.WriteLine("Summa " + (rezultats = skaitlis1 + skaitlis2));
                Console.WriteLine("Starpība " + (rezultats = skaitlis1 - skaitlis2));
                Console.WriteLine("Reizinājums " + (rezultats = skaitlis1 * skaitlis2));
                Console.WriteLine("Vidējā vērtība " + (rezultats = (skaitlis1 + skaitlis2)/2));

                if (skaitlis1>skaitlis2)
                {
                    Console.WriteLine("Lielākā vērtība ir " + skaitlis1);
                    Console.WriteLine("Mazākā vērtība ir " + skaitlis2);
                }
                else
                {
                    Console.WriteLine("Lielākā vērtība ir " + skaitlis2);
                    Console.WriteLine("Mazākā vērtība ir " + skaitlis1);
                }

            }
        }*/

        /*
    public static void Masivi()
    {

        int[] masivs1 = { 1, 10, 10, 2 };

        Console.Write("Masivs1= ");
        foreach (var item in masivs1)
        {
            Console.Write(item.ToString() + ", ");
        }
        Console.WriteLine();

        int[] masivs2 = new int[]
        { 1, 10, 10, 2 };
        Console.Write("Masivs2= ");
        for (int i = 0; i < masivs2.Length; i++)
        {
            int? skaitlisNoMasiva = masivs2[i];
                if (skaitlisNoMasiva == 10)
            {
                Console.Write("");
            }
                else
            {
                Console.Write(skaitlisNoMasiva.ToString() + ", ");
            }
        }

    } */

        /*
    public static void SkaitluSerija()
    {
        Console.WriteLine("Ievadi skaitli: ");
        int skaitlis = Convert.ToInt32(Console.ReadLine());

        List<int> skaitluSerija = new List<int>()
        {1, 1, 2 };
        Console.WriteLine("Skaitļu sērija2:");
        foreach (int sk in skaitluSerija)
        {
            Console.Write(sk.ToString() + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Skaitļu sērija3:");
        skaitluSerija.AddRange(new[] { 1, 2, 3, });
        foreach (int a in skaitluSerija)
        {
            Console.Write(a.ToString() + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Skaitļu sērija4:");
        skaitluSerija.AddRange(new[] { 1, 2, 3, 4 });
        foreach (int b in skaitluSerija)
        {
            Console.Write(b.ToString() + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Skaitļu sērija:");
        skaitluSerija[skaitluSerija.FindIndex(ind => ind.Equals(4))] = skaitlis;
        foreach (int c in skaitluSerija)
        {
            Console.Write(c.ToString() + ", ");
        }
    } */

        /*
    public static void CiparuSumma()
    {
        int summa = 0;
        Console.Write("Cik skaitļus ievadīsi? ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] skaitli = new int[N]; 

        for (int i = 0; i < N; i++)
        {
            Console.Write("Ievadiet " + i + ". skaitli ");
            skaitli[i] = Convert.ToInt32(Console.ReadLine());
            summa = summa + skaitli[i];
        }
        Console.WriteLine("Summa ir: " + summa);

    } */

            /*
        public static void Parole()
        {
            Console.Write("Ievadi paroli: ");
            string parole = Console.ReadLine();

            string[] masivs = { parole };
            char[] masivs1 = string.Join(string.Empty, masivs).ToCharArray();
            
        } */


    } 
}
