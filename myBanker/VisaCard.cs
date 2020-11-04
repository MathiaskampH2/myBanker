using System;

namespace myBanker
{

    /// <summary>
    /// VisaCard inherits from Card class.
    /// Takes all parameters in its constructor
    /// </summary>
    class VisaCard :Card
    {
        public VisaCard(string ownerName, string cardType, string cardNumber, string accountNumber, string accountRegNumber, DateTime expirationDate) : base(ownerName, cardType, cardNumber, accountNumber, accountRegNumber, expirationDate)
        {

        }
    }
}