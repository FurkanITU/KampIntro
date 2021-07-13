using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void AddCampaign(Gamer gamer);
        void DeleteCampaign(Gamer gamer);
    }
}
