using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaqHotel
{
    public partial class RoomInformation : Form
    {
        private Hotel hotel;
        DBConnect dbCon = new DBConnect();

        public RoomInformation(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void FetchData()
        {
            Room_Count_SingleTbx.Text = hotel.SingleRoomCount().ToString();
            /*Room_Count_DoubleTbx.Text = hotel.RoomDoubleCount;
            Room_Count_SuiteTbx.Text = hotel.RoomSuiteCount;
            Room_Count_TotalTbx.Text = hotel.RoomTotalCount;*/
        }

        private void RoomInformation_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
