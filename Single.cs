using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaqHotel
{
    class Single : Room
    {
        private int number;
        private int area;
        private bool balcony;
        private int customerID;
        private static int count;

        public Single(int number, int area, bool balcony, int customerID) :base(number, area, balcony, customerID)
        {
            this.number = number;
            this.area = area;
            this.balcony = balcony;
            this.customerID = customerID;
            count++;
        }
    }
}
