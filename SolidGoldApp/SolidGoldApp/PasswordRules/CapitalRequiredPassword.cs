using SolidGoldApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SolidGoldApp.PasswordRules
{
    public class CapitalRequiredPassword : IPasswordRule
    {
        public bool IsValid(string password, string reentered)
        {
            //Needs to have at least 1 capital letter
            var capitalMatch = Regex.Match(password, "[A-Z]+");
            if (!capitalMatch.Success)
                return false;
            else
                return true;
        }
    }
}
