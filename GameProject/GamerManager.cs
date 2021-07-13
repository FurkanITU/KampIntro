using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;
        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer))
            {
                Console.WriteLine("kullanici dogrulandi");
            }
            else
            {
                Console.WriteLine("kullanici dogrulanamadi");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated");
        }
    }
}
