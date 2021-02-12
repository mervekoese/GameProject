using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    interface IGameCampaign
    {
        bool Entry(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
