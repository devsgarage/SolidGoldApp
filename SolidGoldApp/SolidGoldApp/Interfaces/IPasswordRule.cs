using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGoldApp.Interfaces
{
    public interface IPasswordRule
    {
        bool IsValid(string password, string reentered);
    }
}
