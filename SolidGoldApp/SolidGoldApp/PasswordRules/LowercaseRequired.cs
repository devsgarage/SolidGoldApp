using SolidGoldApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SolidGoldApp.PasswordRules
{
    public class LowercaseRequired : IPasswordRule
    {
        public bool IsValid(string password, string reentered)
        {
            //Needs to have at least 1 lowercase letter
            var lowercaseMatch = Regex.Match(password, "[a-z]+");
            if (!lowercaseMatch.Success)
                return false;
            else
                return true;
        }
    }
}
