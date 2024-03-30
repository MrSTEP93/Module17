using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Accounts
{
    public class CommonAccount : IAccountType
    {
        public readonly string TypeName = "Обычный";

        public double CalculateInterest(double balance)
        {
            double interest = 1.02;

            // расчет процентной ставки обычного аккаунта по правилам банка
            interest = balance * 0.4;

            if (balance < 1000)
                interest -= balance * 0.2;

            if (balance >= 1000)
                interest -= balance * 0.4;

            return interest;
        }
    }
}
