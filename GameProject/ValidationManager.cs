using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Furkan"&& gamer.IdentityNum==1234 && gamer.BirthYear==2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
