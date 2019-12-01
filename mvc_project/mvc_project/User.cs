using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class User : Element
    {
        private string name;
        private string email;
        private PurchaseCollection collection;
        private double balance;

        public User()
        {
        }

        public User(string name, string email, double balance)
        {
            this.name = name;
            this.email = email;
            this.balance = balance;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public PurchaseCollection Purchases
        {
            set
            {
                collection = value;
            }
        }

        public void getAllActivePurchases()
        {
            PurchaseIterator iterator = collection.CreateIterator();

            Console.WriteLine("Active purchases of user " + name + "\n");

            for (Purchase item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                item.getInfo();
            }
        }

        public void sendMessage(string message)
        {
            ChatRoom.showMessage(this, message);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
