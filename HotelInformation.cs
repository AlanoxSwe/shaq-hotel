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
    public partial class HotelInformation : Form
    {
        private Hotel hotel;
        DBConnect dbCon = new DBConnect();

        public HotelInformation(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void FetchData()
        {
            Hotel_HotelNameTbx.Text = hotel.HotelName;
            Hotel_CountryTbx.Text = hotel.Country;
            Hotel_CityTbx.Text = hotel.City;
            Hotel_RatingLbx.SelectedIndex = hotel.Rating-1;
        }

        private void Hotel_GenericGbx_Enter(object sender, EventArgs e)
        {

        }

        private void HotelInformation_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void Hotel_FetchBtn_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void Hotel_SaveGenericBtn_Click(object sender, EventArgs e)
        {
            hotel.UpdateHotelInformation(Hotel_HotelNameTbx.Text, Hotel_CountryTbx.Text, Hotel_CityTbx.Text, Hotel_RatingLbx.Text);
            MessageBox.Show("Your changes have been saved to the database. This form will now close.", "Saved changes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Hotel_ConfirmDeleteCbx_CheckedChanged(object sender, EventArgs e)
        {
            Hotel_DeleteHotelBtn.Enabled = !Hotel_DeleteHotelBtn.Enabled;
            if (Hotel_ConfirmDeleteCbx.Checked)
            {
                MessageBox.Show("This will delete EVERYTHING.\nClick OK to proceed.", "Are you sure?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Hotel_DeleteHotelBtn_Click(object sender, EventArgs e)
        {
            hotel.DeleteHotel();
            MessageBox.Show("Hotel has been deleted. This program will now reset.", "Saved changes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void Hotel_RatingLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
