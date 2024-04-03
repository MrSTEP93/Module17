using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Final.Accounts
{

    public enum AccountTypes { 
        Common, 
        Salary 
    };

    public class Account
    {
        // тип учетной записи
        public AccountTypes Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account() { }
    }
}
