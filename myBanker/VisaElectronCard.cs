using System;

namespace myBanker
{

    /// <summary>
    /// VisaElectronCard inherits from Card class.
    /// Takes all parameters in its constructor
    /// </summary>
    class VisaElectronCard :Card
    {
        public VisaElectronCard(string ownerName, string cardType, string cardNumber, string accountNumber, string accountRegNumber, DateTime expirationDate) : base(ownerName, cardType, cardNumber, accountNumber, accountRegNumber, expirationDate)
        {
        }
    }
}