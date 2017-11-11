using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private decimal balance;

        public Account(decimal InitialBalance)
        {
            Balance = InitialBalance;
        }

        public void Credit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value >=0)
                {
                    balance = value;
                }
            }
        }
    }
}

