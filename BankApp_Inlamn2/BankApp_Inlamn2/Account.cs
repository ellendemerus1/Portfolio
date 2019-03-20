using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp_Inlamn2
{
    public class Account
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }

        public Account(int accountId, int customerId, decimal balance)
        {
            AccountId = accountId;
            CustomerId = customerId;
            Balance = balance;
        }
    } //metoder i Account-klassen?
}