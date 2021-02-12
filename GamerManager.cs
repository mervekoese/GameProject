using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class GamerManager:IGamerManagerService
    {

        IValidationService _validationService;

        public GamerManager(IValidationService loglamaService)
        {
            _validationService = loglamaService;
        }

        public void Add(Gamer gamer)
        {
            if(_validationService.Validate(gamer)==true)

            Console.WriteLine("Kayıt eklendi.");
            else
            {
                Console.WriteLine("Kayıt eklenemedi,başarısız!");
            }
        }
        public void Delete(Gamer person)
        {
            Console.WriteLine("Personel silindi.");
        }
        public void Update(Gamer person)
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
}
