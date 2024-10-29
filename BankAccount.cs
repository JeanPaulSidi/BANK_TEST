using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_TEST
{
    public class BankAccount
    {
        string _name;
        string _password;
        decimal _balance;


        private BankAccount(string Name, string Password, decimal Balance) 
        {
            _name = Name;
            _password = Password;
            _balance = Balance;
        }

        public BankAccount() { }

        public decimal Balance 
        {
            get { return _balance; }
        }

        public string Name 
        {
            get { return _name; }
        }

        public BankAccount Login(string Name, string Password) 
        {
            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("bert", "sesame1", 200m));
            accounts.Add(new BankAccount("ernie", "Sesame2", 1000m));
        
            bool CredentialsMatch;
            int i = 0;
            CredentialsMatch = false;

            do
            {
                if (Name == accounts[i]._name && Password == accounts[i]._password)
                {
                    CredentialsMatch = true;
                }
                else 
                {
                    i++;
                }

            } while( (!CredentialsMatch) && (i != accounts.Count) );
            
            if (CredentialsMatch) 
            {
                return accounts[i];
            }
            else 
            {
                return null;
            }
        }

        public string Deposit(decimal Amount) 
        {
            string Message;

            _balance += Amount;
            Message = ("succes. new balance:");

            return Message + _balance.ToString("C");
        }
    }
}
