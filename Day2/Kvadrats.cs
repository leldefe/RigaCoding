using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Kvadrats
    {
        public int MalasGarums;
        public string Krasa;

        public Kvadrats()
        {

        }
        public Kvadrats(string krasa,int garums)
        {
            this.Krasa = krasa;
            this.MalasGarums = garums;
        }
        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa ir " + this.Krasa);
            
        
            Console.WriteLine("Malas garums ir " + this.MalasGarums);
        }

        public int Laukums()
        {
            return this.MalasGarums * this.MalasGarums; //vai arī bez 'this'
        }
        public int Perimetrs()
        {
            return MalasGarums * 4;
        }


            
    }
}
