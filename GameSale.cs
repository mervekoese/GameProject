using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class GameSale : IGameSale
    {
        IValidationService _validateService;
        GameCampaign _gameCampaign;
        
       
        public GameSale(IValidationService validateService, GameCampaign gameCampaign) //satışı bu iki parametreye bağlı hale getirdim.
        {
            _validateService = validateService;
            _gameCampaign = gameCampaign;
        }


        public void Sale(Gamer gamer,Game game)
        {
            
            if (_validateService.Validate(gamer) == true)
            {
                if (_gameCampaign.Entry(game) == false)
                {
                    Console.WriteLine("Satışınız malesef ki kampanyasız gerçekleşmiştir." );
                }
                if (_gameCampaign.Entry(game) == true)
                {
                    Console.WriteLine("Satışınız kampanyalı gerçekleşmiştir.");

                }
            }
            else
            {
                Console.WriteLine("Satın alamazsın,çünkü kaydın yok.");
            }
        
        }


        /*public void Sale(Gamer gamer, Game game)
        {

            if (_validateService.Validate(gamer) == true && _gameInformationManager.GameValidate(game) == true)
            {
                
                Console.WriteLine("Satışınız kampanyalı gerçekleşmiştir.");
            }
            else if (_gameInformationManager.GameValidate(game) == true && _gameInformationManager.GameValidate(game) == false)
            {
            Console.WriteLine("Satışınız gerçekleşmiştir.");

            }
            else if(_gameInformationManager.GameValidate(game) == false && _gameInformationManager.GameValidate(game) == false)
            {
                Console.WriteLine("Satın alamazsın,çünkü kaydın yok.");
            }

        }*/
    }
}
