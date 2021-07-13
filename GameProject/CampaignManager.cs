using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Gamer gamer)
        {
            Console.WriteLine("%20 indirim uygula");
        }

        public void DeleteCampaign(Gamer gamer)
        {
            Console.WriteLine("%20 indirimi kaldır");
        }
    }
}
