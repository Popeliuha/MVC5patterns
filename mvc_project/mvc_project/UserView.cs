using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    class UserView
    {
        public void printUserDetails(string name, string email, double balance)
        {
            Console.WriteLine("User Info");
            Console.WriteLine("  Name: " + name);
            Console.WriteLine("  Email: " + email);
            Console.WriteLine("  Balance: " + balance + "\n");
        }
    }
}
