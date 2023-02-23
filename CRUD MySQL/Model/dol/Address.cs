using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    class Address
    {
        public Address() { }

        public string getFullAddress()
        {
            return country + ", " + city + ", " + municipality + ", " + neighborhood + ", " + exactAddress;
         }

        //Address
        private string country;
        private string city;
        private string municipality;
        private string neighborhood;
        private string exactAddress;

        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Municipality { get => municipality; set => municipality = value; }
        public string Neighborhood { get => neighborhood; set => neighborhood = value; }
        public string ExactAddress { get => exactAddress; set => exactAddress = value; }
    }
}
