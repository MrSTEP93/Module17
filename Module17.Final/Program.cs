using Module17.Final.Accounts;
using Module17.Final.Calculator;
using Module17.Final.Calculator.Calculator;
using System;

namespace Module17.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Account acc = new Account();
            acc.Type = AccountTypes.Common;
            acc.Balance = 1000.0;
            InterestCalculator.CalculateInterest(acc, new SalaryAccountInterestCalculator());
        }
    }
}
