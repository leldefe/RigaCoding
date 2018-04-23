using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Klases
{
    public class Player
    {
        public List<Card> Cards; //šī rinda ir definīcija/deklarācija,ar vērtību null (nekādu) pasakam, ka mainīgais būs kāršu saraksts

        //īssakais veids, kā uztaisīt konstruktoru ctor un 2xtab
        public Player()
        {
            Cards = new List<Card>(); //ar šo mēs pasakam, ka ar šo izveidojam jaunu tukšu sarakstu
        }
        public void GiveCard(Card card)
        {
            Console.WriteLine("Spēlētājs saņēma kārti " + card.Suit + card.Value); //parādīsies paziņojums kādu kārti spēlētājs saņēma
            Cards.Add(card);
        }
        public int CountPoints()
        {
            int points = 0;
            int aceCount = 0; //cik dūži rokās

            foreach(var c in Cards) //var pats aizvietos ar reālo tipu Card, šo var lietot tur, kur kompilators var uzminēt šo tipu
            {
                points += c.GetValue();//palielinām katras kārts vērtība par get value
                if(c.Value=="A")
                {
                    aceCount++;
                }
            }
            while (points>21 && aceCount>0)
            {
                points -= 10;//tas ir tas ats, kas points = points-10
                aceCount--;
            }

            return points;
        }
        public bool NeedAnotherCard()
        {
            var answer = Game.GetAnswer("Vai nepieciešama kārts");

            return answer;
        }
    }
}
