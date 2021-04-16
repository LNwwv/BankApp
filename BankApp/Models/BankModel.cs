using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class Transfer
    {
        public string UserAccountNumber { get; set; } //from
        public string Name { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string AccountNumber { get; set; } //to
    }
   
}

