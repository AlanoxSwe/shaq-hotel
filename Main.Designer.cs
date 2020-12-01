namespace ShaqHotel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HotelBtnTlp = new System.Windows.Forms.ToolTip(this.components);
            this.ManagementGbx = new System.Windows.Forms.GroupBox();
            this.HotelBtn = new System.Windows.Forms.Button();
            this.TravelAgencyBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.RoomBtn = new System.Windows.Forms.Button();
            this.AvailableRoomsGbx = new System.Windows.Forms.GroupBox();
            this.SuiteRoomsLbl = new System.Windows.Forms.Label();
            this.DoubleRoomsLbl = new System.Windows.Forms.Label();
            this.SingleRoomsLbl = new System.Windows.Forms.Label();
            this.TotalRoomsLbl = new System.Windows.Forms.Label();
            this.CustomerBtnTlp = new System.Windows.Forms.ToolTip(this.components);
            this.RoomBtnTlp = new System.Windows.Forms.ToolTip(this.components);
            this.TravelAgencyBtnTlp = new System.Windows.Forms.ToolTip(this.components);
            this.ValuesGbx = new System.Windows.Forms.GroupBox();
            this.BookedCustomersNoTravelAgencyLbl = new System.Windows.Forms.Label();
            this.BookedRoomsLbl = new System.Windows.Forms.Label();
            this.RegisteredTravelAgenciesLbl = new System.Windows.Forms.Label();
            this.MoreValuesBtn = new System.Windows.Forms.Button();
            this.BookedCustomersLbl = new System.Windows.Forms.Label();
            this.MoreValuesGbx = new System.Windows.Forms.GroupBox();
            this.BookedSuiteLbl = new System.Windows.Forms.Label();
            this.BookedDoubleLbl = new System.Windows.Forms.Label();
            this.BookedSingleLbl = new System.Windows.Forms.Label();
            this.MoreValuesBtnTlp = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CopyrightLbl = new System.Windows.Forms.Label();
            this.DatabaseBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ManagementGbx.SuspendLayout();
            this.AvailableRoomsGbx.SuspendLayout();
            this.ValuesGbx.SuspendLayout();
            this.MoreValuesGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagementGbx
            // 
            this.ManagementGbx.Controls.Add(this.HotelBtn);
            this.ManagementGbx.Controls.Add(this.TravelAgencyBtn);
            this.ManagementGbx.Controls.Add(this.CustomerBtn);
            this.ManagementGbx.Controls.Add(this.RoomBtn);
            this.ManagementGbx.Location = new System.Drawing.Point(529, 55);
            this.ManagementGbx.Margin = new System.Windows.Forms.Padding(4);
            this.ManagementGbx.Name = "ManagementGbx";
            this.ManagementGbx.Padding = new System.Windows.Forms.Padding(4);
            this.ManagementGbx.Size = new System.Drawing.Size(363, 115);
            this.ManagementGbx.TabIndex = 5;
            this.ManagementGbx.TabStop = false;
            this.ManagementGbx.Text = "Hotel Management";
            // 
            // HotelBtn
            // 
            this.HotelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HotelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HotelBtn.Image = global::ShaqHotel.Properties.Resources.hotell1;
            this.HotelBtn.Location = new System.Drawing.Point(18, 22);
            this.HotelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HotelBtn.Name = "HotelBtn";
            this.HotelBtn.Size = new System.Drawing.Size(76, 75);
            this.HotelBtn.TabIndex = 1;
            this.HotelBtn.UseVisualStyleBackColor = true;
            this.HotelBtn.Click += new System.EventHandler(this.HotelBtn_Click);
            this.HotelBtn.MouseHover += new System.EventHandler(this.HotelBtn_MouseHover);
            // 
            // TravelAgencyBtn
            // 
            this.TravelAgencyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TravelAgencyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TravelAgencyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TravelAgencyBtn.Image = global::ShaqHotel.Properties.Resources.travelagency;
            this.TravelAgencyBtn.Location = new System.Drawing.Point(266, 22);
            this.TravelAgencyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TravelAgencyBtn.Name = "TravelAgencyBtn";
            this.TravelAgencyBtn.Size = new System.Drawing.Size(76, 75);
            this.TravelAgencyBtn.TabIndex = 4;
            this.TravelAgencyBtn.UseVisualStyleBackColor = true;
            this.TravelAgencyBtn.MouseHover += new System.EventHandler(this.TravelAgencyBtn_MouseHover);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomerBtn.Image = global::ShaqHotel.Properties.Resources.customer;
            this.CustomerBtn.Location = new System.Drawing.Point(101, 22);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(76, 75);
            this.CustomerBtn.TabIndex = 2;
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            this.CustomerBtn.MouseHover += new System.EventHandler(this.CustomerBtn_MouseHover);
            // 
            // RoomBtn
            // 
            this.RoomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoomBtn.Image = global::ShaqHotel.Properties.Resources.room;
            this.RoomBtn.Location = new System.Drawing.Point(183, 22);
            this.RoomBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RoomBtn.Name = "RoomBtn";
            this.RoomBtn.Size = new System.Drawing.Size(76, 75);
            this.RoomBtn.TabIndex = 3;
            this.RoomBtn.UseVisualStyleBackColor = true;
            this.RoomBtn.Click += new System.EventHandler(this.RoomBtn_Click);
            this.RoomBtn.MouseHover += new System.EventHandler(this.RoomBtn_MouseHover);
            // 
            // AvailableRoomsGbx
            // 
            this.AvailableRoomsGbx.Controls.Add(this.SuiteRoomsLbl);
            this.AvailableRoomsGbx.Controls.Add(this.DoubleRoomsLbl);
            this.AvailableRoomsGbx.Controls.Add(this.SingleRoomsLbl);
            this.AvailableRoomsGbx.Controls.Add(this.TotalRoomsLbl);
            this.AvailableRoomsGbx.Location = new System.Drawing.Point(27, 193);
            this.AvailableRoomsGbx.Margin = new System.Windows.Forms.Padding(4);
            this.AvailableRoomsGbx.Name = "AvailableRoomsGbx";
            this.AvailableRoomsGbx.Padding = new System.Windows.Forms.Padding(4);
            this.AvailableRoomsGbx.Size = new System.Drawing.Size(144, 98);
            this.AvailableRoomsGbx.TabIndex = 6;
            this.AvailableRoomsGbx.TabStop = false;
            this.AvailableRoomsGbx.Text = "Available Rooms";
            // 
            // SuiteRoomsLbl
            // 
            this.SuiteRoomsLbl.AutoSize = true;
            this.SuiteRoomsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuiteRoomsLbl.Location = new System.Drawing.Point(7, 68);
            this.SuiteRoomsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuiteRoomsLbl.Name = "SuiteRoomsLbl";
            this.SuiteRoomsLbl.Size = new System.Drawing.Size(49, 13);
            this.SuiteRoomsLbl.TabIndex = 10;
            this.SuiteRoomsLbl.Text = "Suite: 17";
            // 
            // DoubleRoomsLbl
            // 
            this.DoubleRoomsLbl.AutoSize = true;
            this.DoubleRoomsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleRoomsLbl.Location = new System.Drawing.Point(7, 51);
            this.DoubleRoomsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoubleRoomsLbl.Name = "DoubleRoomsLbl";
            this.DoubleRoomsLbl.Size = new System.Drawing.Size(65, 13);
            this.DoubleRoomsLbl.TabIndex = 9;
            this.DoubleRoomsLbl.Text = "Double: 120";
            // 
            // SingleRoomsLbl
            // 
            this.SingleRoomsLbl.AutoSize = true;
            this.SingleRoomsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleRoomsLbl.Location = new System.Drawing.Point(7, 35);
            this.SingleRoomsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleRoomsLbl.Name = "SingleRoomsLbl";
            this.SingleRoomsLbl.Size = new System.Drawing.Size(60, 13);
            this.SingleRoomsLbl.TabIndex = 8;
            this.SingleRoomsLbl.Text = "Single: 100";
            // 
            // TotalRoomsLbl
            // 
            this.TotalRoomsLbl.AutoSize = true;
            this.TotalRoomsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRoomsLbl.Location = new System.Drawing.Point(7, 19);
            this.TotalRoomsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalRoomsLbl.Name = "TotalRoomsLbl";
            this.TotalRoomsLbl.Size = new System.Drawing.Size(65, 13);
            this.TotalRoomsLbl.TabIndex = 7;
            this.TotalRoomsLbl.Text = "Total: 237";
            // 
            // ValuesGbx
            // 
            this.ValuesGbx.Controls.Add(this.BookedCustomersNoTravelAgencyLbl);
            this.ValuesGbx.Controls.Add(this.BookedRoomsLbl);
            this.ValuesGbx.Controls.Add(this.RegisteredTravelAgenciesLbl);
            this.ValuesGbx.Controls.Add(this.MoreValuesBtn);
            this.ValuesGbx.Controls.Add(this.BookedCustomersLbl);
            this.ValuesGbx.Location = new System.Drawing.Point(178, 193);
            this.ValuesGbx.Margin = new System.Windows.Forms.Padding(4);
            this.ValuesGbx.Name = "ValuesGbx";
            this.ValuesGbx.Padding = new System.Windows.Forms.Padding(4);
            this.ValuesGbx.Size = new System.Drawing.Size(346, 98);
            this.ValuesGbx.TabIndex = 7;
            this.ValuesGbx.TabStop = false;
            this.ValuesGbx.Text = "Values";
            // 
            // BookedCustomersNoTravelAgencyLbl
            // 
            this.BookedCustomersNoTravelAgencyLbl.AutoSize = true;
            this.BookedCustomersNoTravelAgencyLbl.Location = new System.Drawing.Point(7, 51);
            this.BookedCustomersNoTravelAgencyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedCustomersNoTravelAgencyLbl.Name = "BookedCustomersNoTravelAgencyLbl";
            this.BookedCustomersNoTravelAgencyLbl.Size = new System.Drawing.Size(176, 15);
            this.BookedCustomersNoTravelAgencyLbl.TabIndex = 8;
            this.BookedCustomersNoTravelAgencyLbl.Text = "Booked Customers w/o T.A.: 12";
            // 
            // BookedRoomsLbl
            // 
            this.BookedRoomsLbl.AutoSize = true;
            this.BookedRoomsLbl.Location = new System.Drawing.Point(7, 68);
            this.BookedRoomsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedRoomsLbl.Name = "BookedRoomsLbl";
            this.BookedRoomsLbl.Size = new System.Drawing.Size(105, 15);
            this.BookedRoomsLbl.TabIndex = 7;
            this.BookedRoomsLbl.Text = "Booked Rooms: 0";
            // 
            // RegisteredTravelAgenciesLbl
            // 
            this.RegisteredTravelAgenciesLbl.AutoSize = true;
            this.RegisteredTravelAgenciesLbl.Location = new System.Drawing.Point(7, 35);
            this.RegisteredTravelAgenciesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisteredTravelAgenciesLbl.Name = "RegisteredTravelAgenciesLbl";
            this.RegisteredTravelAgenciesLbl.Size = new System.Drawing.Size(169, 15);
            this.RegisteredTravelAgenciesLbl.TabIndex = 6;
            this.RegisteredTravelAgenciesLbl.Text = "Registered Travel Agencies: 7";
            // 
            // MoreValuesBtn
            // 
            this.MoreValuesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoreValuesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreValuesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoreValuesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreValuesBtn.Location = new System.Drawing.Point(242, 51);
            this.MoreValuesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MoreValuesBtn.Name = "MoreValuesBtn";
            this.MoreValuesBtn.Size = new System.Drawing.Size(97, 39);
            this.MoreValuesBtn.TabIndex = 5;
            this.MoreValuesBtn.Text = "···";
            this.MoreValuesBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MoreValuesBtn.UseVisualStyleBackColor = true;
            this.MoreValuesBtn.Click += new System.EventHandler(this.MoreValuesBtn_Click);
            this.MoreValuesBtn.MouseHover += new System.EventHandler(this.MoreValuesBtn_MouseHover);
            // 
            // BookedCustomersLbl
            // 
            this.BookedCustomersLbl.AutoSize = true;
            this.BookedCustomersLbl.Location = new System.Drawing.Point(7, 19);
            this.BookedCustomersLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedCustomersLbl.Name = "BookedCustomersLbl";
            this.BookedCustomersLbl.Size = new System.Drawing.Size(138, 15);
            this.BookedCustomersLbl.TabIndex = 0;
            this.BookedCustomersLbl.Text = "Booked Customers: 120";
            // 
            // MoreValuesGbx
            // 
            this.MoreValuesGbx.Controls.Add(this.BookedSuiteLbl);
            this.MoreValuesGbx.Controls.Add(this.BookedDoubleLbl);
            this.MoreValuesGbx.Controls.Add(this.BookedSingleLbl);
            this.MoreValuesGbx.Location = new System.Drawing.Point(178, 298);
            this.MoreValuesGbx.Margin = new System.Windows.Forms.Padding(4);
            this.MoreValuesGbx.Name = "MoreValuesGbx";
            this.MoreValuesGbx.Padding = new System.Windows.Forms.Padding(4);
            this.MoreValuesGbx.Size = new System.Drawing.Size(346, 86);
            this.MoreValuesGbx.TabIndex = 8;
            this.MoreValuesGbx.TabStop = false;
            this.MoreValuesGbx.Text = "More Values";
            // 
            // BookedSuiteLbl
            // 
            this.BookedSuiteLbl.AutoSize = true;
            this.BookedSuiteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedSuiteLbl.Location = new System.Drawing.Point(7, 52);
            this.BookedSuiteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedSuiteLbl.Name = "BookedSuiteLbl";
            this.BookedSuiteLbl.Size = new System.Drawing.Size(43, 13);
            this.BookedSuiteLbl.TabIndex = 13;
            this.BookedSuiteLbl.Text = "Suite: 0";
            // 
            // BookedDoubleLbl
            // 
            this.BookedDoubleLbl.AutoSize = true;
            this.BookedDoubleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedDoubleLbl.Location = new System.Drawing.Point(7, 35);
            this.BookedDoubleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedDoubleLbl.Name = "BookedDoubleLbl";
            this.BookedDoubleLbl.Size = new System.Drawing.Size(53, 13);
            this.BookedDoubleLbl.TabIndex = 12;
            this.BookedDoubleLbl.Text = "Double: 0";
            // 
            // BookedSingleLbl
            // 
            this.BookedSingleLbl.AutoSize = true;
            this.BookedSingleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedSingleLbl.Location = new System.Drawing.Point(7, 19);
            this.BookedSingleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedSingleLbl.Name = "BookedSingleLbl";
            this.BookedSingleLbl.Size = new System.Drawing.Size(48, 13);
            this.BookedSingleLbl.TabIndex = 11;
            this.BookedSingleLbl.Text = "Single: 0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "test";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CopyrightLbl
            // 
            this.CopyrightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyrightLbl.AutoSize = true;
            this.CopyrightLbl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightLbl.Location = new System.Drawing.Point(24, 748);
            this.CopyrightLbl.Name = "CopyrightLbl";
            this.CopyrightLbl.Size = new System.Drawing.Size(223, 13);
            this.CopyrightLbl.TabIndex = 12;
            this.CopyrightLbl.Text = "© Shaq Enterprises - Alan Hajo, 2018";
            // 
            // DatabaseBtn
            // 
            this.DatabaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DatabaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DatabaseBtn.Location = new System.Drawing.Point(1520, 729);
            this.DatabaseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DatabaseBtn.Name = "DatabaseBtn";
            this.DatabaseBtn.Size = new System.Drawing.Size(143, 43);
            this.DatabaseBtn.TabIndex = 5;
            this.DatabaseBtn.Text = "View Database";
            this.DatabaseBtn.UseVisualStyleBackColor = true;
            this.DatabaseBtn.Click += new System.EventHandler(this.DatabaseBtn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.Control;
            this.Logo.Image = global::ShaqHotel.Properties.Resources.shaqhotel;
            this.Logo.Location = new System.Drawing.Point(27, 31);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(496, 155);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1676, 786);
            this.Controls.Add(this.DatabaseBtn);
            this.Controls.Add(this.CopyrightLbl);
            this.Controls.Add(this.MoreValuesGbx);
            this.Controls.Add(this.ValuesGbx);
            this.Controls.Add(this.AvailableRoomsGbx);
            this.Controls.Add(this.ManagementGbx);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1679, 823);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ManagementGbx.ResumeLayout(false);
            this.AvailableRoomsGbx.ResumeLayout(false);
            this.AvailableRoomsGbx.PerformLayout();
            this.ValuesGbx.ResumeLayout(false);
            this.ValuesGbx.PerformLayout();
            this.MoreValuesGbx.ResumeLayout(false);
            this.MoreValuesGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button HotelBtn;
        private System.Windows.Forms.ToolTip HotelBtnTlp;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Button RoomBtn;
        private System.Windows.Forms.Button TravelAgencyBtn;
        private System.Windows.Forms.GroupBox ManagementGbx;
        private System.Windows.Forms.GroupBox AvailableRoomsGbx;
        private System.Windows.Forms.ToolTip CustomerBtnTlp;
        private System.Windows.Forms.ToolTip RoomBtnTlp;
        private System.Windows.Forms.ToolTip TravelAgencyBtnTlp;
        private System.Windows.Forms.Label TotalRoomsLbl;
        private System.Windows.Forms.Label SuiteRoomsLbl;
        private System.Windows.Forms.Label DoubleRoomsLbl;
        private System.Windows.Forms.Label SingleRoomsLbl;
        private System.Windows.Forms.GroupBox ValuesGbx;
        private System.Windows.Forms.Button MoreValuesBtn;
        private System.Windows.Forms.Label BookedCustomersLbl;
        private System.Windows.Forms.Label BookedCustomersNoTravelAgencyLbl;
        private System.Windows.Forms.Label BookedRoomsLbl;
        private System.Windows.Forms.Label RegisteredTravelAgenciesLbl;
        private System.Windows.Forms.GroupBox MoreValuesGbx;
        private System.Windows.Forms.Label BookedSuiteLbl;
        private System.Windows.Forms.Label BookedDoubleLbl;
        private System.Windows.Forms.Label BookedSingleLbl;
        private System.Windows.Forms.ToolTip MoreValuesBtnTlp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label CopyrightLbl;
        private System.Windows.Forms.Button DatabaseBtn;
    }
}

