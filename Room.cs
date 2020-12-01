using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaqHotel
{
    class Room
    {
        static DBConnect dbCon = new DBConnect();
        private int number;
        private int area;
        private bool balcony;
        private int customerID;
        private static int count;

        public Room(int number, int area, bool balcony, int customerID)
        {
            this.number = number;
            this.area = area;
            this.balcony = balcony;
            this.customerID = customerID;
            count++;
        }

        public int Number { get { return number; } }
        public int Area { get { return area; } }
        public bool Balcony { get { return balcony; } }
        public int CustomerID { get { return customerID; } }
        public static int Count { get { return count; } }

        public static int CountRoom(string type)
        {
            if (type.Equals("single"))
            {
                return int.Parse(dbCon.SS("roomcount", "count", "id", "1"));
            }
            else if (type.Equals("double"))
            {
                return int.Parse(dbCon.SS("roomcount", "count", "id", "2"));
            }
            else if (type.Equals("suite"))
            {
                return int.Parse(dbCon.SS("roomcount", "count", "id", "3"));
            }
            else
            {
                return 0;
            }
        }
    }
}
