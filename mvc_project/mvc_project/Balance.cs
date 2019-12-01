using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class Balance
    {
        private static Balance instance;
        public double amount;

        private Balance(double amount)
        {
            this.amount = amount;
        }

        public static Balance getInstance(double amount)
        {
            if (instance == null)
            {
                instance = new Balance(amount);
            }
            return instance;
        }

        public double Amount
        {
            get
            {
                return amount;
            }
        }
    }
}
