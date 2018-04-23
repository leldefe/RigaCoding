using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Klases
{
    class Game
    {
        public Dealer Dealer; //mainīgie, kas tiks izmantoti šajā klasē - īpašības, kas nepieciešamas, lai šī klase funkcionēta
        public Player Player; //ja tiek ierakstīts šeit augšā, tad ir pieejams citām funkcijām, ja ierakstīs funkcijas ietvaros, tad tikai funkcijā būs pieejams, piem., Deck Deck = new Deck(); lejā zem startNew if-a
        public Deck Deck;

        public bool StartNewGame()
        {
            /*Console.Write("Vai uzsākt spēli jā/nē)? ");
            string atbilde = Console.ReadLine().ToLower();//uzreiz pārveidojām atbildi uz mazajiem burtiem
            bool startNew = atbilde == "jā"; */ //jā atbilde būs "jā", tad būs true, citos gadījumos būs false
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli?"); //augšējās 3 rindas izdzēsām, jo uztaisījām jaunu funkciju zemāk public static bool GetAnswer un ņemam to

        
            if (startNew)
            {
                Console.WriteLine("Uzsākt jaunu spēli!");
                Deck = Deck.TakeNewDeck();      //bija Deck= new Deck(), bet aizvietojām ar esošo, jo izražojām Deck klasē statisku jaunu funkciju. Katru reizi, kad tiks uzsākta jauna spēle, tiks izveidotas jaunas šīs lietas
                Dealer = new Dealer();
                Player = new Player();

                Deck.Shuffle();
                Card card = Deck.TakeCard();
                Console.WriteLine("Kārts " + card.Value + card.Suit);

            }
            return startNew;
        }
        public static bool GetAnswer(string question) //izsauksim šo funkciju ar trīs rindiņām vienmēr, kad mums būs jautājums
        {
            Console.Write(question + "jā/nē ");
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "jā";

            return answer;
        }
    }
}
