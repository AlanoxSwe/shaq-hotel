using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaqHotel
{
    public class Hotel
    {
        DBConnect dbCon = new DBConnect();
        Initiate initiate = new Initiate("Shaq HotelSoftware");

        private string hotelName;
        private string country;
        private string city;
        private int rating;
        private List<Customer> customerList = new List<Customer>();
        private List<TravelAgency> travelAgencyList = new List<TravelAgency>();


        public Hotel(string hotelName, string country, string city, int rating)
        {
            this.hotelName = hotelName;
            this.country = country;
            this.city = city;
            this.rating = rating;
        }

        public string HotelName { get { return hotelName; } }
        public string Country { get { return country; } }
        public string City { get { return city; } }
        public int Rating { get { return rating; } }

        public static bool IsSet<T>(T input)
        {
            if(String.IsNullOrEmpty(input.ToString()) || input.ToString().Length <= 0 || input.Equals(" "))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int SingleRoomCount()
        {
            return Room.CountRoom("single");
        }

        public int DoubleRoomCount()
        {
            return Room.CountRoom("double");
        }

        public int SuiteRoomCount()
        {
            return Room.CountRoom("suite");
        }

        public int TotalRoomCount()
        {
            return Room.Count;
        }

        public void ResetForms(Control control)
        {
            foreach (Control ctr in control.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
                else if (ctr is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)ctr;
                    foreach (int checkedItemIndex in clb.CheckedIndices)
                    {
                        clb.SetItemChecked(checkedItemIndex, false);
                    }
                }
                else if (ctr is CheckBox)
                {
                    ((CheckBox)ctr).Checked = false;
                }
                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).SelectedIndex = -1;
                }
            }
        }

        public void OpenDatabase()
        {
            System.Diagnostics.Process.Start("http://"+dbCon.Server+"/"+dbCon.Software);
        }

        public void UpdateHotelInformation(string hotelName, string country, string city, string rating)
        {
            dbCon.Update("UPDATE hotel SET hotelName='" + hotelName + "' WHERE id=1");
            dbCon.Update("UPDATE hotel SET country='" + country + "' WHERE id=1");
            dbCon.Update("UPDATE hotel SET city='" + city + "' WHERE id=1");
            dbCon.Update("UPDATE hotel SET rating='" + rating + "' WHERE id=1");

            this.hotelName = dbCon.SS("hotel", "hotelName", "id", "1");
            this.country = dbCon.SS("hotel", "country", "id", "1");
            this.city = dbCon.SS("hotel", "city", "id", "1");
            this.rating = int.Parse(dbCon.SS("hotel", "rating", "id", "1"));
        }

        public void DeleteHotel()
        {
            dbCon.Update("TRUNCATE hotel; TRUNCATE customer; TRUNCATE room; TRUNCATE travelagency");
            initiate.DeleteKey();
        }

        public void AddTravelAgency(string name, string phone)
        {
            TravelAgency travelAgency = new TravelAgency(name, phone);
            travelAgencyList.Add(travelAgency);
        }

        public int AddCustomer(string firstName, string lastName, string ssn, int travelAgencyID)
        {
            if(!IsSet(firstName) || !IsSet(lastName) || !IsSet(ssn) || !IsSet(travelAgencyID))
            {
                return 2;
            }
            if (ssn.Length != 10)
            {
                return 3;
            }
            List<String>[] SSNList = dbCon.Select("SELECT * FROM customer", "ssn");
            bool SSNExists = false;
            for (int i = 0; i < dbCon.Count("customer", "id"); i++)
            {
                if (ssn.Equals(SSNList[0].ElementAt(i)))
                {
                    SSNExists = true;
                    break;
                }
                else
                {
                    SSNExists = false;
                }
            }
            
            if (SSNExists == true)
            {
                return 0;
            }
            else {
                Customer customer = new Customer(firstName, lastName, ssn, travelAgencyID);
                customerList.Add(customer);
                dbCon.Update("INSERT INTO customer(firstName, lastName, ssn, travelAgencyId) VALUES ('" + firstName + "', '" +
                    lastName + "', '" +
                    ssn + "', '" +
                    travelAgencyID + "');");
                return 1;
            }
        }

        public bool SearchCustomer_viaSSN(string input)
        {
            List<String>[] SSNList = dbCon.Select("SELECT * FROM customer", "ssn");
            bool SSNExists = true;
            for (int i = 0; i < dbCon.Count("customer", "id"); i++)
            {
                if (input.Equals(SSNList[0].ElementAt(i)))
                {
                    SSNExists = true;
                    break;
                }
                else
                {
                    SSNExists = false;
                }
            }
            return SSNExists;
        }
        
    }
}
