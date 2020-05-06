namespace MAPMAClient.GUI {
    partial class Update_Room {
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
            this.grbEscapeRoom = new System.Windows.Forms.GroupBox();
            this.lblErrorPrice = new System.Windows.Forms.Label();
            this.txbCleanTime = new System.Windows.Forms.TextBox();
            this.txbMaxClearTime = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCleanTime = new System.Windows.Forms.Label();
            this.lblClearTime = new System.Windows.Forms.Label();
            this.lblDesricption = new System.Windows.Forms.Label();
            this.lblEscapeRoomName = new System.Windows.Forms.Label();
            this.grbEmployee = new System.Windows.Forms.GroupBox();
            this.lblFillEmpZipcode = new System.Windows.Forms.Label();
            this.lblFillEmpAddress = new System.Windows.Forms.Label();
            this.lblFillEmpPhone = new System.Windows.Forms.Label();
            this.lblFillEmpMail = new System.Windows.Forms.Label();
            this.cobEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmpZipcode = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.lblEmpMail = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.lblErrorClearTime = new System.Windows.Forms.Label();
            this.lblErrorCleanTime = new System.Windows.Forms.Label();
            this.grbEscapeRoom.SuspendLayout();
            this.grbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEscapeRoom
            // 
            this.grbEscapeRoom.Controls.Add(this.lblErrorCleanTime);
            this.grbEscapeRoom.Controls.Add(this.lblErrorClearTime);
            this.grbEscapeRoom.Controls.Add(this.lblErrorPrice);
            this.grbEscapeRoom.Controls.Add(this.txbCleanTime);
            this.grbEscapeRoom.Controls.Add(this.txbMaxClearTime);
            this.grbEscapeRoom.Controls.Add(this.txbDescription);
            this.grbEscapeRoom.Controls.Add(this.txbPrice);
            this.grbEscapeRoom.Controls.Add(this.txbName);
            this.grbEscapeRoom.Controls.Add(this.lblPrice);
            this.grbEscapeRoom.Controls.Add(this.lblCleanTime);
            this.grbEscapeRoom.Controls.Add(this.lblClearTime);
            this.grbEscapeRoom.Controls.Add(this.lblDesricption);
            this.grbEscapeRoom.Controls.Add(this.lblEscapeRoomName);
            this.grbEscapeRoom.Location = new System.Drawing.Point(13, 13);
            this.grbEscapeRoom.Name = "grbEscapeRoom";
            this.grbEscapeRoom.Size = new System.Drawing.Size(354, 235);
            this.grbEscapeRoom.TabIndex = 0;
            this.grbEscapeRoom.TabStop = false;
            this.grbEscapeRoom.Text = "EscapeRoom info";
            // 
            // lblErrorPrice
            // 
            this.lblErrorPrice.AutoSize = true;
            this.lblErrorPrice.Location = new System.Drawing.Point(121, 105);
            this.lblErrorPrice.Name = "lblErrorPrice";
            this.lblErrorPrice.Size = new System.Drawing.Size(100, 13);
            this.lblErrorPrice.TabIndex = 10;
            this.lblErrorPrice.Text = "Pris skal være et tal";
            this.lblErrorPrice.Visible = false;
            // 
            // txbCleanTime
            // 
            this.txbCleanTime.Location = new System.Drawing.Point(124, 192);
            this.txbCleanTime.Name = "txbCleanTime";
            this.txbCleanTime.Size = new System.Drawing.Size(224, 20);
            this.txbCleanTime.TabIndex = 9;
            this.txbCleanTime.TextChanged += new System.EventHandler(this.txbCleanTime_TextChanged);
            // 
            // txbMaxClearTime
            // 
            this.txbMaxClearTime.Location = new System.Drawing.Point(124, 154);
            this.txbMaxClearTime.Name = "txbMaxClearTime";
            this.txbMaxClearTime.Size = new System.Drawing.Size(224, 20);
            this.txbMaxClearTime.TabIndex = 8;
            this.txbMaxClearTime.TextChanged += new System.EventHandler(this.txbMaxClearTime_TextChanged);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(124, 121);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(224, 20);
            this.txbDescription.TabIndex = 7;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(124, 83);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(224, 20);
            this.txbPrice.TabIndex = 6;
            this.txbPrice.TextChanged += new System.EventHandler(this.txbPrice_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(124, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(224, 20);
            this.txbName.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Pris :";
            // 
            // lblCleanTime
            // 
            this.lblCleanTime.AutoSize = true;
            this.lblCleanTime.Location = new System.Drawing.Point(6, 195);
            this.lblCleanTime.Name = "lblCleanTime";
            this.lblCleanTime.Size = new System.Drawing.Size(81, 13);
            this.lblCleanTime.TabIndex = 3;
            this.lblCleanTime.Text = "Rengørings tid :";
            // 
            // lblClearTime
            // 
            this.lblClearTime.AutoSize = true;
            this.lblClearTime.Location = new System.Drawing.Point(6, 158);
            this.lblClearTime.Name = "lblClearTime";
            this.lblClearTime.Size = new System.Drawing.Size(94, 13);
            this.lblClearTime.TabIndex = 2;
            this.lblClearTime.Text = "Max tid i Rummet :";
            // 
            // lblDesricption
            // 
            this.lblDesricption.AutoSize = true;
            this.lblDesricption.Location = new System.Drawing.Point(7, 124);
            this.lblDesricption.Name = "lblDesricption";
            this.lblDesricption.Size = new System.Drawing.Size(67, 13);
            this.lblDesricption.TabIndex = 1;
            this.lblDesricption.Text = "Beskrivelse :";
            // 
            // lblEscapeRoomName
            // 
            this.lblEscapeRoomName.AutoSize = true;
            this.lblEscapeRoomName.Location = new System.Drawing.Point(6, 50);
            this.lblEscapeRoomName.Name = "lblEscapeRoomName";
            this.lblEscapeRoomName.Size = new System.Drawing.Size(39, 13);
            this.lblEscapeRoomName.TabIndex = 0;
            this.lblEscapeRoomName.Text = "Navn :";
            // 
            // grbEmployee
            // 
            this.grbEmployee.Controls.Add(this.lblFillEmpZipcode);
            this.grbEmployee.Controls.Add(this.lblFillEmpAddress);
            this.grbEmployee.Controls.Add(this.lblFillEmpPhone);
            this.grbEmployee.Controls.Add(this.lblFillEmpMail);
            this.grbEmployee.Controls.Add(this.cobEmployeeName);
            this.grbEmployee.Controls.Add(this.lblEmpZipcode);
            this.grbEmployee.Controls.Add(this.lblEmpAddress);
            this.grbEmployee.Controls.Add(this.lblEmpPhone);
            this.grbEmployee.Controls.Add(this.lblEmpMail);
            this.grbEmployee.Controls.Add(this.lblEmpName);
            this.grbEmployee.Location = new System.Drawing.Point(420, 13);
            this.grbEmployee.Name = "grbEmployee";
            this.grbEmployee.Size = new System.Drawing.Size(368, 316);
            this.grbEmployee.TabIndex = 1;
            this.grbEmployee.TabStop = false;
            this.grbEmployee.Text = "Employee info";
            // 
            // lblFillEmpZipcode
            // 
            this.lblFillEmpZipcode.AutoSize = true;
            this.lblFillEmpZipcode.Location = new System.Drawing.Point(113, 192);
            this.lblFillEmpZipcode.Name = "lblFillEmpZipcode";
            this.lblFillEmpZipcode.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpZipcode.TabIndex = 9;
            // 
            // lblFillEmpAddress
            // 
            this.lblFillEmpAddress.AutoSize = true;
            this.lblFillEmpAddress.Location = new System.Drawing.Point(113, 158);
            this.lblFillEmpAddress.Name = "lblFillEmpAddress";
            this.lblFillEmpAddress.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpAddress.TabIndex = 8;
            // 
            // lblFillEmpPhone
            // 
            this.lblFillEmpPhone.AutoSize = true;
            this.lblFillEmpPhone.Location = new System.Drawing.Point(113, 121);
            this.lblFillEmpPhone.Name = "lblFillEmpPhone";
            this.lblFillEmpPhone.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpPhone.TabIndex = 7;
            // 
            // lblFillEmpMail
            // 
            this.lblFillEmpMail.AutoSize = true;
            this.lblFillEmpMail.Location = new System.Drawing.Point(113, 86);
            this.lblFillEmpMail.Name = "lblFillEmpMail";
            this.lblFillEmpMail.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpMail.TabIndex = 6;
            // 
            // cobEmployeeName
            // 
            this.cobEmployeeName.FormattingEnabled = true;
            this.cobEmployeeName.Location = new System.Drawing.Point(113, 42);
            this.cobEmployeeName.Name = "cobEmployeeName";
            this.cobEmployeeName.Size = new System.Drawing.Size(249, 21);
            this.cobEmployeeName.TabIndex = 5;
            this.cobEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cobEmployeeName_SelectedIndexChanged);
            // 
            // lblEmpZipcode
            // 
            this.lblEmpZipcode.AutoSize = true;
            this.lblEmpZipcode.Location = new System.Drawing.Point(7, 192);
            this.lblEmpZipcode.Name = "lblEmpZipcode";
            this.lblEmpZipcode.Size = new System.Drawing.Size(71, 13);
            this.lblEmpZipcode.TabIndex = 4;
            this.lblEmpZipcode.Text = "Postnummer :";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Location = new System.Drawing.Point(6, 158);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(57, 13);
            this.lblEmpAddress.TabIndex = 3;
            this.lblEmpAddress.Text = "Addresse :";
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Location = new System.Drawing.Point(6, 121);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(60, 13);
            this.lblEmpPhone.TabIndex = 2;
            this.lblEmpPhone.Text = "TelefonNr :";
            // 
            // lblEmpMail
            // 
            this.lblEmpMail.AutoSize = true;
            this.lblEmpMail.Location = new System.Drawing.Point(6, 83);
            this.lblEmpMail.Name = "lblEmpMail";
            this.lblEmpMail.Size = new System.Drawing.Size(32, 13);
            this.lblEmpMail.TabIndex = 1;
            this.lblEmpMail.Text = "Mail :";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(7, 46);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(68, 13);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Fulde Navn :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Location = new System.Drawing.Point(684, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(581, 415);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateRoom.TabIndex = 6;
            this.btnUpdateRoom.Text = "Updater Rum";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // lblErrorClearTime
            // 
            this.lblErrorClearTime.AutoSize = true;
            this.lblErrorClearTime.Location = new System.Drawing.Point(121, 177);
            this.lblErrorClearTime.Name = "lblErrorClearTime";
            this.lblErrorClearTime.Size = new System.Drawing.Size(164, 13);
            this.lblErrorClearTime.TabIndex = 11;
            this.lblErrorClearTime.Text = "Max tid i Rummet skal være et tal";
            this.lblErrorClearTime.Visible = false;
            // 
            // lblErrorCleanTime
            // 
            this.lblErrorCleanTime.AutoSize = true;
            this.lblErrorCleanTime.Location = new System.Drawing.Point(121, 215);
            this.lblErrorCleanTime.Name = "lblErrorCleanTime";
            this.lblErrorCleanTime.Size = new System.Drawing.Size(151, 13);
            this.lblErrorCleanTime.TabIndex = 12;
            this.lblErrorCleanTime.Text = "Rengørings tid skal være et tal";
            this.lblErrorCleanTime.Visible = false;
            // 
            // Update_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbEmployee);
            this.Controls.Add(this.grbEscapeRoom);
            this.Name = "Update_Room";
            this.Text = "Update_Room";
            this.grbEscapeRoom.ResumeLayout(false);
            this.grbEscapeRoom.PerformLayout();
            this.grbEmployee.ResumeLayout(false);
            this.grbEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEscapeRoom;
        private System.Windows.Forms.GroupBox grbEmployee;
        private System.Windows.Forms.TextBox txbCleanTime;
        private System.Windows.Forms.TextBox txbMaxClearTime;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCleanTime;
        private System.Windows.Forms.Label lblClearTime;
        private System.Windows.Forms.Label lblDesricption;
        private System.Windows.Forms.Label lblEscapeRoomName;
        private System.Windows.Forms.Label lblEmpZipcode;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.Label lblEmpMail;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblFillEmpZipcode;
        private System.Windows.Forms.Label lblFillEmpAddress;
        private System.Windows.Forms.Label lblFillEmpPhone;
        private System.Windows.Forms.Label lblFillEmpMail;
        private System.Windows.Forms.ComboBox cobEmployeeName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Label lblErrorPrice;
        private System.Windows.Forms.Label lblErrorCleanTime;
        private System.Windows.Forms.Label lblErrorClearTime;
    }
}