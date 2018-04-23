using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Klases
{
    public class Deck
    {
        //Masti: Hearts, Diamonds, Spades, Clubs
        public char[] Suits = { 'H', 'D', 'S', 'C' }; //simbolus liek mazajās pēdiņās, tekstu dubultajās pēdiņās, te mēs četrus mastus izveidojam
        //kāršu vērtības
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //kārtis, saraksts ar kārtīm
        public List<Card> Cards;

        public Deck() //šis ir konstruktors
        {
            Cards = new List<Card>(); //52, jo kāršu kavā ir 52 kārtis, likām listu, lai var mainīt un aizvietot
            foreach (char s in Suits) //šis cikls apstrādā mastus
            {
                foreach(string v in Values) //un iekš tā otrs cikls apstrādā vērtības
                {
                    //pievieno kārti kāršu kavai ar vērtību un mastu
                    Cards.Add(new Card(v, s));
                }
            }
        }
        //paņem kārti un izņem no saraksta, lai nevar paņemt divreiz vienu unto pašu
        public Card TakeCard()
        {
            Card newCard = Cards[0]; //visu laiku ņem kārti no augšas
            Cards.RemoveAt(0); //paņemam augšejo kārti (pirmo elementu no saraksta) (izdzēsa no saraksta)

            return newCard; //atgriežam kārti, ko paņēmām, jo dīleris to atdos spēlētājam, bet iepriekšējā rindaizdzēsa no saraksta
        }
        //Ieveido jaunu kāršu kavu
        public Deck TakeNewDeck()
        {
            return null;
        }

        //sajauc kāršu kavu
        public void Shuffle()
        {

        }
    }
}
