using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Accounts
{
    public class SalaryAccount : IAccountType
    {
        public static readonly string TypeName = "Зарплатынй";

        public static double CalculateInterest(double balance)
        {
            double interest = 1.03;

            // расчет процентной ставки зарплатного аккаунта по правилам банка
            interest = balance * 0.5;

            return interest;
        }
    }
}
