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

        public Deck() //šis ir konstruktors arī ir funkcija, jo iekavas beigās un nav semikols, nav pirekšā nav nekāds tips un nav void, neko neatgriež , tā tad konstruktors un funkcijas nosaukums sakrīt ar klases nosaukumu
        {            //konstruktors ir nepieciešams, kad tiek veidota jauna funkcijas (Game klasē tiek izsaukts Deck=new Deck(); jauns objekts
            Cards = new List<Card>(); //52, jo kāršu kavā ir 52 kārtis, likām listu, lai var mainīt un aizvietot
            foreach (char s in Suits) //šis cikls apstrādā mastus, šis un nākamais foreach izveido visas iespējamās kombinācijas no suits un value
            {
                foreach(string v in Values) //un iekš tā otrs cikls apstrādā vērtības
                {
                    //pievieno kārti kāršu kavai ar vērtību un mastu - 4mastix13vertibas=52 kartis
                    Cards.Add(new Card(v, s));
                }
            }
        }
        //paņem kārti un izņem no saraksta, lai nevar paņemt divreiz vienu unto pašu
        public Card TakeCard() //funkcija, jo ir iekavas, izpildās secīgi
        {
            Card newCard = Cards[0]; //visu laiku ņem kārti no augšas, pasakām, ka jauns mainīgais - kārds un paņem 1.elementu sarakstā
            Cards.RemoveAt(0); //paņemam augšejo kārti (pirmo elementu no saraksta) (izdzēsa no saraksta)

            return newCard; //atgriežam kārti kā rezultātu tai TakeCard funkcijai, ko paņēmām, jo dīleris to atdos spēlētājam, bet iepriekšējā rindaizdzēsa no saraksta
        }
        //Ieveido jaunu kāršu kavu
        public static Deck TakeNewDeck()
        {
            return new Deck();
        }
        //sajauc kāršu kavu
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList(); //randomā sakārto sarakstu, mēs saka - katru kārti likt mainīgajā c
        }
    }
}
