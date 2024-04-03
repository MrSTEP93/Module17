using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module17.Final.Accounts;

namespace Module17.Final.Calculator.Calculator
{
    public class CommonAccountInterestCalculator : IInterestCalculator
    {
        public double CalculateInterest(double balance)
        {

            // расчет процентной ставки обычного аккаунта по правилам банка
            double interest = balance * 0.4;

            if (balance  < 1000)
                interest -= balance * 0.2;

            if (balance >= 1000)
                interest -= balance * 0.1;

            return interest;
        }
    }
}
