using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class GameCampaign : IGameCampaign
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Kampanya Silinmiştir"); 
            
        }
        
        public bool Entry(Game game)
        {
            if (game.Price < 120 && game.PlayRate < 50)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine("Kampanya Güncellendi");

        }
    }
}
