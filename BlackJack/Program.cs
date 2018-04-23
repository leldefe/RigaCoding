using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Klases; //tāpēc, ka man tas ir kaut kādā citā folderī un solūcijas ietvaros (VISAS SOLŪCIJAS) var te pievienot

namespace BlackJack
{
    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
               if (!game.StartNewGame()) //izsaukuma zīme nozīmē "nav" un, ja lietotājs ievadīja nē klasē game, tad nostrādā break un izvadās - Spēle pabeigta
                {
                    break;
                }
            }
            Console.WriteLine("Spēle pabeigta!");
            Console.ReadLine();
        }
    }
}
