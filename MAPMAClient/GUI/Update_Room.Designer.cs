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
            this.grbEmployee = new System.Windows.Forms.GroupBox();
            this.lblEscapeRoomName = new System.Windows.Forms.Label();
            this.lblDesricption = new System.Windows.Forms.Label();
            this.lblClearTime = new System.Windows.Forms.Label();
            this.lblCleanTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbMaxClearTime = new System.Windows.Forms.TextBox();
            this.txbCleanTime = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpMail = new System.Windows.Forms.Label();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpZipcode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cobEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblFillEmpMail = new System.Windows.Forms.Label();
            this.lblFillEmpPhone = new System.Windows.Forms.Label();
            this.lblFillEmpAddress = new System.Windows.Forms.Label();
            this.lblFillEmpZipcode = new System.Windows.Forms.Label();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.grbEscapeRoom.SuspendLayout();
            this.grbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEscapeRoom
            // 
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
            this.grbEscapeRoom.Size = new System.Drawing.Size(354, 214);
            this.grbEscapeRoom.TabIndex = 0;
            this.grbEscapeRoom.TabStop = false;
            this.grbEscapeRoom.Text = "EscapeRoom info";
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
            // lblEscapeRoomName
            // 
            this.lblEscapeRoomName.AutoSize = true;
            this.lblEscapeRoomName.Location = new System.Drawing.Point(6, 46);
            this.lblEscapeRoomName.Name = "lblEscapeRoomName";
            this.lblEscapeRoomName.Size = new System.Drawing.Size(39, 13);
            this.lblEscapeRoomName.TabIndex = 0;
            this.lblEscapeRoomName.Text = "Navn :";
            // 
            // lblDesricption
            // 
            this.lblDesricption.AutoSize = true;
            this.lblDesricption.Location = new System.Drawing.Point(7, 102);
            this.lblDesricption.Name = "lblDesricption";
            this.lblDesricption.Size = new System.Drawing.Size(67, 13);
            this.lblDesricption.TabIndex = 1;
            this.lblDesricption.Text = "Beskrivelse :";
            // 
            // lblClearTime
            // 
            this.lblClearTime.AutoSize = true;
            this.lblClearTime.Location = new System.Drawing.Point(6, 132);
            this.lblClearTime.Name = "lblClearTime";
            this.lblClearTime.Size = new System.Drawing.Size(94, 13);
            this.lblClearTime.TabIndex = 2;
            this.lblClearTime.Text = "Max tid i Rummet :";
            // 
            // lblCleanTime
            // 
            this.lblCleanTime.AutoSize = true;
            this.lblCleanTime.Location = new System.Drawing.Point(6, 161);
            this.lblCleanTime.Name = "lblCleanTime";
            this.lblCleanTime.Size = new System.Drawing.Size(81, 13);
            this.lblCleanTime.TabIndex = 3;
            this.lblCleanTime.Text = "Rengørings tid :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 72);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Pris :";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(124, 43);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(224, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(124, 69);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(224, 20);
            this.txbPrice.TabIndex = 6;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(124, 99);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(224, 20);
            this.txbDescription.TabIndex = 7;
            // 
            // txbMaxClearTime
            // 
            this.txbMaxClearTime.Location = new System.Drawing.Point(124, 128);
            this.txbMaxClearTime.Name = "txbMaxClearTime";
            this.txbMaxClearTime.Size = new System.Drawing.Size(224, 20);
            this.txbMaxClearTime.TabIndex = 8;
            // 
            // txbCleanTime
            // 
            this.txbCleanTime.Location = new System.Drawing.Point(124, 158);
            this.txbCleanTime.Name = "txbCleanTime";
            this.txbCleanTime.Size = new System.Drawing.Size(224, 20);
            this.txbCleanTime.TabIndex = 9;
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
            // lblEmpMail
            // 
            this.lblEmpMail.AutoSize = true;
            this.lblEmpMail.Location = new System.Drawing.Point(7, 72);
            this.lblEmpMail.Name = "lblEmpMail";
            this.lblEmpMail.Size = new System.Drawing.Size(32, 13);
            this.lblEmpMail.TabIndex = 1;
            this.lblEmpMail.Text = "Mail :";
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Location = new System.Drawing.Point(6, 99);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(60, 13);
            this.lblEmpPhone.TabIndex = 2;
            this.lblEmpPhone.Text = "TelefonNr :";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Location = new System.Drawing.Point(6, 128);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(57, 13);
            this.lblEmpAddress.TabIndex = 3;
            this.lblEmpAddress.Text = "Addresse :";
            // 
            // lblEmpZipcode
            // 
            this.lblEmpZipcode.AutoSize = true;
            this.lblEmpZipcode.Location = new System.Drawing.Point(6, 158);
            this.lblEmpZipcode.Name = "lblEmpZipcode";
            this.lblEmpZipcode.Size = new System.Drawing.Size(71, 13);
            this.lblEmpZipcode.TabIndex = 4;
            this.lblEmpZipcode.Text = "Postnummer :";
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
            // cobEmployeeName
            // 
            this.cobEmployeeName.FormattingEnabled = true;
            this.cobEmployeeName.Location = new System.Drawing.Point(113, 42);
            this.cobEmployeeName.Name = "cobEmployeeName";
            this.cobEmployeeName.Size = new System.Drawing.Size(249, 21);
            this.cobEmployeeName.TabIndex = 5;
            this.cobEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cobEmployeeName_SelectedIndexChanged);
            // 
            // lblFillEmpMail
            // 
            this.lblFillEmpMail.AutoSize = true;
            this.lblFillEmpMail.Location = new System.Drawing.Point(110, 69);
            this.lblFillEmpMail.Name = "lblFillEmpMail";
            this.lblFillEmpMail.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpMail.TabIndex = 6;
            // 
            // lblFillEmpPhone
            // 
            this.lblFillEmpPhone.AutoSize = true;
            this.lblFillEmpPhone.Location = new System.Drawing.Point(113, 101);
            this.lblFillEmpPhone.Name = "lblFillEmpPhone";
            this.lblFillEmpPhone.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpPhone.TabIndex = 7;
            // 
            // lblFillEmpAddress
            // 
            this.lblFillEmpAddress.AutoSize = true;
            this.lblFillEmpAddress.Location = new System.Drawing.Point(113, 131);
            this.lblFillEmpAddress.Name = "lblFillEmpAddress";
            this.lblFillEmpAddress.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpAddress.TabIndex = 8;
            // 
            // lblFillEmpZipcode
            // 
            this.lblFillEmpZipcode.AutoSize = true;
            this.lblFillEmpZipcode.Location = new System.Drawing.Point(116, 158);
            this.lblFillEmpZipcode.Name = "lblFillEmpZipcode";
            this.lblFillEmpZipcode.Size = new System.Drawing.Size(0, 13);
            this.lblFillEmpZipcode.TabIndex = 9;
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
    }
}