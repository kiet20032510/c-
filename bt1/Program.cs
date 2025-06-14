using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss1.bt1
{
    internal class Program
    {
        static void Main(string[] args) {
            var acc = new BankAccount("123456");
            acc.Deposit(1000);
            acc.Withdraw(200);
            Console.WriteLine(acc.Balance);
        }
    }
}
