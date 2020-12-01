using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaqHotel
{
    public class TravelAgency
    {
        private string name;
        private string phone;

        public TravelAgency(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string Name { get { return name; } }
        public string Phone { get { return phone; } }
    }
}
