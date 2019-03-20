using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace BankApp_Inlamn2
{
    public class MainMenu
    {
        bool runBank = true;

        public void Run()
        {
            BankFileHandler myBankFileHandler = new BankFileHandler();
            Bank myBank;

            try
            {
                myBank = myBankFileHandler.ReadBankData("C:\\Users\\ellen\\source\\repos\\" +
                                                        "Tidigare kurser\\C-sharp\\Inlämningsuppgifter" +
                                                        "\\BankApp_Inlamn2\\" +
                                                         "BankApp_Inlamn2\\bankdata.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException: Filen hittades inte");
                throw;
            }

            do
            {
                PrintMenu();
                SwitchForMenuChoice(myBank, myBankFileHandler);

            } while (runBank);
        }

        public void SwitchForMenuChoice(Bank bank, BankFileHandler fileHandler)
        {
            switch (ParseMenuChoice())
            {
                case 0:
                    Console.WriteLine("*Avsluta och spara*");
                    fileHandler.WriteBankData(bank);
                    Thread.Sleep(8000);
                    runBank = false;
                    break;

                case 1:
                    Console.WriteLine("*Sök kund*");
                    StringParseForCustomerSearch(bank);
                    break;

                case 2:
                    Console.WriteLine("*Visa kundbild*");
                    bool found = false;
                    do
                    {
                        Customer customerProfile = bank.FindCustomerOnAccountOrCustomerId(bank);
                        if (customerProfile != null)
                        {
                            PrintCustomerProfile(customerProfile);
                            decimal totalSaldo = PrintAccountsAndTotal(customerProfile, bank);
                            found = true;
                        }
                    } while (!found);
                    break;

                case 3:
                    Console.WriteLine("*Skapa kund*");
                    Customer newCustomer = ReadDataForNewCustomer();
                    bank.CreateNewCustomerAndAccountIds(newCustomer);
                    break;

                case 4:
                    Console.WriteLine("*Ta bort kund*");
                    Customer customerProfileToShow = bank.FindCustomerOnAccountOrCustomerId(bank);
                    if (customerProfileToShow != null)
                    {
                        PrintCustomerProfile(customerProfileToShow); //fixa
                        bank.DeleteCustomer(customerProfileToShow, bank);
                    }
                    break;

                case 5:
                    Console.WriteLine("*Skapa konto*");
                    customerProfileToShow = bank.FindCustomerOnAccountOrCustomerId(bank);
                    PrintCustomerProfile(customerProfileToShow);
                    int customerId = customerProfileToShow.CustomerId;
                    Account newAccount = bank.CreateNewAccount(customerId);
                    break;

                case 6:
                    Console.WriteLine("*Ta bort konto*");
                    customerProfileToShow = bank.FindCustomerOnAccountOrCustomerId(bank);
                    PrintReducedCustomerProfile(customerProfileToShow);
                    decimal total = PrintAccountsAndTotal(customerProfileToShow, bank);
                    Console.WriteLine("\nKONTO ATT RADERA");
                    int searchedAccountId = IntParseToSearchAccount(bank);
                    bank.DeleteAccount(searchedAccountId);
                    break;

                case 7:
                    Console.WriteLine("*Insättning*");
                    Console.WriteLine("TILL: ");
                    int toAccount = IntParseToSearchAccount(bank);
                    decimal amount = ParseForDepositAmount(toAccount, bank);
                    break;

                case 8:
                    Console.WriteLine("*Uttag*");
                    Console.WriteLine("FRÅN: ");
                    int fromAccount = IntParseToSearchAccount(bank);
                    amount = ParseForWithDrawAmount(fromAccount, bank);
                    break;

                case 9:
                    Console.WriteLine("*Överföring*");
                    Console.WriteLine("FRÅN: ");
                    fromAccount = IntParseToSearchAccount(bank);
                    Console.WriteLine("TILL: ");
                    toAccount = IntParseToSearchAccount(bank);
                    amount = ParseForTransactionAmount(fromAccount, toAccount, bank);
                    break;

                default:
                    Console.WriteLine("*Default case*");
                    break;
            }
        }

        public decimal ParseForTransactionAmount(int fromAccount, int toAccount, Bank bank)
        {
            decimal result = 0;
            bool isANumber;
            Console.WriteLine("\nBelopp (SEK): ");
            do
            {
                isANumber = Decimal.TryParse(Console.ReadLine(), out result);
                if (!isANumber)
                {
                    Console.Write("Ogiltig inmatning, ange ett sifferbelopp i (SEK). ");
                    isANumber = false;
                }
                else
                {
                    bank.Transaction(fromAccount, toAccount, result);
                    isANumber = true;
                }
            } while (!isANumber);

            return result;
        }

        public decimal ParseForDepositAmount(int toAccount, Bank bank)
        {
            decimal result = 0;
            bool isANumber;
            Console.WriteLine("\nBelopp (SEK): ");
            do
            {
                isANumber = Decimal.TryParse(Console.ReadLine(), out result);
                if (!isANumber)
                {
                    Console.Write("Ogiltig inmatning, ange ett belopp med siffror");
                    isANumber = false;
                }
                else
                {
                    bank.Deposit(toAccount, result);

                    var toAccountTemp = bank.Accounts.SingleOrDefault(a => a.AccountId == toAccount);
                    int customerIdToShow = toAccountTemp.CustomerId;
                    Customer customerProfile = bank.Customers.SingleOrDefault(c => c.CustomerId == customerIdToShow);
                    PrintAccountsAndTotal(customerProfile, bank);

                    isANumber = true;
                }

            } while (!isANumber);

            return result;
        }

        public decimal ParseForWithDrawAmount(int fromAccount, Bank bank)
        {
            decimal result = 0;
            bool isANumber;
            Console.WriteLine("\nBelopp (SEK): ");
            do
            {
                isANumber = Decimal.TryParse(Console.ReadLine(), out result);
                if (!isANumber)
                {
                    Console.Write("Ogiltig inmatning, ange ett belopp med siffror");
                    isANumber = false;
                }
                else
                {
                    bank.WithDraw(fromAccount, result);

                    var fromAccountTemp = bank.Accounts.SingleOrDefault(a => a.AccountId == fromAccount);
                    int customerIdToShow = fromAccountTemp.CustomerId;
                    Customer customerProfile = bank.Customers.SingleOrDefault(c => c.CustomerId == customerIdToShow);
                    PrintAccountsAndTotal(customerProfile, bank);

                    isANumber = true;
                }

            } while (!isANumber);

            return result;
        }

        public int IntParseToSearchAccount(Bank bank)
        {
            int result = 0;
            bool validChoice;
            Console.WriteLine("Ange kontonr: ");
            do
            {
                validChoice = Int32.TryParse(Console.ReadLine(), out result);
                var searchedAccount = bank.Accounts.SingleOrDefault(a => a.AccountId == result);

                if (!validChoice || (result.ToString().Length < 5) || (result.ToString().Length > 5))
                {
                    Console.WriteLine("Ogiltig inmatning, ange kontonr 5 siffror: ");
                    validChoice = false;
                }
                else if (searchedAccount == null)
                {
                    Console.WriteLine("Ingen sökträff, försök igen! \nAnge kontonr: ");
                    validChoice = false;
                }
            } while (!validChoice);

            return result;
        }

        public decimal PrintAccountsAndTotal(Customer customerProfile, Bank bank)
        {
            decimal total = 0;
            var allAccountsOnCustomerId = bank.Accounts.Where(a => a.CustomerId == customerProfile.CustomerId).ToList();
            foreach (Account account in allAccountsOnCustomerId)
            {
                Console.Write("\nKontonummer: " + account.AccountId);
                Console.Write("\tSaldo: " + account.Balance);
                total = total + account.Balance;
            }
            Console.WriteLine("\n\nTotalt saldo: " + total);
            return total;
        }

        public void PrintReducedCustomerProfile(Customer customerProfile)
        {
            Console.WriteLine("\nÖVERSIKT \nKundnummer: " + customerProfile.CustomerId);
            Console.WriteLine("Företagsnamn: " + customerProfile.Name);
        }

        public void PrintCustomerProfile(Customer customerProfile)
        {
            Console.WriteLine("\nKUNDBILD \nKundnummer: " + customerProfile.CustomerId);
            Console.WriteLine("Org.nr: " + customerProfile.OrgNr);
            Console.WriteLine("Namn: " + customerProfile.Name);
            Console.WriteLine("Adress: " + customerProfile.Address);
            Console.WriteLine("Ort: " + customerProfile.Town);
            Console.WriteLine("Region: " + customerProfile.Region);
            Console.WriteLine("Postnummer: " + customerProfile.ZipCode);
            Console.WriteLine("Land: " + customerProfile.Country);
            Console.WriteLine("Telefon: " + customerProfile.PhoneNr);
        }

        private Customer ReadDataForNewCustomer()
        {
            Customer nyKund = new Customer();

            Console.Write("Org.nr (XXXXXX-XXXX): ");
            nyKund.OrgNr = Console.ReadLine();

            Console.Write("Namn: ");
            nyKund.Name = Console.ReadLine();

            Console.Write("Gatuaddress & nummer: ");
            nyKund.Address = Console.ReadLine();

            Console.Write("Ort: ");
            nyKund.Town = Console.ReadLine();

            Console.Write("Region: ");
            nyKund.Region = Console.ReadLine();

            Console.Write("Postnummer: ");
            nyKund.ZipCode = Console.ReadLine();

            Console.Write("Land: ");
            nyKund.Country = Console.ReadLine();

            Console.Write("Telefonnummer: ");
            nyKund.PhoneNr = Console.ReadLine();

            return nyKund;
        }

        public void StringParseForCustomerSearch(Bank bank)
        {
            bool invalidInput = true;
            do
            {
                Console.WriteLine("Ange namn eller postort: ");
                string searchInput = Console.ReadLine().ToUpper();

                if (string.IsNullOrWhiteSpace(searchInput))
                {
                    Console.WriteLine("Ingen sökning gjord, försök igen");
                }
                else
                {
                    var searchResult = bank.SearchForCustomer(searchInput);
                    if (searchResult.Count() != 0)
                    {
                        foreach (var customer in searchResult)
                        {
                            Console.WriteLine("Kundnr: {0}    Namn: {1}",
                                               customer.CustomerId, customer.Name);
                        }
                        invalidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Ingen sökträff, skrev du rätt?");
                    }
                }
            } while (invalidInput == true);
        }

        public int IntParseForSearch()
        {
            int result = 0;
            bool validChoice;
            Console.Write("Ange kontonr eller kundnr: ");
            do
            {
                validChoice = Int32.TryParse(Console.ReadLine(), out result);
                if (!validChoice || (result.ToString().Length < 4) || (result.ToString().Length > 5))
                {
                    Console.Write("Ogiltig inmatning, ange kontonr 5 siffror/ kundnr 4 siffror: ");
                    validChoice = false;
                }
            } while (!validChoice);

            return result;
        }

        public int ParseMenuChoice()
        {
            int result = 0;
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("\nMenyval: ");
                validChoice = Int32.TryParse(Console.ReadLine(), out result);
                if (!validChoice || result > 9)
                {
                    Console.WriteLine("Du kan bara ange en siffra 0-9");
                    validChoice = false;
                }
            }
            return result;
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n\nHUVUDMENY");
            Console.WriteLine("0) Avsluta och spara");
            Console.WriteLine("1) Sök kund");
            Console.WriteLine("2) Visa kundbild");
            Console.WriteLine("3) Skapa kund");
            Console.WriteLine("4) Ta bort kund");
            Console.WriteLine("5) Skapa konto");
            Console.WriteLine("6) Ta bort konto");
            Console.WriteLine("7) Insättning");
            Console.WriteLine("8) Uttag");
            Console.WriteLine("9) Överföring");
        }
    }
}
