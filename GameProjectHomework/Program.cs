using System;

namespace GameProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerProfile Gamer1 = new GamerProfile();
            Gamer1.Id = 1;
            Gamer1.GamerName = "ahmet";
            Gamer1.GamerLastName = "ucdag";
            Gamer1.GamerNationa = "turkey";

            GamerService gamerService = new GamerService();
            gamerService.GamerAdd(Gamer1);
            gamerService.GamerUptade(Gamer1);
            gamerService.GamerDelete(Gamer1);

            GameType gamefirst = new GameType();
            gamefirst.GameId = 11;
            gamefirst.GameName = "Counter Strike:Global Offensive";
            gamefirst.GamePrice = "12";

            GameBuyService gameBuy = new GameBuyService();
            gameBuy.BuyGame(Gamer1, gamefirst);

            CampaignAdd campaign1 = new CampaignAdd();
            campaign1.CampaignGame = "Counter Strike:Global Offensive";
            campaign1.CampaignId = 1;
            campaign1.amountOfDiscount = "20 dolar indirim";

            CampaignService campaignApply1 = new CampaignService();
            campaignApply1.campaignApply(campaign1,gamefirst);


            Console.ReadLine();
        }
    }
}
