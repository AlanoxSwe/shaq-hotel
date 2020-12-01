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
    public partial class CustomerInformation : Form
    {
        private Hotel hotel;
        DBConnect dbCon = new DBConnect();

        public CustomerInformation(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            //Retrieve all travel agencies from database
            List<String>[] allTravelAngencies = dbCon.Select("SELECT * FROM travelagency", "id", "name");
            for (int i = 0; i < allTravelAngencies[1].Count; i++)
            {
                Customer_TALbx.Items.Add(allTravelAngencies[1].ElementAt(i));
            }
            
        }

        private void Customer_CheckInBtn_Click(object sender, EventArgs e)
        {
            int code = hotel.AddCustomer(Customer_FirstNameTbx.Text.ToUpper(), Customer_LastNameTbx.Text.ToUpper(), Customer_SSNTbx.Text, 1);
            if (code == 1)
            {
                MessageBox.Show("Your changes have been saved to the database.", "Saved changes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hotel.ResetForms(Customer_CheckInGbx);
            }
            else if (code == 2) //SSN too short
            {
                MessageBox.Show("Please fill in all forms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(code == 3)
            {
                MessageBox.Show("SSN must be in the following format:\nYYMMDDXXXX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Already exists, error code = 0
            {
                MessageBox.Show("SSN already exists in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Customer_ResetBtn_Click(object sender, EventArgs e)
        {
            hotel.ResetForms(Customer_CheckInGbx);
        }

        private void Customer_SearchSSN_SearchBtn_Click(object sender, EventArgs e)
        {
            
            if(hotel.SearchCustomer_viaSSN(Customer_SearchSSN_SearchTbx.Text) == false)
            {
                MessageBox.Show("No customer found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer_SearchSSN_ResTbx.Text = "";
                List<String>[] searchSSN = dbCon.Select("SELECT * FROM customer WHERE ssn="+Customer_SearchSSN_SearchTbx.Text, "id", "firstName", "lastName" , "ssn", "travelAgencyId");
                Customer_SearchSSN_ResTbx.AppendText(searchSSN[1].ElementAt(0) + " " + searchSSN[2].ElementAt(0)+"\n");
                Customer_SearchSSN_ResTbx.AppendText("\nID: " + searchSSN[0].ElementAt(0)+"\n");
                Customer_SearchSSN_ResTbx.AppendText("Travel Agency: " + searchSSN[4].ElementAt(0));
            }

            
        }

        private void Customer_SearchSSN_ResetBtn_Click(object sender, EventArgs e)
        {
            hotel.ResetForms(Customer_SearchSSNGbx);
        }

        private void Customer_SearchID_SearchBtn_Click(object sender, EventArgs e)
        {
            List<String>[] IDList = dbCon.Select("SELECT * FROM customer", "id");
            bool IDExists = true;

            for (int i = 0; i < dbCon.Count("customer", "id"); i++)
            {
                if (Customer_SearchID_SearchTbx.Text.Equals(IDList[0].ElementAt(i)))
                {
                    IDExists = true;
                    break;
                }
                else
                {
                    IDExists = false;
                }
            }

            if (IDExists == false)
            {
                MessageBox.Show("No customer with ID "+ Customer_SearchID_SearchTbx.Text +" found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer_SearchID_ResTbx.Text = "";
                string ress = dbCon.SS("customer", "ssn", "id", Customer_SearchID_SearchTbx.Text);
                Customer_SearchID_ResTbx.Text = ress;
            }
        }

        private void Customer_SearchID_ResTbx_TextChanged(object sender, EventArgs e)
        {
            if (!Customer_SearchID_ResTbx.Text.Equals(""))
            {
                Customer_SearchID_CopyBtn.Enabled = true;
            }
            else
            {
                Customer_SearchID_CopyBtn.Enabled = false;
            }
        }

        private void Customer_SearchID_CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Customer_SearchID_ResTbx.Text);
        }

        private void Customer_SearchID_ResetBtn_Click(object sender, EventArgs e)
        {
            hotel.ResetForms(Customer_SearchIDGbx);
        }

        private void Customer_SearchName_SearchBtn_Click(object sender, EventArgs e)
        {
            List<String>[] NameList = dbCon.Select("SELECT * FROM customer WHERE firstName = '"+Customer_SearchName_SearchTbx.Text+"'", "ssn", "lastName");
            if (NameList[0].Count == 0)
            {
                MessageBox.Show("No customer with First Name " + Customer_SearchName_SearchTbx.Text + " found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer_SearchName_ResLbx.Items.Clear();
                for (int i = 0; i < NameList[0].Count; i++)
                {
                    Customer_SearchName_ResLbx.Items.Add(NameList[0].ElementAt(i) + ", " + NameList[1].ElementAt(i));
                }
                Customer_SearchName_ResLbx.SelectedIndex = 0;
            }
        }

        private void Customer_SearchName_ResLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Customer_SearchName_ResLbx.SelectedIndex != -1)
            {
                Customer_SearchName_CopyBtn.Enabled = true;
            }
            else
            {
                Customer_SearchName_CopyBtn.Enabled = false;
            }
        }

        private void Customer_SearchName_CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Customer_SearchName_ResLbx.Text.Substring(0, 10));
        }

        private void Customer_SearchName_ResetBtn_Click(object sender, EventArgs e)
        {
            hotel.ResetForms(Customer_SearchNameGbx);
            Customer_SearchName_ResLbx.Items.Clear();
        }

        private void Customer_Delete_DeleteBtn_Click(object sender, EventArgs e)
        {
            List<String>[] DeletingList = dbCon.Select("SELECT id FROM customer WHERE ssn = '" + Customer_Delete_SSNTbx.Text + "'", "id");
            if(DeletingList[0].Count != 0)
            {
                dbCon.Update("DELETE FROM customer WHERE ssn = '" + Customer_Delete_SSNTbx.Text + "'");
                MessageBox.Show("Your changes have been saved to the database.", "Saved changes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hotel.ResetForms(Customer_DeleteGbx);
            }
            else
            {
                MessageBox.Show("No customer found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Customer_DeleteAll_ConfirmCbx_CheckedChanged(object sender, EventArgs e)
        {
            Customer_DeleteAll_DeleteBtn.Enabled = !Customer_DeleteAll_DeleteBtn.Enabled;
            if (Customer_DeleteAll_ConfirmCbx.Checked)
            {
                MessageBox.Show("This will delete ALL CUSTOMERS.\nClick OK to proceed.", "Are you sure?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Customer_DeleteAll_DeleteBtn_Click(object sender, EventArgs e)
        {
            dbCon.Update("TRUNCATE TABLE customer");
            MessageBox.Show("All customers have been deleted. This form will now close.", "Saved changes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Customer_ListAll_FetchBtn_Click(object sender, EventArgs e)
        {
            hotel.ResetForms(Customer_ListAllGbx);
            Customer_ListAll_CountLbl.Text = "Customer Count:";
            List<String>[] CustomerList = dbCon.Select("SELECT * FROM customer", "id", "firstName", "lastName", "ssn", "travelAgencyId");
            if (CustomerList[0].Count != 0)
            {
                Customer_ListAll_CountLbl.Text = "Customer Count: " + CustomerList[0].Count;
                for (int i = 0; i < CustomerList[0].Count; i++)
                {
                    Customer_ListAll_ResTbx.AppendText(CustomerList[0].ElementAt(i) + "\t" +
                        CustomerList[1].ElementAt(i) + "\t" +
                        CustomerList[2].ElementAt(i) + "\t" +
                        CustomerList[3].ElementAt(i) + "\n");
                }
            }
            else
            {
                MessageBox.Show("No customers found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customer_ListAll_ResetBtn_Click(object sender, EventArgs e)
        {
            hotel.ResetForms(Customer_ListAllGbx);
            Customer_ListAll_CountLbl.Text = "Customer Count:";
        }
    }
}
