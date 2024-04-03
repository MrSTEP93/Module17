using Module17.Final.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Calculator.Calculator
{
    public interface IInterestCalculator
    {
        public double CalculateInterest(Account acc);
    }
}
