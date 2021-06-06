using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectHomework
{
    class GameBuyService
    {
        public void BuyGame(GamerProfile gamerProfile, GameType gameType)
        {
            Console.WriteLine(gamerProfile.GamerName + "  " + gamerProfile.GamerLastName + "  " + " bought " + gameType.GameName + " succesfully for " + gameType.GamePrice + " dolar");
        }
    }
}
