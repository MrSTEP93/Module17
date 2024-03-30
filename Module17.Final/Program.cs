using Module17.Final.Accounts;
using System;

namespace Module17.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Account acc = new Account();
            acc.Type = new CommonAccount();
            acc.Balance = 1000.0;
            Calculator.CalculateInterest(acc);
        }
    }
}
