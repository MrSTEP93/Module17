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
        public double CalculateInterest(Account acc)
        {
            if (acc.Type != AccountTypes.Common)
            {
                throw new ArgumentException("Недопустимый тип аккаунта");
            }

            // расчет процентной ставки обычного аккаунта по правилам банка
            double interest = acc.Balance * 0.4;

            if (acc.Balance  < 1000)
                interest -= acc.Balance * 0.2;

            if (acc.Balance >= 1000)
                interest -= acc.Balance * 0.1;

            return interest;
        }
    }
}
