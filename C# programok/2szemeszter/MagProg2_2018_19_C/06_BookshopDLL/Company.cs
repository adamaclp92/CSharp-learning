using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class Company
    {
        private static List<Role> Roles = new List<Role>()
        {
            new Role("Administrator", true, true, true),
            new Role("User", false, false, false),
            new Role("Employee", true, false, true),
            new Role("Supervisor", true, true, true)
        };

        public static Role GetRole(RoleEnum Role)
        {
            switch (Role)
            {
                case RoleEnum.ADMIN: return Roles[0];
                case RoleEnum.USER: return Roles[1];
                case RoleEnum.EMPLOYEE: return Roles[2];
                case RoleEnum.SUPERVISOR: return Roles[3];
                default: throw new Exception("...");
            }
        }
    }
}
