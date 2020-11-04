using System;

namespace myBanker
{
    /// <summary>
    /// DebitCard inherits from Card class.
    /// Takes all parameters in its constructor
    /// </summary>
    class DebitCard :Card
    {
        public DebitCard(string ownerName, string cardType, string cardNumber, string accountNumber, string accountRegNumber, DateTime expirationDate) : base(ownerName, cardType, cardNumber, accountNumber, accountRegNumber, expirationDate)
        {

        }
    }
}