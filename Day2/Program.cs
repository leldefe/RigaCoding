using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args) //galvenais ieejas punkts aplikacija
        {
            Uzdevumi uzdevumi = new Uzdevumi(); //izveidojam jaunu objektu no klases 'Uzdevumi'

            //nakamas 6 rindinas izsauc objektu funkcijas
            /* uzdevumi.Starpiba(5, 3);
             uzdevumi.Reizinajums(5, 3, 1);
             uzdevumi.SkaitluMaina(5, 6);
             uzdevumi.Aprekini(5, 3);

             //pec partraukuma ar int Convert */

            /* uzdevumi.IevadiVardu();
            uzdevumi.Gradi(); */

            /* Auto auto = new Auto();
            auto.Krasa = "melns";
            auto.Marka = "Audi";
            auto.Info();

            Auto vw = new Auto();
            vw.Krasa = "balts";
            vw.Marka = "VW";
            vw.Info();

            Auto nezinams = new Auto();
            nezinams.Info(); */

          Kvadrats kv1 = new Kvadrats();
            kv1.Krasa = "sarkans";
            kv1.MalasGarums =5;
            kv1.KrasasIzvade();
            int laukums = kv1.Laukums();
            Console.WriteLine("Laukums ir " + laukums); //divi variantikā izsaukt tās funkcijas lukums un perimetrs no konstruktora
            Console.WriteLine("Perimetrs ir " + kv1.Perimetrs());

            Console.WriteLine();

            Kvadrats kv2 = new Kvadrats("melns",3);
            Console.WriteLine("Perimetrs ir " + kv2.Perimetrs());
            kv2.KrasasIzvade();
            
            Console.ReadLine(); //ar šīs funkcijas palīdzību patur atvērtu logu līdz nospiež ENTER


        }
    }
}
