using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class Employee : User
    {
        public Employee(string FirstName, string LastName, string Email,
            string Password) 
            : base(FirstName, LastName, Email, Password, 
            Company.GetRole(RoleEnum.EMPLOYEE))
        {

        }
    }
}
