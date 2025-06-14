using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss1.bt1
{
    public class BankAccount
    {
        private string accountNumber;
        public double Balance {  get; private set; }
        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.Balance = 0;
        }
        public void Deposit(double amout)
        {
            if (amout > 0)
            {
                Balance += amout;
            }
            else
            {
                Console.WriteLine( "vui long thu lai");
            }
        }
        public void Withdraw(double amount) {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
            }
            else { Console.WriteLine("vui long thu lai");
            }
        }
        

    }

}
