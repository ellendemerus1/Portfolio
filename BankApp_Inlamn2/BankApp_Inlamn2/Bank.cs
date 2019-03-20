using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BankApp_Inlamn2
{
    public class Bank
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Account> Accounts { get; set; } = new List<Account>();

        public List<Customer> SearchForCustomer(string input)
        {
            var foundCustomers = Customers.Where(c => c.Name.ToUpper().Contains(input) || c.Town.ToUpper().Contains(input))
                                                     .Select(c => c).ToList();
            return foundCustomers;
        }

        public Customer FindCustomerOnAccountOrCustomerId(Bank bank)
        {
            int result = 0;
            bool validChoice;
            Customer customerProfile = null;
            bool found = false;
            Console.Write("Ange kontonr eller kundnr: ");
            do
            {
                validChoice = Int32.TryParse(Console.ReadLine(), out result);
                if (!validChoice || (result.ToString().Length < 4) || (result.ToString().Length > 5))
                {
                    Console.WriteLine("Ogiltig inmatning, vänligen ange kontonummer 5 siffror eller kundnummer 4 siffror: ");
                    validChoice = false;
                }
            } while (!validChoice);

            do
            {
                var searchedAccount = Accounts.SingleOrDefault(a => a.AccountId == result);
                customerProfile = Customers.SingleOrDefault(c => c.CustomerId == result);

                if (searchedAccount != null)
                {
                    var customerIdToShow = searchedAccount.CustomerId;
                    customerProfile = Customers.SingleOrDefault(c => c.CustomerId == customerIdToShow);
                    found = true;
                    return customerProfile;
                }
                else if (customerProfile != null)
                {
                    var customerIdToShow = customerProfile.CustomerId;
                    customerProfile = Customers.SingleOrDefault(c => c.CustomerId == customerIdToShow);
                    found = true;
                    return customerProfile;
                }
                else
                {
                    Console.WriteLine("Ingen sökträff, skrev du rätt kund-/kontonummer?");
                    FindCustomerOnAccountOrCustomerId(bank);
                    return customerProfile;
                }

            } while (!found);
        }

        private void PrintCustomerProfile(Customer customerProfile)
        {
            Console.WriteLine("\nKUNDBILD \nKundnummer: " + customerProfile.CustomerId);
            Console.WriteLine("Organisationsnummer: " + customerProfile.OrgNr);
            Console.WriteLine("Företagsnamn: " + customerProfile.Name);
            Console.WriteLine("Adress: " + customerProfile.Address);
            Console.WriteLine("Stad: " + customerProfile.Town);
            Console.WriteLine("Region: " + customerProfile.Region);
            Console.WriteLine("Postnummer: " + customerProfile.ZipCode);
            Console.WriteLine("Land: " + customerProfile.Country);
            Console.WriteLine("Telefon: " + customerProfile.PhoneNr);
        }

        public Account CreateNewAccount(int customerId)
        {
            //tar fram unikt kontonummer
            var orderByAccountId = Accounts.OrderByDescending(a => a.AccountId);

            var highestAccountId = (from a in orderByAccountId
                                    select a.AccountId).First();
            highestAccountId++;
            Account newAccount = new Account(highestAccountId, customerId, 0);

            Accounts.Add(newAccount);
            Console.Write("\nTilldelat kontonummer: {0}", newAccount.AccountId);

            return newAccount;
        }

        public void CreateNewCustomerAndAccountIds(Customer newCustomer)
        {
            //tar fram unikt kundnummer
            var orderByCustomerId = Customers.OrderByDescending(c => c.CustomerId);

            var highestCustomerId = (from c in orderByCustomerId
                                     select c.CustomerId).First();
            highestCustomerId++;
            var firstFreeCustomerId = highestCustomerId;
            newCustomer.CustomerId = firstFreeCustomerId;

            //tar fram unikt kontonummer
            var orderByAccountId = Accounts.OrderByDescending(a => a.AccountId);

            var highestAccountId = (from a in orderByAccountId
                                    where a.AccountId.ToString().Length == 5
                                    select a.AccountId).First();
            highestAccountId++;
            Account newAccount = new Account(highestAccountId, firstFreeCustomerId, 0);

            Customers.Add(newCustomer);
            Accounts.Add(newAccount);
            Console.Write("\n*Ny kund skapad* \nTilldelat kundnummer: {0} \n " +
                          "Öppnat transaktionskonto: {1}", newCustomer.CustomerId,
                                                           newAccount.AccountId);
        }

        public void Transaction(int fromAccount, int toAccount, decimal amount)
        {
            var account = Accounts.SingleOrDefault(a => a.AccountId == fromAccount);
            if (account.Balance >= amount)
            {
                account.Balance = account.Balance - amount;
                var toAccountTemp = Accounts.SingleOrDefault(a => a.AccountId == toAccount);
                toAccountTemp.Balance = toAccountTemp.Balance + amount;

                Console.WriteLine("\n" + string.Format("{0:0.00}", amount) +
                                  " kr överfört från konto {0} till {1}.", fromAccount, toAccount);
            }   
            else
            {
                Console.WriteLine("\n***INGEN TÄCKNING PÅ KONTO FÖR DENNA TRANSAKTION***");
            }
        }

        public void Deposit(int toAccount, decimal amount)
        {
            var toAccountTemp = Accounts.SingleOrDefault(a => a.AccountId == toAccount);
            toAccountTemp.Balance = toAccountTemp.Balance + amount;

            Console.WriteLine("\n" + string.Format("{0:0.00}", amount) + 
                                                              " kr insatt på konto {0}", toAccount);
            Console.WriteLine("Uppdaterat saldo på kundens konto/n: ");
        }

        public void WithDraw(int fromAccount, decimal amount)
        {
            var fromAccountTemp = Accounts.SingleOrDefault(a => a.AccountId == fromAccount);

            if (fromAccountTemp.Balance >= amount)
            {
                fromAccountTemp.Balance = fromAccountTemp.Balance - amount;
                Console.WriteLine("\n" + string.Format("{0:0.00}", amount) +
                                                       " kr uttaget från konto {0}", fromAccount);
                Console.WriteLine("Uppdaterat saldo på kundens konto/n: ");
            }
            else
            {
                Console.WriteLine("\n***INGEN TÄCKNING PÅ KONTO FÖR DENNA TRANSAKTION***" +
                                  "\n\nSaldo kundens samtliga konton:");
            }
        }

        public void DeleteAccount(int input)
        {
            var accountToDelete = Accounts.SingleOrDefault(a => a.AccountId == input);

            if (accountToDelete.Balance == 0)
            {
                Accounts.Remove(accountToDelete);
                Console.WriteLine("Konto {0} är nu borttaget", input);
            }
            else
            {
                Console.WriteLine("\nKonto kan raderas endast om saldo är 0 kr");
            }
        }

        public void DeleteCustomer(Customer customerProfile, Bank myBank)
        {
            var customerIdToShow = customerProfile.CustomerId;

            var allAccountsOnCustomerId = (from account in Accounts
                                           where account.CustomerId == customerProfile.CustomerId
                                           select account).ToList();
            if (allAccountsOnCustomerId.Count == 0)
            {
                var customerToDelete = Customers.SingleOrDefault(a => a.CustomerId == customerProfile.CustomerId);
                Customers.Remove(customerToDelete);
                Console.WriteLine("Kund nr {0} är nu borttagen", customerProfile.CustomerId);
            }
            else
            {
                Console.WriteLine("\nEndast kund utan konto kan raderas.");
            }
        }
    }
}
