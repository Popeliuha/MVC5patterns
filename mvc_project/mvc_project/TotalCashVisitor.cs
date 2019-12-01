using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    class TotalCashVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            User user = element as User;

            user.Balance *= 1.09;
            Console.WriteLine("{0} {1}'s new balance: {2}", user.GetType().Name, user.Name, user.Balance);
        }
    }
}
