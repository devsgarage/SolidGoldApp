using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace SolidGoldApp.BusinessLogic
{
    public class PasswordValidation
    {
        public PasswordValidation()
        {
            
        }

        public bool IsValid(string password, string secondPassword)
        {
            //Needs to be at least 6 characters long
            if (password.Length < 6)
                return false;

            //Needs to be less than 16 characters long
            if (password.Length > 15)
                return false;

            //Needs to have at least 1 capital letter
            var capitalMatch = Regex.Match(password, "[A-Z]+");
            if (!capitalMatch.Success)
                return false;

            //Needs to have at least 1 lowercase letter
            var lowercaseMatch = Regex.Match(password, "[a-z]+");
            if (!lowercaseMatch.Success)
                return false;

            //Needs to have at least 1 special characters
            var specialCharacterMatch = Regex.Match(password, "[/~/!/@/#/$/%/^/&/*/</>/?]+");
            if (!specialCharacterMatch.Success)
                return false;

            //Needs to have at least 1 number
            var numberMatch = Regex.Match(password, "[0-9]+");
            if (!numberMatch.Success)
                return false;

            //Both entered passwords need to match
            if (!password.Equals(secondPassword))
                return false;

            return true;
        }
    }
}
