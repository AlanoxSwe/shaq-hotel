namespace ShaqHotel
{
    partial class HotelInformation
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
            this.Hotel_HotelNameTbx = new System.Windows.Forms.TextBox();
            this.Hotel_HotelNameLbl = new System.Windows.Forms.Label();
            this.Hotel_GenericGbx = new System.Windows.Forms.GroupBox();
            this.Hotel_FetchBtn = new System.Windows.Forms.Button();
            this.Hotel_SaveGenericBtn = new System.Windows.Forms.Button();
            this.Hotel_RatingLbx = new System.Windows.Forms.ComboBox();
            this.Hotel_RatingLbl = new System.Windows.Forms.Label();
            this.Hotel_CityTbx = new System.Windows.Forms.TextBox();
            this.Hotel_CityLbl = new System.Windows.Forms.Label();
            this.Hotel_CountryTbx = new System.Windows.Forms.TextBox();
            this.Hotel_CountryLbl = new System.Windows.Forms.Label();
            this.Hotel_DeleteHotelGbx = new System.Windows.Forms.GroupBox();
            this.Hotel_ConfirmDeleteCbx = new System.Windows.Forms.CheckBox();
            this.Hotel_DeleteHotelBtn = new System.Windows.Forms.Button();
            this.Hotel_WarningLbl = new System.Windows.Forms.Label();
            this.Hotel_GenericGbx.SuspendLayout();
            this.Hotel_DeleteHotelGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hotel_HotelNameTbx
            // 
            this.Hotel_HotelNameTbx.Location = new System.Drawing.Point(70, 21);
            this.Hotel_HotelNameTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_HotelNameTbx.Name = "Hotel_HotelNameTbx";
            this.Hotel_HotelNameTbx.Size = new System.Drawing.Size(173, 20);
            this.Hotel_HotelNameTbx.TabIndex = 0;
            // 
            // Hotel_HotelNameLbl
            // 
            this.Hotel_HotelNameLbl.AutoSize = true;
            this.Hotel_HotelNameLbl.Location = new System.Drawing.Point(4, 24);
            this.Hotel_HotelNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hotel_HotelNameLbl.Name = "Hotel_HotelNameLbl";
            this.Hotel_HotelNameLbl.Size = new System.Drawing.Size(63, 13);
            this.Hotel_HotelNameLbl.TabIndex = 1;
            this.Hotel_HotelNameLbl.Text = "Hotel Name";
            // 
            // Hotel_GenericGbx
            // 
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_FetchBtn);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_SaveGenericBtn);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_RatingLbx);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_RatingLbl);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_CityTbx);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_CityLbl);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_CountryTbx);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_CountryLbl);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_HotelNameTbx);
            this.Hotel_GenericGbx.Controls.Add(this.Hotel_HotelNameLbl);
            this.Hotel_GenericGbx.Location = new System.Drawing.Point(9, 10);
            this.Hotel_GenericGbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_GenericGbx.Name = "Hotel_GenericGbx";
            this.Hotel_GenericGbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_GenericGbx.Size = new System.Drawing.Size(252, 184);
            this.Hotel_GenericGbx.TabIndex = 2;
            this.Hotel_GenericGbx.TabStop = false;
            this.Hotel_GenericGbx.Text = "Generic";
            this.Hotel_GenericGbx.Enter += new System.EventHandler(this.Hotel_GenericGbx_Enter);
            // 
            // Hotel_FetchBtn
            // 
            this.Hotel_FetchBtn.Location = new System.Drawing.Point(7, 152);
            this.Hotel_FetchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_FetchBtn.Name = "Hotel_FetchBtn";
            this.Hotel_FetchBtn.Size = new System.Drawing.Size(85, 28);
            this.Hotel_FetchBtn.TabIndex = 8;
            this.Hotel_FetchBtn.Text = "Fetch from DB";
            this.Hotel_FetchBtn.UseVisualStyleBackColor = true;
            this.Hotel_FetchBtn.Click += new System.EventHandler(this.Hotel_FetchBtn_Click);
            // 
            // Hotel_SaveGenericBtn
            // 
            this.Hotel_SaveGenericBtn.Location = new System.Drawing.Point(116, 152);
            this.Hotel_SaveGenericBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_SaveGenericBtn.Name = "Hotel_SaveGenericBtn";
            this.Hotel_SaveGenericBtn.Size = new System.Drawing.Size(127, 28);
            this.Hotel_SaveGenericBtn.TabIndex = 3;
            this.Hotel_SaveGenericBtn.Text = "Save Changes";
            this.Hotel_SaveGenericBtn.UseVisualStyleBackColor = true;
            this.Hotel_SaveGenericBtn.Click += new System.EventHandler(this.Hotel_SaveGenericBtn_Click);
            // 
            // Hotel_RatingLbx
            // 
            this.Hotel_RatingLbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hotel_RatingLbx.FormattingEnabled = true;
            this.Hotel_RatingLbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Hotel_RatingLbx.Location = new System.Drawing.Point(70, 92);
            this.Hotel_RatingLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_RatingLbx.Name = "Hotel_RatingLbx";
            this.Hotel_RatingLbx.Size = new System.Drawing.Size(173, 21);
            this.Hotel_RatingLbx.TabIndex = 3;
            // 
            // Hotel_RatingLbl
            // 
            this.Hotel_RatingLbl.AutoSize = true;
            this.Hotel_RatingLbl.Location = new System.Drawing.Point(4, 92);
            this.Hotel_RatingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hotel_RatingLbl.Name = "Hotel_RatingLbl";
            this.Hotel_RatingLbl.Size = new System.Drawing.Size(38, 13);
            this.Hotel_RatingLbl.TabIndex = 7;
            this.Hotel_RatingLbl.Text = "Rating";
            this.Hotel_RatingLbl.Click += new System.EventHandler(this.Hotel_RatingLbl_Click);
            // 
            // Hotel_CityTbx
            // 
            this.Hotel_CityTbx.Location = new System.Drawing.Point(70, 67);
            this.Hotel_CityTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_CityTbx.Name = "Hotel_CityTbx";
            this.Hotel_CityTbx.Size = new System.Drawing.Size(173, 20);
            this.Hotel_CityTbx.TabIndex = 4;
            // 
            // Hotel_CityLbl
            // 
            this.Hotel_CityLbl.AutoSize = true;
            this.Hotel_CityLbl.Location = new System.Drawing.Point(4, 69);
            this.Hotel_CityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hotel_CityLbl.Name = "Hotel_CityLbl";
            this.Hotel_CityLbl.Size = new System.Drawing.Size(24, 13);
            this.Hotel_CityLbl.TabIndex = 5;
            this.Hotel_CityLbl.Text = "City";
            // 
            // Hotel_CountryTbx
            // 
            this.Hotel_CountryTbx.Location = new System.Drawing.Point(70, 44);
            this.Hotel_CountryTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_CountryTbx.Name = "Hotel_CountryTbx";
            this.Hotel_CountryTbx.Size = new System.Drawing.Size(173, 20);
            this.Hotel_CountryTbx.TabIndex = 2;
            // 
            // Hotel_CountryLbl
            // 
            this.Hotel_CountryLbl.AutoSize = true;
            this.Hotel_CountryLbl.Location = new System.Drawing.Point(4, 46);
            this.Hotel_CountryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hotel_CountryLbl.Name = "Hotel_CountryLbl";
            this.Hotel_CountryLbl.Size = new System.Drawing.Size(43, 13);
            this.Hotel_CountryLbl.TabIndex = 3;
            this.Hotel_CountryLbl.Text = "Country";
            // 
            // Hotel_DeleteHotelGbx
            // 
            this.Hotel_DeleteHotelGbx.Controls.Add(this.Hotel_ConfirmDeleteCbx);
            this.Hotel_DeleteHotelGbx.Controls.Add(this.Hotel_DeleteHotelBtn);
            this.Hotel_DeleteHotelGbx.Controls.Add(this.Hotel_WarningLbl);
            this.Hotel_DeleteHotelGbx.Location = new System.Drawing.Point(273, 10);
            this.Hotel_DeleteHotelGbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_DeleteHotelGbx.Name = "Hotel_DeleteHotelGbx";
            this.Hotel_DeleteHotelGbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_DeleteHotelGbx.Size = new System.Drawing.Size(252, 184);
            this.Hotel_DeleteHotelGbx.TabIndex = 9;
            this.Hotel_DeleteHotelGbx.TabStop = false;
            this.Hotel_DeleteHotelGbx.Text = "Delete";
            // 
            // Hotel_ConfirmDeleteCbx
            // 
            this.Hotel_ConfirmDeleteCbx.Location = new System.Drawing.Point(7, 101);
            this.Hotel_ConfirmDeleteCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_ConfirmDeleteCbx.Name = "Hotel_ConfirmDeleteCbx";
            this.Hotel_ConfirmDeleteCbx.Size = new System.Drawing.Size(236, 39);
            this.Hotel_ConfirmDeleteCbx.TabIndex = 4;
            this.Hotel_ConfirmDeleteCbx.Text = "I know what I\'m doing and I want to delete all hotel information";
            this.Hotel_ConfirmDeleteCbx.UseVisualStyleBackColor = true;
            this.Hotel_ConfirmDeleteCbx.CheckedChanged += new System.EventHandler(this.Hotel_ConfirmDeleteCbx_CheckedChanged);
            // 
            // Hotel_DeleteHotelBtn
            // 
            this.Hotel_DeleteHotelBtn.Enabled = false;
            this.Hotel_DeleteHotelBtn.ForeColor = System.Drawing.Color.Red;
            this.Hotel_DeleteHotelBtn.Location = new System.Drawing.Point(7, 152);
            this.Hotel_DeleteHotelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hotel_DeleteHotelBtn.Name = "Hotel_DeleteHotelBtn";
            this.Hotel_DeleteHotelBtn.Size = new System.Drawing.Size(236, 28);
            this.Hotel_DeleteHotelBtn.TabIndex = 3;
            this.Hotel_DeleteHotelBtn.Text = "Delete Hotel";
            this.Hotel_DeleteHotelBtn.UseVisualStyleBackColor = true;
            this.Hotel_DeleteHotelBtn.Click += new System.EventHandler(this.Hotel_DeleteHotelBtn_Click);
            // 
            // Hotel_WarningLbl
            // 
            this.Hotel_WarningLbl.Location = new System.Drawing.Point(4, 24);
            this.Hotel_WarningLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hotel_WarningLbl.Name = "Hotel_WarningLbl";
            this.Hotel_WarningLbl.Size = new System.Drawing.Size(243, 82);
            this.Hotel_WarningLbl.TabIndex = 1;
            this.Hotel_WarningLbl.Text = "WARNING: This will delete all Hotel Information and reset the database to origina" +
    "l values.\r\n\r\nPlease only perform this if you know what you are doing.";
            // 
            // HotelInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 208);
            this.Controls.Add(this.Hotel_DeleteHotelGbx);
            this.Controls.Add(this.Hotel_GenericGbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HotelInformation";
            this.Text = "Hotel Information";
            this.Load += new System.EventHandler(this.HotelInformation_Load);
            this.Hotel_GenericGbx.ResumeLayout(false);
            this.Hotel_GenericGbx.PerformLayout();
            this.Hotel_DeleteHotelGbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Hotel_HotelNameTbx;
        private System.Windows.Forms.Label Hotel_HotelNameLbl;
        private System.Windows.Forms.GroupBox Hotel_GenericGbx;
        private System.Windows.Forms.TextBox Hotel_CountryTbx;
        private System.Windows.Forms.Label Hotel_CountryLbl;
        private System.Windows.Forms.ComboBox Hotel_RatingLbx;
        private System.Windows.Forms.Label Hotel_RatingLbl;
        private System.Windows.Forms.TextBox Hotel_CityTbx;
        private System.Windows.Forms.Label Hotel_CityLbl;
        private System.Windows.Forms.Button Hotel_SaveGenericBtn;
        private System.Windows.Forms.Button Hotel_FetchBtn;
        private System.Windows.Forms.GroupBox Hotel_DeleteHotelGbx;
        private System.Windows.Forms.Button Hotel_DeleteHotelBtn;
        private System.Windows.Forms.Label Hotel_WarningLbl;
        private System.Windows.Forms.CheckBox Hotel_ConfirmDeleteCbx;
    }
}