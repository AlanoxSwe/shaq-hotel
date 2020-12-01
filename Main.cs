using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ShaqHotel
{
    
    public partial class MainForm : Form
    {
        DBConnect dbCon = new DBConnect();
        Hotel hotel;
        Initiate initiate = new Initiate("Shaq HotelSoftware");
        
        public void CreateHotel()
        {
            hotel = new Hotel(dbCon.SS("hotel", "hotelName", "id", "1"),
            dbCon.SS("hotel", "country", "id", "1"),
            dbCon.SS("hotel", "city", "id", "1"),
            int.Parse(dbCon.SS("hotel", "rating", "id", "1")));
        }

        public MainForm()
        {
            InitializeComponent();

            //Registry key
            if (initiate.KeyExists())
            {
                if (!initiate.Initiated())
                {
                    initiate.SetKey(true);
                }
            }
            else
            {
                HotelInitiate hotelInitiate = new HotelInitiate();
                hotelInitiate.ShowDialog();
            }

            CreateHotel();
            //Pre-defined properties:
            MoreValuesGbx.Visible = false;
            BackgroundImage = null;
            Text = hotel.HotelName;
            //dbCon.Update("INSERT INTO travelagency(name, phone) VALUES('test', '100')");
            //List<String>[] allTravelAngencies = dbCon.Select("SELECT * FROM travelagency", "id", "name");
            //MessageBox.Show(dbCon.StringOut(allTravelAngencies, 1));
        }

        private void HotelBtn_Click(object sender, EventArgs e)
        {
            HotelInformation hotelInformation = new HotelInformation(hotel);
            hotelInformation.ShowDialog();
        }

        private void HotelBtn_MouseHover(object sender, EventArgs e)
        {
            HotelBtnTlp.Show("Hotel Information", HotelBtn);
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerInformation customerInformation = new CustomerInformation(hotel);
            customerInformation.ShowDialog();
        }

        private void CustomerBtn_MouseHover(object sender, EventArgs e)
        {
            CustomerBtnTlp.Show("Customers", CustomerBtn);
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            RoomInformation roomInformation = new RoomInformation(hotel);
            roomInformation.ShowDialog();
        }

        private void RoomBtn_MouseHover(object sender, EventArgs e)
        {
            RoomBtnTlp.Show("Rooms", RoomBtn);
        }

        private void TravelAgencyBtn_MouseHover(object sender, EventArgs e)
        {
            TravelAgencyBtnTlp.Show("Travel Agencies", TravelAgencyBtn);
        }

        private void MoreValuesBtn_Click(object sender, EventArgs e)
        {
            MoreValuesGbx.Visible = !MoreValuesGbx.Visible;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            BackgroundImage = (BackgroundImage == null) ? Properties.Resources.carpet1 : null;
        }

        private void MoreValuesBtn_MouseHover(object sender, EventArgs e)
        {
            MoreValuesBtnTlp.Show("More Info", MoreValuesBtn);
        }

        private void DatabaseBtn_Click(object sender, EventArgs e)
        {
            hotel.OpenDatabase();
        }
    }
}