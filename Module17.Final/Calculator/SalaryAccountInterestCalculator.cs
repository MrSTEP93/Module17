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
        public double CalculateInterest(Account acc)
        {
            if (acc.Type != AccountTypes.Salary)
            {
                throw new ArgumentException("Недопустимый тип аккаунта");
            }

            // расчет процентной ставки зарплатного аккаунта по правилам банка
            double interest = acc.Balance * 0.5;

            return interest;
        }
    }
}
