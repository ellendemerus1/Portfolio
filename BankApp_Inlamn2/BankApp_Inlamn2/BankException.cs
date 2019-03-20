using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp_Inlamn2
{
    public class BankException : Exception
    {
        public string Notice;

        public string MyProperty
        {
            get { return Notice; }
            set
            {
                Notice = "Ingen sökträff, skrev du rätt kund-/kontonummer?";
            }
        }


        public BankException(String notice)
        {
            Notice = notice;
        }
    }
}
