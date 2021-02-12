using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ValidationManager : IValidationService

    {

        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Merve" && gamer.LastName == "Köse" && gamer.IdentityNumber == "12345" && gamer.Adress == "Istanbul")
                return true;
            else
            {
                return false;
            }

        }
    }
}
