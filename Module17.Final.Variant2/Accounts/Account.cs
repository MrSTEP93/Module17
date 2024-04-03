using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Variant2.Accounts
{
    public abstract class Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public abstract void CalculateInterest();
    }
}
