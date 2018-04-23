using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
   public class ManaPirmaKlase
    {
        //public nozīmē, ka var no citām klasēm funkcijas izvadīt
        public void SayHello() //funkcija bez rezultāta, bez ievadparametriem
        {
            Console.WriteLine("Hello!"); //izvadās konsolē, bet netiek atgriezts
        }
        public int GetNumber() //funkciji rezultats int (ar rezultātu), bet bez ievadparametriem, atgriež skaitli 99
        {
            return 99;
        }
        public int GetNumber2(int skaitlis) //funkcija ar rezultātu un ar ievadparametru
        {
            return skaitlis; //funkcija saņem skaitli un to pašu skaitli atgriež
        }
    }
}
