namespace MAPMAClient.GUI {
    partial class CreateBooking {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.grbEscapeRoom = new System.Windows.Forms.GroupBox();
            this.grbCustomer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobNavnER = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceRead = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblRatingRead = new System.Windows.Forms.Label();
            this.lblClearTime = new System.Windows.Forms.Label();
            this.lblClearTimeRead = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFirstNameRead = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLastNameRead = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneRead = new System.Windows.Forms.Label();
            this.lblBookEscapeRoomName = new System.Windows.Forms.Label();
            this.lblBookEscapeRoomNameRead = new System.Windows.Forms.Label();
            this.lblBookCustomerFullName = new System.Windows.Forms.Label();
            this.lblBookCustomerNameRead = new System.Windows.Forms.Label();
            this.lblBookAmountOfPeople = new System.Windows.Forms.Label();
            this.txbAmountOfPeople = new System.Windows.Forms.TextBox();
            this.lblBookDate = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblBookDateRead = new System.Windows.Forms.Label();
            this.lblBookCalenderRead = new System.Windows.Forms.Label();
            this.grbEscapeRoom.SuspendLayout();
            this.grbCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(694, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(613, 295);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Færdig";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // grbEscapeRoom
            // 
            this.grbEscapeRoom.Controls.Add(this.lblClearTimeRead);
            this.grbEscapeRoom.Controls.Add(this.lblClearTime);
            this.grbEscapeRoom.Controls.Add(this.lblRatingRead);
            this.grbEscapeRoom.Controls.Add(this.lblRating);
            this.grbEscapeRoom.Controls.Add(this.lblPriceRead);
            this.grbEscapeRoom.Controls.Add(this.lblPrice);
            this.grbEscapeRoom.Controls.Add(this.lblName);
            this.grbEscapeRoom.Controls.Add(this.cobNavnER);
            this.grbEscapeRoom.Location = new System.Drawing.Point(13, 13);
            this.grbEscapeRoom.Name = "grbEscapeRoom";
            this.grbEscapeRoom.Size = new System.Drawing.Size(209, 235);
            this.grbEscapeRoom.TabIndex = 2;
            this.grbEscapeRoom.TabStop = false;
            this.grbEscapeRoom.Text = "EscapeRoom";
            // 
            // grbCustomer
            // 
            this.grbCustomer.Controls.Add(this.lblPhoneRead);
            this.grbCustomer.Controls.Add(this.lblPhone);
            this.grbCustomer.Controls.Add(this.lblLastNameRead);
            this.grbCustomer.Controls.Add(this.lblLastName);
            this.grbCustomer.Controls.Add(this.lblFirstNameRead);
            this.grbCustomer.Controls.Add(this.lblFirstName);
            this.grbCustomer.Controls.Add(this.txbName);
            this.grbCustomer.Controls.Add(this.lblUsername);
            this.grbCustomer.Location = new System.Drawing.Point(228, 13);
            this.grbCustomer.Name = "grbCustomer";
            this.grbCustomer.Size = new System.Drawing.Size(200, 235);
            this.grbCustomer.TabIndex = 3;
            this.grbCustomer.TabStop = false;
            this.grbCustomer.Text = "Kunde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBookDateRead);
            this.groupBox1.Controls.Add(this.lblBookDate);
            this.groupBox1.Controls.Add(this.txbAmountOfPeople);
            this.groupBox1.Controls.Add(this.lblBookAmountOfPeople);
            this.groupBox1.Controls.Add(this.lblBookCustomerNameRead);
            this.groupBox1.Controls.Add(this.lblBookCustomerFullName);
            this.groupBox1.Controls.Add(this.lblBookEscapeRoomNameRead);
            this.groupBox1.Controls.Add(this.lblBookEscapeRoomName);
            this.groupBox1.Location = new System.Drawing.Point(434, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking";
            // 
            // cobNavnER
            // 
            this.cobNavnER.FormattingEnabled = true;
            this.cobNavnER.Location = new System.Drawing.Point(10, 36);
            this.cobNavnER.Name = "cobNavnER";
            this.cobNavnER.Size = new System.Drawing.Size(171, 21);
            this.cobNavnER.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "EscapeRoom Navn";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Pris";
            // 
            // lblPriceRead
            // 
            this.lblPriceRead.AutoSize = true;
            this.lblPriceRead.Location = new System.Drawing.Point(10, 81);
            this.lblPriceRead.Name = "lblPriceRead";
            this.lblPriceRead.Size = new System.Drawing.Size(0, 13);
            this.lblPriceRead.TabIndex = 3;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(10, 107);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating";
            // 
            // lblRatingRead
            // 
            this.lblRatingRead.AutoSize = true;
            this.lblRatingRead.Location = new System.Drawing.Point(10, 124);
            this.lblRatingRead.Name = "lblRatingRead";
            this.lblRatingRead.Size = new System.Drawing.Size(0, 13);
            this.lblRatingRead.TabIndex = 5;
            // 
            // lblClearTime
            // 
            this.lblClearTime.AutoSize = true;
            this.lblClearTime.Location = new System.Drawing.Point(10, 145);
            this.lblClearTime.Name = "lblClearTime";
            this.lblClearTime.Size = new System.Drawing.Size(57, 13);
            this.lblClearTime.TabIndex = 6;
            this.lblClearTime.Text = "Clear Time";
            // 
            // lblClearTimeRead
            // 
            this.lblClearTimeRead.AutoSize = true;
            this.lblClearTimeRead.Location = new System.Drawing.Point(13, 162);
            this.lblClearTimeRead.Name = "lblClearTimeRead";
            this.lblClearTimeRead.Size = new System.Drawing.Size(0, 13);
            this.lblClearTimeRead.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "BrugerNavn";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(10, 36);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(170, 20);
            this.txbName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Fornavn";
            // 
            // lblFirstNameRead
            // 
            this.lblFirstNameRead.AutoSize = true;
            this.lblFirstNameRead.Location = new System.Drawing.Point(13, 84);
            this.lblFirstNameRead.Name = "lblFirstNameRead";
            this.lblFirstNameRead.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNameRead.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "EfterNavn";
            // 
            // lblLastNameRead
            // 
            this.lblLastNameRead.AutoSize = true;
            this.lblLastNameRead.Location = new System.Drawing.Point(13, 124);
            this.lblLastNameRead.Name = "lblLastNameRead";
            this.lblLastNameRead.Size = new System.Drawing.Size(0, 13);
            this.lblLastNameRead.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 145);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefon Nr.";
            // 
            // lblPhoneRead
            // 
            this.lblPhoneRead.AutoSize = true;
            this.lblPhoneRead.Location = new System.Drawing.Point(13, 162);
            this.lblPhoneRead.Name = "lblPhoneRead";
            this.lblPhoneRead.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneRead.TabIndex = 7;
            // 
            // lblBookEscapeRoomName
            // 
            this.lblBookEscapeRoomName.AutoSize = true;
            this.lblBookEscapeRoomName.Location = new System.Drawing.Point(6, 21);
            this.lblBookEscapeRoomName.Name = "lblBookEscapeRoomName";
            this.lblBookEscapeRoomName.Size = new System.Drawing.Size(100, 13);
            this.lblBookEscapeRoomName.TabIndex = 0;
            this.lblBookEscapeRoomName.Text = "EscapeRoom Navn";
            // 
            // lblBookEscapeRoomNameRead
            // 
            this.lblBookEscapeRoomNameRead.AutoSize = true;
            this.lblBookEscapeRoomNameRead.Location = new System.Drawing.Point(10, 37);
            this.lblBookEscapeRoomNameRead.Name = "lblBookEscapeRoomNameRead";
            this.lblBookEscapeRoomNameRead.Size = new System.Drawing.Size(0, 13);
            this.lblBookEscapeRoomNameRead.TabIndex = 1;
            // 
            // lblBookCustomerFullName
            // 
            this.lblBookCustomerFullName.AutoSize = true;
            this.lblBookCustomerFullName.Location = new System.Drawing.Point(7, 67);
            this.lblBookCustomerFullName.Name = "lblBookCustomerFullName";
            this.lblBookCustomerFullName.Size = new System.Drawing.Size(78, 13);
            this.lblBookCustomerFullName.TabIndex = 2;
            this.lblBookCustomerFullName.Text = "Kundens Navn";
            // 
            // lblBookCustomerNameRead
            // 
            this.lblBookCustomerNameRead.AutoSize = true;
            this.lblBookCustomerNameRead.Location = new System.Drawing.Point(10, 84);
            this.lblBookCustomerNameRead.Name = "lblBookCustomerNameRead";
            this.lblBookCustomerNameRead.Size = new System.Drawing.Size(0, 13);
            this.lblBookCustomerNameRead.TabIndex = 3;
            // 
            // lblBookAmountOfPeople
            // 
            this.lblBookAmountOfPeople.AutoSize = true;
            this.lblBookAmountOfPeople.Location = new System.Drawing.Point(10, 107);
            this.lblBookAmountOfPeople.Name = "lblBookAmountOfPeople";
            this.lblBookAmountOfPeople.Size = new System.Drawing.Size(87, 13);
            this.lblBookAmountOfPeople.TabIndex = 4;
            this.lblBookAmountOfPeople.Text = "Antal Mennesker";
            // 
            // txbAmountOfPeople
            // 
            this.txbAmountOfPeople.Location = new System.Drawing.Point(10, 122);
            this.txbAmountOfPeople.Name = "txbAmountOfPeople";
            this.txbAmountOfPeople.Size = new System.Drawing.Size(96, 20);
            this.txbAmountOfPeople.TabIndex = 5;
            // 
            // lblBookDate
            // 
            this.lblBookDate.AutoSize = true;
            this.lblBookDate.Location = new System.Drawing.Point(10, 146);
            this.lblBookDate.Name = "lblBookDate";
            this.lblBookDate.Size = new System.Drawing.Size(90, 13);
            this.lblBookDate.TabIndex = 6;
            this.lblBookDate.Text = "Dato For Booking";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(611, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // lblBookDateRead
            // 
            this.lblBookDateRead.AutoSize = true;
            this.lblBookDateRead.Location = new System.Drawing.Point(13, 162);
            this.lblBookDateRead.Name = "lblBookDateRead";
            this.lblBookDateRead.Size = new System.Drawing.Size(0, 13);
            this.lblBookDateRead.TabIndex = 7;
            // 
            // lblBookCalenderRead
            // 
            this.lblBookCalenderRead.AutoSize = true;
            this.lblBookCalenderRead.Location = new System.Drawing.Point(613, 24);
            this.lblBookCalenderRead.Name = "lblBookCalenderRead";
            this.lblBookCalenderRead.Size = new System.Drawing.Size(72, 13);
            this.lblBookCalenderRead.TabIndex = 8;
            this.lblBookCalenderRead.Text = "Dato Booking";
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBookCalenderRead);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCustomer);
            this.Controls.Add(this.grbEscapeRoom);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.grbEscapeRoom.ResumeLayout(false);
            this.grbEscapeRoom.PerformLayout();
            this.grbCustomer.ResumeLayout(false);
            this.grbCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox grbEscapeRoom;
        private System.Windows.Forms.Label lblPriceRead;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cobNavnER;
        private System.Windows.Forms.GroupBox grbCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClearTimeRead;
        private System.Windows.Forms.Label lblClearTime;
        private System.Windows.Forms.Label lblRatingRead;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPhoneRead;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastNameRead;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstNameRead;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBookDateRead;
        private System.Windows.Forms.Label lblBookDate;
        private System.Windows.Forms.TextBox txbAmountOfPeople;
        private System.Windows.Forms.Label lblBookAmountOfPeople;
        private System.Windows.Forms.Label lblBookCustomerNameRead;
        private System.Windows.Forms.Label lblBookCustomerFullName;
        private System.Windows.Forms.Label lblBookEscapeRoomNameRead;
        private System.Windows.Forms.Label lblBookEscapeRoomName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblBookCalenderRead;
    }
}