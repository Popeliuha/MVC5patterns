using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    class UserCollection
    {
        private List<User> _users = new List<User>();

        public void Attach(User user)
        {
            _users.Add(user);
        }

        public void Detach(User user)
        {
            _users.Remove(user);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (User e in _users)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
