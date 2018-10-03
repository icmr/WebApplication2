using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class UserService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }

            return true;
        }

        public string GetUserById(int id)
        {
            return "user lee";
        }
    }
}
