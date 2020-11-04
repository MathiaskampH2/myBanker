using System;

namespace myBanker
{

    /// <summary>
    /// MasterCard inherits from Card class.
    /// Takes all parameters in its constructor
    /// </summary>
    class MasterCard :Card
    {
        public MasterCard(string ownerName, string cardType, string cardNumber, string accountNumber, string accountRegNumber, DateTime expirationDate) : base(ownerName, cardType, cardNumber, accountNumber, accountRegNumber, expirationDate)
        {
        }
    }
}