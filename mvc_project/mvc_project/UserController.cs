using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    class UserController
    {
        private User model;
        private UserView view;

        public UserController(User model, UserView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setUserName(string name)
        {
            model.Name = name;
        }

        public string getUserName()
        {
            return model.Name;
        }

        public void setUserEmail(string email)
        {
            model.Email = email;
        }

        public String getUserEmail()
        {
            return model.Email;
        }

        public void updateView()
        {
            view.printUserDetails(model.Name, model.Email, model.Balance);
        }
    }
}
