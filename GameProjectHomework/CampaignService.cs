using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectHomework
{
    class CampaignService
    {
        public void campaignAdd(CampaignAdd campaign)
        {
            Console.WriteLine("Campaign added succesfully!.");
        }

        public void campaignApply(CampaignAdd campainAdded, GameType availableGame) 
        {
            if(campainAdded.CampaignGame==availableGame.GameName)
            {
                Console.WriteLine("campaign applied succesfully!");
            }
            else
            {
                Console.WriteLine("Campaign game and this game are not same!. Failed.");
            }
        }
    }
}
