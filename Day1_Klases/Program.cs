using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.mainīgā tips = ManaPirmaKlase
            //2. mainīgā nosaukums = objekts
            //3. sākotnējā vērtība = jauns objekts no klases

            /*ManaPirmaKlase objekts = new ManaPirmaKlase(); //lai paņemtu no tas jaunizveidotas klases funkcijas
            objekts.SayHello();
            //punkts tepat augšā aiz objekta, izsauc funkciju SayHello
            objekts.SayHello();

            int rezultats = objekts.GetNumber(); //lai to skaitli izvadītu, ne tikai kkur atgrieztu to 99
            Console.WriteLine(rezultats); //kamēr neizsauc writeline, tikmēr netiek uz ekrāna izvadīts, bet glabājas datora ekrānā

            //jauns mainīgais

            int rezultats2 = objekts.GetNumber2(100); //aiz getnumber2 jaievada skaitlis
                                                      //ja tips netiek definēts ar to int, tad tiek izvadīts tas rezultāts bez int

            rezultats = objekts.GetNumber();

            Console.WriteLine(rezultats2); //šis man izvadīsto int rezultats2
            Console.WriteLine(rezultats); //šis man izvadīs rezultats = objekts.GetNumber()

            rezultats2 = objekts.GetNumber2(102);

            Console.WriteLine(rezultats2);*/

            Uzdevumi uzdevumi = new Uzdevumi();
            uzdevumi.Uzdevums1("Lelde");
            uzdevumi.Uzdevums2(5, 15);


            Console.ReadLine(); //šis lai paliktu windows uz ekrāna

        }
    }
}
