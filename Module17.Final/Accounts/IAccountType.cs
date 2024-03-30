using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Accounts
{
    public interface IAccountType
    {
        public static double CalculateInterest(double balance) 
        { 
            return balance * 1.01;
        }
    }
}
