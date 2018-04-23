using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Klases
{
    class Game
    {
        public Dealer Dealer;
        public Player Player;
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
                Deck = new Deck();      //katru reizi, kad tiks uzsākta jauna spēle, tiks izveidotas jaunas šīs lietas
                Dealer = new Dealer();
                Player = new Player();

            }
            return startNew;
        }
        public static bool GetAnswer(string question) //izsauksim šo funkciju ar trīs rindiņām vienmēr, kad mums būs jautājums
        {
            Console.Write(question + "jā/nē");
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "jā";

            return answer;
        }
    }
}
