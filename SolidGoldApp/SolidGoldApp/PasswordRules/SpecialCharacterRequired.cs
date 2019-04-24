using SolidGoldApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SolidGoldApp.PasswordRules
{
    public class SpecialCharacterRequired : IPasswordRule
    {
        public bool IsValid(string password, string reentered)
        {
            //Needs to have at least 1 special characters
            var specialCharacterMatch = Regex.Match(password, "[/~/!/@/#/$/%/^/&/*/</>/?]+");
            if (!specialCharacterMatch.Success)
                return false;
            else
                return true;
        }
    }
}
