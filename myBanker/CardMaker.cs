using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace myBanker
{
    /// <summary>
    /// CardMaker Class inherits from IBankAccount
    /// has the purpose of creating Card objects and give the object Values
    /// </summary>
    public class CardMaker :IBankAccount
    {
       

        Random r = new Random();

        
        public string GenerateCardNumber(int max)
        {
           StringBuilder sb = new StringBuilder();
                
           while (sb.Length < max)
           {
               sb.Append(r.Next(10).ToString());
           }

           return sb.ToString();
        }



        public string PickPrefixMaestro()
        {
            int rngPrefix = r.Next(1, 9);
            string prefix = null;

            switch (rngPrefix)
            {
                case 1:
                    prefix = "5018";
                    break;

                case 2:
                    prefix = "5020";
                    break;

                case 3:
                    prefix = "5038";
                    break;

                case 4:
                    prefix = "5893";
                    break;

                case 5:
                    prefix = "6304";
                    break;

                case 6:
                    prefix = "6759";
                    break;

                case 7:
                    prefix = "6761";
                    break;

                case 8:
                    prefix = "6762";
                    break;

                case 9:
                    prefix = "5018";
                    break;
            }

            return prefix;

        }

        public string PickPrefixDebit()
        {
            string prefixDebit = "2400";

            return prefixDebit;
        }

        public string GetPrefix(int cardType)
        {
            string prefix = null;

            switch (cardType)
            {
                case 1:
                    prefix = PickPrefixDebit();
                    break;
                case 2:
                    prefix = PickPrefixMaestro();
                    break;
            }

            return prefix;
        }



        public string GenerateAccountNumber()
        {
            StringBuilder sb = new StringBuilder();

            while (sb.Length < 10)
            {
                sb.Append(r.Next(10).ToString());
            }

            return sb.ToString();
        }

        public string CallGenerateCardNumber(int max)
        {
            return GenerateCardNumber(max);
        }

        public string ChooseCardType(int type)
        {
            string cardType = null;

            if (type == 1)
            {
                cardType = "Debit Card";
            }

            else if (type == 2)
            {
                cardType = "Maestro Card";
            }

            else if (type == 3)
            {
                cardType = "Visa Electron Card";
            }

            else if (type == 4)
            {
                cardType = "Visa Card";
            }
            else if (type == 5)
            {
                cardType = "Master Card";
            }

            return cardType;
        }

        public DateTime GetExpirationDate(int cardType)
        {
            DateTime dateNow = DateTime.Today;

            if (cardType == 1)
            {
                dateNow = DateTime.MaxValue;
            }

            else if (cardType == 2)
            {
                dateNow = dateNow.AddYears(+5).AddMonths(+8);
            }

            else if (cardType == 3 || cardType == 4 || cardType == 5)
            {
                dateNow = dateNow.AddYears(+5);
            }

            return (dateNow.Date);
        }

        // Appends 
        public string Combine15DigitCardNumberWithPrefix(int cardType)
        {

            string cardNumberGenerated = CallGenerateCardNumber(15);
            string prefix = GetPrefix(cardType);

            string cardNumber = prefix + cardNumberGenerated;

            return cardNumber;
        }


        public string Combine12DigitCardNumberWithPrefix(int cardType)
        {

            string cardNumberGenerated = CallGenerateCardNumber(12);
            string prefix = GetPrefix(cardType);
            
            string cardNumber = prefix + cardNumberGenerated;

            return cardNumber;
        }


        public Card CreateCard (int createNewCard, string name, int type)
        {
            string cardType = ChooseCardType(type);
            string cardNumber12 = Combine12DigitCardNumberWithPrefix(type);
            string cardNumber15 = Combine15DigitCardNumberWithPrefix(type);
            string accountNumber = GenerateAccountNumber();
            string accountRegNumber12 = cardNumber12.Substring(0,4);
            string accountRegNumber15 = cardNumber15.Substring(0, 4);

            DateTime expirationDate = GetExpirationDate(type);


            switch (createNewCard)
            {

                   
                case 1:
                    return new DebitCard(name, cardType, cardNumber12, accountNumber, accountRegNumber12,expirationDate);

                case 2:
                    return new MaestroCard(name, cardType, cardNumber15, accountNumber, accountRegNumber15, expirationDate);

                case 3:
                // Need more time to implement the rest of the cards

                case 4:
                // Need more time to implement the rest of the cards

                case 5:
                // Need more time to implement the rest of the cards


                default:
                    return null;
            }

            
        }
    }
}