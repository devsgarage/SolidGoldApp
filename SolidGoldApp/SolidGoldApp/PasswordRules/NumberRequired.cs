using SolidGoldApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SolidGoldApp.PasswordRules
{
    public class NumberRequired : IPasswordRule
    {
        public bool IsValid(string password, string reentered)
        {
            //Needs to have at least 1 number
            var numberMatch = Regex.Match(password, "[0-9]+");
            if (!numberMatch.Success)
                return false;
            else
                return true;
        }
    }
}
