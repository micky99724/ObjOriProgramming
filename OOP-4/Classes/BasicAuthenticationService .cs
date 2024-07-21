using OOP_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                return true ;
            return false ;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if(!string.IsNullOrEmpty(role))
                return true;
            return false;
        }
    }
}
