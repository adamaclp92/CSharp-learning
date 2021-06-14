using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class Role
    {
        private static byte ID = 1;

        private Role(string Name)
        {
            this.Id = Role.ID;            
            this.Name = Name;

            Role.ID++;
        }
        public Role(string Name, 
            bool CanAddUser, bool CanRemoveUser, bool CanAddBook)
            :this(Name)
        {
            this.CanAddBook = CanAddBook;
            this.CanAddUser = CanAddUser;
            this.CanRemoveUser = CanRemoveUser;
        }

        public byte Id { get; private set; }
        public string Name { get; private set; }

        public bool CanAddUser { get; set; }
        public bool CanRemoveUser { get; set; }        
        public bool CanAddBook { get; set; }
    }
}
