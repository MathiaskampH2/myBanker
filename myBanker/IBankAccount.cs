using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBanker
{
    /// <summary>
    /// Interface that CardMaker class inherits
    /// every class which inherts this interface has to implement
    /// GetPrefix and GenerateAccountNumber methods.
    /// </summary>
    interface IBankAccount
    {

        string GetPrefix(int cardType);

        string GenerateAccountNumber();
    }
}
