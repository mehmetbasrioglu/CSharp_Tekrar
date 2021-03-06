using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignDesc + " New Campaign Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignDesc + " New Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignDesc + " New Campaign Updated");
        }
    }
}
