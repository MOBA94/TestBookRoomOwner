namespace MAPMAClient.GUI
{
    partial class Edit_Delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ( )
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbBookingInfo = new System.Windows.Forms.GroupBox();
            this.cbBookingTime = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbEscaperoom = new System.Windows.Forms.ComboBox();
            this.tbAmountOfPeople = new System.Windows.Forms.TextBox();
            this.lblEmployeeNameDelete = new System.Windows.Forms.Label();
            this.lblDateDelete = new System.Windows.Forms.Label();
            this.lblEscaperoomDelete = new System.Windows.Forms.Label();
            this.lblAmountOfPeopleDelete = new System.Windows.Forms.Label();
            this.lblBookingTimeDelete = new System.Windows.Forms.Label();
            this.lblEmployeeNameEdit_Delete = new System.Windows.Forms.Label();
            this.lblDateEdit_Delete = new System.Windows.Forms.Label();
            this.lblBookingTimeEdit_Delete = new System.Windows.Forms.Label();
            this.lblAmountOfPeopleEdit_Delete = new System.Windows.Forms.Label();
            this.lblEscaperoomNameEdit_Delete = new System.Windows.Forms.Label();
            this.lblUsernameEdit_Delete = new System.Windows.Forms.Label();
            this.lblFirstNameEdit_Delete = new System.Windows.Forms.Label();
            this.lblLastNameEdit_Delete = new System.Windows.Forms.Label();
            this.lblMailEdit_Delete = new System.Windows.Forms.Label();
            this.lblPhoneEdit_Delete = new System.Windows.Forms.Label();
            this.gbBrugerInfo = new System.Windows.Forms.GroupBox();
            this.lblPhoneDelete = new System.Windows.Forms.Label();
            this.lblMailDelete = new System.Windows.Forms.Label();
            this.lblLastNameDelete = new System.Windows.Forms.Label();
            this.lblFirstNameDelete = new System.Windows.Forms.Label();
            this.lblUsernameDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mcUpdateBooking = new System.Windows.Forms.MonthCalendar();
            this.gbBookingInfo.SuspendLayout();
            this.gbBrugerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBookingInfo
            // 
            this.gbBookingInfo.Controls.Add(this.mcUpdateBooking);
            this.gbBookingInfo.Controls.Add(this.cbBookingTime);
            this.gbBookingInfo.Controls.Add(this.cbEmployee);
            this.gbBookingInfo.Controls.Add(this.cbEscaperoom);
            this.gbBookingInfo.Controls.Add(this.tbAmountOfPeople);
            this.gbBookingInfo.Controls.Add(this.lblEmployeeNameDelete);
            this.gbBookingInfo.Controls.Add(this.lblDateDelete);
            this.gbBookingInfo.Controls.Add(this.lblEscaperoomDelete);
            this.gbBookingInfo.Controls.Add(this.lblAmountOfPeopleDelete);
            this.gbBookingInfo.Controls.Add(this.lblBookingTimeDelete);
            this.gbBookingInfo.Controls.Add(this.lblEmployeeNameEdit_Delete);
            this.gbBookingInfo.Controls.Add(this.lblDateEdit_Delete);
            this.gbBookingInfo.Controls.Add(this.lblBookingTimeEdit_Delete);
            this.gbBookingInfo.Controls.Add(this.lblAmountOfPeopleEdit_Delete);
            this.gbBookingInfo.Controls.Add(this.lblEscaperoomNameEdit_Delete);
            this.gbBookingInfo.Location = new System.Drawing.Point(337, 13);
            this.gbBookingInfo.Name = "gbBookingInfo";
            this.gbBookingInfo.Size = new System.Drawing.Size(451, 391);
            this.gbBookingInfo.TabIndex = 2;
            this.gbBookingInfo.TabStop = false;
            this.gbBookingInfo.Text = "Booking Info";
            // 
            // cbBookingTime
            // 
            this.cbBookingTime.FormattingEnabled = true;
            this.cbBookingTime.Location = new System.Drawing.Point(117, 321);
            this.cbBookingTime.Name = "cbBookingTime";
            this.cbBookingTime.Size = new System.Drawing.Size(236, 21);
            this.cbBookingTime.TabIndex = 15;
            this.cbBookingTime.Visible = false;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(118, 105);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(235, 21);
            this.cbEmployee.TabIndex = 14;
            this.cbEmployee.Visible = false;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // cbEscaperoom
            // 
            this.cbEscaperoom.FormattingEnabled = true;
            this.cbEscaperoom.Location = new System.Drawing.Point(117, 31);
            this.cbEscaperoom.Name = "cbEscaperoom";
            this.cbEscaperoom.Size = new System.Drawing.Size(235, 21);
            this.cbEscaperoom.TabIndex = 13;
            this.cbEscaperoom.Visible = false;
            this.cbEscaperoom.SelectedIndexChanged += new System.EventHandler(this.cbEscaperoom_SelectedIndexChanged);
            // 
            // tbAmountOfPeople
            // 
            this.tbAmountOfPeople.Location = new System.Drawing.Point(117, 68);
            this.tbAmountOfPeople.Name = "tbAmountOfPeople";
            this.tbAmountOfPeople.Size = new System.Drawing.Size(236, 20);
            this.tbAmountOfPeople.TabIndex = 10;
            this.tbAmountOfPeople.Visible = false;
            this.tbAmountOfPeople.TextChanged += new System.EventHandler(this.tbAmountOfPeople_TextChanged);
            this.tbAmountOfPeople.Leave += new System.EventHandler(this.tbAmountOfPeople_Leave);
            // 
            // lblEmployeeNameDelete
            // 
            this.lblEmployeeNameDelete.AutoSize = true;
            this.lblEmployeeNameDelete.Location = new System.Drawing.Point(111, 108);
            this.lblEmployeeNameDelete.Name = "lblEmployeeNameDelete";
            this.lblEmployeeNameDelete.Size = new System.Drawing.Size(0, 13);
            this.lblEmployeeNameDelete.TabIndex = 9;
            // 
            // lblDateDelete
            // 
            this.lblDateDelete.AutoSize = true;
            this.lblDateDelete.Location = new System.Drawing.Point(111, 144);
            this.lblDateDelete.Name = "lblDateDelete";
            this.lblDateDelete.Size = new System.Drawing.Size(0, 13);
            this.lblDateDelete.TabIndex = 8;
            // 
            // lblEscaperoomDelete
            // 
            this.lblEscaperoomDelete.AutoSize = true;
            this.lblEscaperoomDelete.Location = new System.Drawing.Point(111, 34);
            this.lblEscaperoomDelete.Name = "lblEscaperoomDelete";
            this.lblEscaperoomDelete.Size = new System.Drawing.Size(0, 13);
            this.lblEscaperoomDelete.TabIndex = 7;
            // 
            // lblAmountOfPeopleDelete
            // 
            this.lblAmountOfPeopleDelete.AutoSize = true;
            this.lblAmountOfPeopleDelete.Location = new System.Drawing.Point(111, 71);
            this.lblAmountOfPeopleDelete.Name = "lblAmountOfPeopleDelete";
            this.lblAmountOfPeopleDelete.Size = new System.Drawing.Size(0, 13);
            this.lblAmountOfPeopleDelete.TabIndex = 6;
            // 
            // lblBookingTimeDelete
            // 
            this.lblBookingTimeDelete.AutoSize = true;
            this.lblBookingTimeDelete.Location = new System.Drawing.Point(111, 329);
            this.lblBookingTimeDelete.Name = "lblBookingTimeDelete";
            this.lblBookingTimeDelete.Size = new System.Drawing.Size(0, 13);
            this.lblBookingTimeDelete.TabIndex = 5;
            // 
            // lblEmployeeNameEdit_Delete
            // 
            this.lblEmployeeNameEdit_Delete.AutoSize = true;
            this.lblEmployeeNameEdit_Delete.Location = new System.Drawing.Point(6, 108);
            this.lblEmployeeNameEdit_Delete.Name = "lblEmployeeNameEdit_Delete";
            this.lblEmployeeNameEdit_Delete.Size = new System.Drawing.Size(72, 13);
            this.lblEmployeeNameEdit_Delete.TabIndex = 4;
            this.lblEmployeeNameEdit_Delete.Text = "Medarbejder :";
            // 
            // lblDateEdit_Delete
            // 
            this.lblDateEdit_Delete.AutoSize = true;
            this.lblDateEdit_Delete.Location = new System.Drawing.Point(6, 144);
            this.lblDateEdit_Delete.Name = "lblDateEdit_Delete";
            this.lblDateEdit_Delete.Size = new System.Drawing.Size(36, 13);
            this.lblDateEdit_Delete.TabIndex = 3;
            this.lblDateEdit_Delete.Text = "Dato :";
            // 
            // lblBookingTimeEdit_Delete
            // 
            this.lblBookingTimeEdit_Delete.AutoSize = true;
            this.lblBookingTimeEdit_Delete.Location = new System.Drawing.Point(6, 329);
            this.lblBookingTimeEdit_Delete.Name = "lblBookingTimeEdit_Delete";
            this.lblBookingTimeEdit_Delete.Size = new System.Drawing.Size(98, 13);
            this.lblBookingTimeEdit_Delete.TabIndex = 2;
            this.lblBookingTimeEdit_Delete.Text = "Booking tidspunkt :";
            // 
            // lblAmountOfPeopleEdit_Delete
            // 
            this.lblAmountOfPeopleEdit_Delete.AutoSize = true;
            this.lblAmountOfPeopleEdit_Delete.Location = new System.Drawing.Point(6, 71);
            this.lblAmountOfPeopleEdit_Delete.Name = "lblAmountOfPeopleEdit_Delete";
            this.lblAmountOfPeopleEdit_Delete.Size = new System.Drawing.Size(81, 13);
            this.lblAmountOfPeopleEdit_Delete.TabIndex = 1;
            this.lblAmountOfPeopleEdit_Delete.Text = "Antal personer :";
            // 
            // lblEscaperoomNameEdit_Delete
            // 
            this.lblEscaperoomNameEdit_Delete.AutoSize = true;
            this.lblEscaperoomNameEdit_Delete.Location = new System.Drawing.Point(6, 34);
            this.lblEscaperoomNameEdit_Delete.Name = "lblEscaperoomNameEdit_Delete";
            this.lblEscaperoomNameEdit_Delete.Size = new System.Drawing.Size(72, 13);
            this.lblEscaperoomNameEdit_Delete.TabIndex = 0;
            this.lblEscaperoomNameEdit_Delete.Text = "Escaperoom :";
            // 
            // lblUsernameEdit_Delete
            // 
            this.lblUsernameEdit_Delete.AutoSize = true;
            this.lblUsernameEdit_Delete.Location = new System.Drawing.Point(6, 34);
            this.lblUsernameEdit_Delete.Name = "lblUsernameEdit_Delete";
            this.lblUsernameEdit_Delete.Size = new System.Drawing.Size(68, 13);
            this.lblUsernameEdit_Delete.TabIndex = 0;
            this.lblUsernameEdit_Delete.Text = "Brugernavn :";
            this.lblUsernameEdit_Delete.UseMnemonic = false;
            // 
            // lblFirstNameEdit_Delete
            // 
            this.lblFirstNameEdit_Delete.AutoSize = true;
            this.lblFirstNameEdit_Delete.Location = new System.Drawing.Point(6, 71);
            this.lblFirstNameEdit_Delete.Name = "lblFirstNameEdit_Delete";
            this.lblFirstNameEdit_Delete.Size = new System.Drawing.Size(52, 13);
            this.lblFirstNameEdit_Delete.TabIndex = 1;
            this.lblFirstNameEdit_Delete.Text = "Fornavn :";
            // 
            // lblLastNameEdit_Delete
            // 
            this.lblLastNameEdit_Delete.AutoSize = true;
            this.lblLastNameEdit_Delete.Location = new System.Drawing.Point(6, 108);
            this.lblLastNameEdit_Delete.Name = "lblLastNameEdit_Delete";
            this.lblLastNameEdit_Delete.Size = new System.Drawing.Size(59, 13);
            this.lblLastNameEdit_Delete.TabIndex = 2;
            this.lblLastNameEdit_Delete.Text = "Efternavn :";
            // 
            // lblMailEdit_Delete
            // 
            this.lblMailEdit_Delete.AutoSize = true;
            this.lblMailEdit_Delete.Location = new System.Drawing.Point(6, 145);
            this.lblMailEdit_Delete.Name = "lblMailEdit_Delete";
            this.lblMailEdit_Delete.Size = new System.Drawing.Size(32, 13);
            this.lblMailEdit_Delete.TabIndex = 3;
            this.lblMailEdit_Delete.Text = "Mail :";
            // 
            // lblPhoneEdit_Delete
            // 
            this.lblPhoneEdit_Delete.AutoSize = true;
            this.lblPhoneEdit_Delete.Location = new System.Drawing.Point(6, 181);
            this.lblPhoneEdit_Delete.Name = "lblPhoneEdit_Delete";
            this.lblPhoneEdit_Delete.Size = new System.Drawing.Size(61, 13);
            this.lblPhoneEdit_Delete.TabIndex = 4;
            this.lblPhoneEdit_Delete.Text = "Telefon nr :";
            // 
            // gbBrugerInfo
            // 
            this.gbBrugerInfo.Controls.Add(this.lblPhoneDelete);
            this.gbBrugerInfo.Controls.Add(this.lblMailDelete);
            this.gbBrugerInfo.Controls.Add(this.lblLastNameDelete);
            this.gbBrugerInfo.Controls.Add(this.lblFirstNameDelete);
            this.gbBrugerInfo.Controls.Add(this.lblUsernameDelete);
            this.gbBrugerInfo.Controls.Add(this.lblPhoneEdit_Delete);
            this.gbBrugerInfo.Controls.Add(this.lblMailEdit_Delete);
            this.gbBrugerInfo.Controls.Add(this.lblLastNameEdit_Delete);
            this.gbBrugerInfo.Controls.Add(this.lblFirstNameEdit_Delete);
            this.gbBrugerInfo.Controls.Add(this.lblUsernameEdit_Delete);
            this.gbBrugerInfo.Location = new System.Drawing.Point(12, 13);
            this.gbBrugerInfo.Name = "gbBrugerInfo";
            this.gbBrugerInfo.Size = new System.Drawing.Size(309, 221);
            this.gbBrugerInfo.TabIndex = 1;
            this.gbBrugerInfo.TabStop = false;
            this.gbBrugerInfo.Text = "Bruger Info";
            // 
            // lblPhoneDelete
            // 
            this.lblPhoneDelete.AutoSize = true;
            this.lblPhoneDelete.Location = new System.Drawing.Point(80, 181);
            this.lblPhoneDelete.Name = "lblPhoneDelete";
            this.lblPhoneDelete.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneDelete.TabIndex = 9;
            // 
            // lblMailDelete
            // 
            this.lblMailDelete.AutoSize = true;
            this.lblMailDelete.Location = new System.Drawing.Point(80, 145);
            this.lblMailDelete.Name = "lblMailDelete";
            this.lblMailDelete.Size = new System.Drawing.Size(0, 13);
            this.lblMailDelete.TabIndex = 8;
            // 
            // lblLastNameDelete
            // 
            this.lblLastNameDelete.AutoSize = true;
            this.lblLastNameDelete.Location = new System.Drawing.Point(80, 108);
            this.lblLastNameDelete.Name = "lblLastNameDelete";
            this.lblLastNameDelete.Size = new System.Drawing.Size(0, 13);
            this.lblLastNameDelete.TabIndex = 7;
            // 
            // lblFirstNameDelete
            // 
            this.lblFirstNameDelete.AutoSize = true;
            this.lblFirstNameDelete.Location = new System.Drawing.Point(80, 71);
            this.lblFirstNameDelete.Name = "lblFirstNameDelete";
            this.lblFirstNameDelete.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNameDelete.TabIndex = 6;
            // 
            // lblUsernameDelete
            // 
            this.lblUsernameDelete.AutoSize = true;
            this.lblUsernameDelete.Location = new System.Drawing.Point(80, 34);
            this.lblUsernameDelete.Name = "lblUsernameDelete";
            this.lblUsernameDelete.Size = new System.Drawing.Size(0, 13);
            this.lblUsernameDelete.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(245, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Slet";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Location = new System.Drawing.Point(712, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Opdater";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mcUpdateBooking
            // 
            this.mcUpdateBooking.Location = new System.Drawing.Point(118, 144);
            this.mcUpdateBooking.MaxSelectionCount = 1;
            this.mcUpdateBooking.Name = "mcUpdateBooking";
            this.mcUpdateBooking.TabIndex = 16;
            this.mcUpdateBooking.Visible = false;
            this.mcUpdateBooking.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcUpdateBooking_DateChanged);
            // 
            // Edit_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbBookingInfo);
            this.Controls.Add(this.gbBrugerInfo);
            this.Name = "Edit_Delete";
            this.Text = "Edit_Delete";
            this.gbBookingInfo.ResumeLayout(false);
            this.gbBookingInfo.PerformLayout();
            this.gbBrugerInfo.ResumeLayout(false);
            this.gbBrugerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbBookingInfo;
        private System.Windows.Forms.Label lblEmployeeNameEdit_Delete;
        private System.Windows.Forms.Label lblDateEdit_Delete;
        private System.Windows.Forms.Label lblBookingTimeEdit_Delete;
        private System.Windows.Forms.Label lblAmountOfPeopleEdit_Delete;
        private System.Windows.Forms.Label lblEscaperoomNameEdit_Delete;
        private System.Windows.Forms.Label lblUsernameEdit_Delete;
        private System.Windows.Forms.Label lblFirstNameEdit_Delete;
        private System.Windows.Forms.Label lblLastNameEdit_Delete;
        private System.Windows.Forms.Label lblMailEdit_Delete;
        private System.Windows.Forms.Label lblPhoneEdit_Delete;
        private System.Windows.Forms.GroupBox gbBrugerInfo;
        private System.Windows.Forms.Label lblPhoneDelete;
        private System.Windows.Forms.Label lblMailDelete;
        private System.Windows.Forms.Label lblLastNameDelete;
        private System.Windows.Forms.Label lblFirstNameDelete;
        private System.Windows.Forms.Label lblUsernameDelete;
        private System.Windows.Forms.Label lblEmployeeNameDelete;
        private System.Windows.Forms.Label lblDateDelete;
        private System.Windows.Forms.Label lblEscaperoomDelete;
        private System.Windows.Forms.Label lblAmountOfPeopleDelete;
        private System.Windows.Forms.Label lblBookingTimeDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbEscaperoom;
        private System.Windows.Forms.TextBox tbBookingTime;
        private System.Windows.Forms.TextBox tbAmountOfPeople;
        private System.Windows.Forms.ComboBox cbBookingTime;
        private System.Windows.Forms.MonthCalendar mcUpdateBooking;
    }
}