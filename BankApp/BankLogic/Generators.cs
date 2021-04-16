using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankApp.BankLogic
{
    public class Generators
    {
        private readonly Random _rnd = new Random();

        public string BankAccountNumber()
        {
            var accountNumber = "";

            for (var i = 0; i < 25; i++)
            {
                accountNumber += _rnd.Next(0, 9);
            }

            return accountNumber;
        }

        public string ClientNumber()
        {
            var clientNumber = "";

            for (var i = 0; i < 6; i++)
            {
                clientNumber += _rnd.Next(0, 9);
            }

            return clientNumber;
        }
    }
}