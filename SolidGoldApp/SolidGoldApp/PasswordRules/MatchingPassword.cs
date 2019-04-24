using SolidGoldApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGoldApp.PasswordRules
{
    public class MatchingPassword : IPasswordRule
    {
        public bool IsValid(string password, string reentered)
        {
            //Both entered passwords need to match
            if (!password.Equals(reentered))
                return false;
            else
                return true;
        }
    }
}
