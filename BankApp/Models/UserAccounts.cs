using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class UserAccounts
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
    }
}