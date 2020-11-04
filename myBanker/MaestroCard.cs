﻿using System;

namespace myBanker
{

    /// <summary>
    /// MaestroCard inherits from Card class.
    /// Takes all parameters in its constructor
    /// </summary>
    class MaestroCard :Card
    {
        public MaestroCard(string ownerName, string cardType, string cardNumber, string accountNumber, string accountRegNumber, DateTime expirationDate) : base(ownerName, cardType, cardNumber, accountNumber, accountRegNumber, expirationDate)
        {
        }
    }
}