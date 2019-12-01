using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class Purchase
    {
        private String kind;
        private String name;
        private String worker;
        private DateTime date_of_purchase;
        private int cash;
        private HashSet<Purchase> parents;

        public class Builder
        {
            private Purchase newPurchase;

            public Builder()
            {
                newPurchase = new Purchase();
            }

            public Builder withKind(String kind)
            {
                newPurchase.kind = kind;
                return this;
            }

            public Builder withName(String name)
            {
                newPurchase.name = name;
                return this;
            }

            public Builder withTeam(String team)
            {
                newPurchase.worker = team;
                return this;
            }

            public Builder withDate(DateTime date_of_bet)
            {
                newPurchase.date_of_purchase = date_of_bet;
                return this;
            }

            public Builder withAmount(int cash)
            {
                newPurchase.cash = cash;
                return this;
            }

            public Builder withParents(HashSet<Purchase> parents)
            {
                newPurchase.parents = parents;
                return this;
            }

            public Purchase build()
            {
                return newPurchase;
            }
        }

        public void getInfo()
        {
            Console.WriteLine("\nPurchase Info\n" + "Kind of purchase: " + kind + ",\n"
                    + "Name of purchase: " + name + ",\n" + "Worker: " + worker + ",\n"
                    + "Date of purchase: " + date_of_purchase + ",\n" + "Price: " + cash + ".\n");
        }
    }
}
