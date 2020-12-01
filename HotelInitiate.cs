using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaqHotel
{
    public partial class HotelInitiate : Form
    {
        DBConnect dbCon = new DBConnect();
        Initiate initiate = new Initiate("Shaq HotelSoftware");

        public HotelInitiate()
        {
            InitializeComponent();
        }

        private void HotelInformation_Load(object sender, EventArgs e)
        {
            string str = dbCon.SS("hotel", "id", "id", "1");
            if (str != null && str.Equals("1"))
            {
                MessageBox.Show("Hotel already exists! Starting hotel panel...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                initiate.CreateKey();
                this.Close();
            }
        }

        private void Hotel_SaveBtn_Click(object sender, EventArgs e)
        {
            if (!Hotel.IsSet(Init_HotelNameTbx.Text) || !Hotel.IsSet(Init_CountryTbx.Text) || !Hotel.IsSet(Init_CityTbx.Text) || !Hotel.IsSet(Init_RatingLbx.Text))
            {
                MessageBox.Show("Please fill in all forms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbCon.Update("INSERT INTO hotel(id, hotelName, country, city, rating) VALUES ('1', '" + Init_HotelNameTbx.Text + "', '" +
                    Init_CountryTbx.Text + "', '" +
                    Init_CityTbx.Text + "', '" +
                    Init_RatingLbx.Text + "');");
                MessageBox.Show("Your changes have been saved to the database. Welcome to " + Init_HotelNameTbx.Text + "!", "Saved changes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initiate.CreateKey();
                this.Close();
            }
            
        }

        private void Init_CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
