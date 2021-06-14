using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06_BookshopDLL
{
    public class Address
    {
        private static uint ID = 1;

        public Address(string Postcode, string TownName, string Street)
        {
            this.Id = Address.ID;
            this.Postcode = Postcode;
            this.TownName = TownName;
            this.Street = Street;

            Address.ID++;
        }

        public uint Id { get; private set; }

        private string postcode;
        public string Postcode
        {
            set
            {
                //string regex2 = "[1000-9999]";
                string regex = @"[1-9]{1}[0-9]{3}";                
                if (Regex.IsMatch(value, regex))
                    postcode = value;
                else throw new Exception("Invalid postcode!");
            }
            get
            {
                return postcode;
            }
        }

        public string TownName { get; set; }        
        public string Street { get; set; }
    }
}
