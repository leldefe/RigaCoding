using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Klases
{
    public class Card
    {
        //vērtība
        public string Value;

        //masts
        public char Suit;

        //izveido kārti
        public Card(string value, char suit) //šis ir konstruktors, šie divi parametri veidos objektu
        {
            this.Value = value; //piešķir vērtību objektiem
            this.Suit = suit;
        }
        //Kārts skaitliskā vērtība
        public int GetValue()
        {
            switch(Value)
            {
                case "A": //šeit mēs apskatām maksimālās vērtības
                    return 11;
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:
                    return Convert.ToInt32(Value); //pārējie ir skaitļi no 2-10 un tos var vnk konvertēt
            }
            
        }
    }
}
