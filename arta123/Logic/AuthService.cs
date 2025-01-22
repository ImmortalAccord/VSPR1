﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arta123.Model;

namespace arta123.Logic
{
    public class AuthService
    {
        private List<User> _users;
        public AuthService()
        {
            _users = new List<User>
            {
                new User("Login", "Pass"),
                new User("Login1", "Pass1"),
                new User("Login", "Pass"),
            };

        }


        public bool CheckData(string login, string pass)
        {
            var user = _users.FirstOrDefault(u => u.Login == login && u.Pass == pass);

            if (user != null && user.Pass == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


   
    }

  
}       

