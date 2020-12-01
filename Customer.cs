using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaqHotel
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private string ssn;
        private int travelAgencyID;
        static int count;

        public Customer(string firstName, string lastName, string ssn, int travelAgencyID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.travelAgencyID = travelAgencyID;
            count++;
        }

        public string FirstName { get { return firstName; } }
        public string Name { get { return firstName + lastName; } }
        public string SSN { get { return ssn; } }
        public int TravelAgencyID { get { return travelAgencyID; } }
    }
}
