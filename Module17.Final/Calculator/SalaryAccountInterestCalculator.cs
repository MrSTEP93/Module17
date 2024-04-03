using Module17.Final.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Calculator.Calculator
{
    public class SalaryAccountInterestCalculator : IInterestCalculator
    {
        public double CalculateInterest(double balance)
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            double interest = balance * 0.5;

            return interest;
        }
    }
}
