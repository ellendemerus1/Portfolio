using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApp_Inlamn2
{
    public class BankFileHandler
    {
        public Bank ReadBankData(string path)
        {
            Bank myBank = new Bank();
            Console.WriteLine("\n*** VÄLKOMMEN TILL BANKAPP 1.0 ***");
            Console.WriteLine("Läser in bankdata.txt...");

            using (StreamReader reader = new StreamReader(path))
            {
                int countOfCustomers = int.Parse(reader.ReadLine());
                Console.WriteLine("Antal kunder: " + countOfCustomers);

                for (int i = 0; i < countOfCustomers; i++)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(';');

                    Customer customer = new Customer
                    {
                        CustomerId = int.Parse(columns[0]),
                        OrgNr = columns[1],
                        Name = columns[2],
                        Address = columns[3],
                        Town = columns[4],
                        Region = columns[5],
                        ZipCode = columns[6],
                        Country = columns[7],
                        PhoneNr = columns[8],
                    };

                    myBank.Customers.Add(customer);
                }

                int countOfAccounts = int.Parse(reader.ReadLine());
                Console.WriteLine("Antal konton: " + countOfAccounts);
                decimal total = 0;

                for (int i = 0; i < countOfAccounts; i++)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(';');

                    //Läser in account-info med styrd constructor, pga private set)
                    Account account = new Account(accountId: int.Parse(columns[0]),
                                                  customerId: int.Parse(columns[1]),
                                                  balance: decimal.Parse(columns[2], CultureInfo.InvariantCulture));
                    total = total + account.Balance;
                    myBank.Accounts.Add(account);
                }
                Console.WriteLine("Totalt saldo: " + total);
            }
            return myBank;
        }

        public void WriteBankData(Bank myBank)
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Sparar till {0}.txt...", DateTime.Now); //fixa denna utskrift, datum i rätt format

            using (StreamWriter writer = new StreamWriter(DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt"))
            {
                int countOfCustomers = myBank.Customers.Count;
                writer.WriteLine(countOfCustomers);
                Console.WriteLine("Antal kunder: " + countOfCustomers);

                decimal total = 0;

                foreach (Customer c in myBank.Customers)
                {
                    writer.WriteLine(c.CustomerId + ";" + c.OrgNr + ";" + c.Name + ";" + c.Address + ";" +
                        c.Town + ";" + c.Region + ";" + c.ZipCode + ";" + c.Country + ";" + c.PhoneNr);
                }

                int countOfAccounts = myBank.Accounts.Count;
                writer.WriteLine(countOfAccounts);
                Console.WriteLine("Antal konton: " + countOfAccounts);

                foreach (Account a in myBank.Accounts)
                {
                    writer.WriteLine(a.AccountId + ";" + a.CustomerId + ";" + a.Balance.ToString(invariantCulture));
                    total = total + a.Balance;
                }
                Console.WriteLine("Totalt saldo: " + total);
            }
        }

    }
}
