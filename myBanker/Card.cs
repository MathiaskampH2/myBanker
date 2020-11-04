using System;

namespace myBanker
{

    /// <summary>
    /// Abstract class Card
    /// Which cannot be instantiated
    /// used to make Card objects in CardMaker class
    /// </summary>
    public abstract class Card
    {
        protected string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        protected string ownerName;

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }


        protected string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        protected string accountRegNumber;

        public string AccountRegNumber
        {
            get { return accountRegNumber; }
            set { accountRegNumber = value; }
        }

        protected DateTime expirationDate;

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        protected string cardType;

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }


        protected  Card(string ownerName, string cardType, string cardNumber, string accountNumber, string accountRegNumber, DateTime expirationDate)
        {
            this.ownerName = ownerName;
            this.cardType = cardType;
            this.cardNumber = cardNumber;
            this.accountNumber = accountNumber;
            this.accountRegNumber = accountRegNumber;
            this.expirationDate = expirationDate;

        }

        public override string ToString()
        {
            return
                "Card Owner: " + ownerName + "\n"
                +"Card Type: " + cardType + "\n"
                +"Card Number: " + cardNumber + "\n" 
                + "Account Number: " + accountNumber + "\n"
                + "Account Reg Number: " + accountRegNumber + "\n"
                + "Expiration Date :" + expirationDate.ToString("dd/MM/yyyy");
        }
    }
}