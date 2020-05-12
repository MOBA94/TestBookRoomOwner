namespace MAPMAClient.GUI
{
    partial class CreateEscapeRoom
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMaxClearTime = new System.Windows.Forms.Label();
            this.lblCleanTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorImage = new System.Windows.Forms.Label();
            this.lblErrorEmployee = new System.Windows.Forms.Label();
            this.lblErrorPrice = new System.Windows.Forms.Label();
            this.lblErrorCleanTime = new System.Windows.Forms.Label();
            this.lblErrorMaxClearTime = new System.Windows.Forms.Label();
            this.lblErrorDesciption = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.btnFindPicture = new System.Windows.Forms.Button();
            this.pbEscaperoom = new System.Windows.Forms.PictureBox();
            this.btnDeleteEscapeRoom = new System.Windows.Forms.Button();
            this.btnCreateEscapeRoom = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCleanTime = new System.Windows.Forms.TextBox();
            this.txtMaxClearTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.escapeRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.escapeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackCreateEscapeRoom = new System.Windows.Forms.Button();
            this.escapeRoomServicesClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscaperoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomServicesClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Navn :";
            this.lblName.UseMnemonic = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Beskrivelse :";
            // 
            // lblMaxClearTime
            // 
            this.lblMaxClearTime.AutoSize = true;
            this.lblMaxClearTime.Location = new System.Drawing.Point(6, 153);
            this.lblMaxClearTime.Name = "lblMaxClearTime";
            this.lblMaxClearTime.Size = new System.Drawing.Size(118, 13);
            this.lblMaxClearTime.TabIndex = 3;
            this.lblMaxClearTime.Text = "Max gennemførsels tid :";
            // 
            // lblCleanTime
            // 
            this.lblCleanTime.AutoSize = true;
            this.lblCleanTime.Location = new System.Drawing.Point(6, 193);
            this.lblCleanTime.Name = "lblCleanTime";
            this.lblCleanTime.Size = new System.Drawing.Size(76, 13);
            this.lblCleanTime.TabIndex = 4;
            this.lblCleanTime.Text = "Klargøringstid :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 237);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Pris :";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(6, 279);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(112, 13);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Medarbejder nummer :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorImage);
            this.groupBox1.Controls.Add(this.lblErrorEmployee);
            this.groupBox1.Controls.Add(this.lblErrorPrice);
            this.groupBox1.Controls.Add(this.lblErrorCleanTime);
            this.groupBox1.Controls.Add(this.lblErrorMaxClearTime);
            this.groupBox1.Controls.Add(this.lblErrorDesciption);
            this.groupBox1.Controls.Add(this.lblErrorName);
            this.groupBox1.Controls.Add(this.btnFindPicture);
            this.groupBox1.Controls.Add(this.pbEscaperoom);
            this.groupBox1.Controls.Add(this.btnDeleteEscapeRoom);
            this.groupBox1.Controls.Add(this.btnCreateEscapeRoom);
            this.groupBox1.Controls.Add(this.txbDescription);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtCleanTime);
            this.groupBox1.Controls.Add(this.txtMaxClearTime);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblMaxClearTime);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.lblCleanTime);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 566);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblErrorImage
            // 
            this.lblErrorImage.AutoSize = true;
            this.lblErrorImage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorImage.Location = new System.Drawing.Point(225, 349);
            this.lblErrorImage.Name = "lblErrorImage";
            this.lblErrorImage.Size = new System.Drawing.Size(71, 13);
            this.lblErrorImage.TabIndex = 26;
            this.lblErrorImage.Text = "Mangler input";
            this.lblErrorImage.Visible = false;
            // 
            // lblErrorEmployee
            // 
            this.lblErrorEmployee.AutoSize = true;
            this.lblErrorEmployee.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmployee.Location = new System.Drawing.Point(133, 299);
            this.lblErrorEmployee.Name = "lblErrorEmployee";
            this.lblErrorEmployee.Size = new System.Drawing.Size(71, 13);
            this.lblErrorEmployee.TabIndex = 25;
            this.lblErrorEmployee.Text = "Mangler input";
            this.lblErrorEmployee.Visible = false;
            // 
            // lblErrorPrice
            // 
            this.lblErrorPrice.AutoSize = true;
            this.lblErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrice.Location = new System.Drawing.Point(133, 260);
            this.lblErrorPrice.Name = "lblErrorPrice";
            this.lblErrorPrice.Size = new System.Drawing.Size(71, 13);
            this.lblErrorPrice.TabIndex = 24;
            this.lblErrorPrice.Text = "Mangler input";
            this.lblErrorPrice.Visible = false;
            // 
            // lblErrorCleanTime
            // 
            this.lblErrorCleanTime.AutoSize = true;
            this.lblErrorCleanTime.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCleanTime.Location = new System.Drawing.Point(133, 218);
            this.lblErrorCleanTime.Name = "lblErrorCleanTime";
            this.lblErrorCleanTime.Size = new System.Drawing.Size(71, 13);
            this.lblErrorCleanTime.TabIndex = 23;
            this.lblErrorCleanTime.Text = "Mangler input";
            this.lblErrorCleanTime.Visible = false;
            // 
            // lblErrorMaxClearTime
            // 
            this.lblErrorMaxClearTime.AutoSize = true;
            this.lblErrorMaxClearTime.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMaxClearTime.Location = new System.Drawing.Point(133, 174);
            this.lblErrorMaxClearTime.Name = "lblErrorMaxClearTime";
            this.lblErrorMaxClearTime.Size = new System.Drawing.Size(71, 13);
            this.lblErrorMaxClearTime.TabIndex = 22;
            this.lblErrorMaxClearTime.Text = "Mangler input";
            this.lblErrorMaxClearTime.Visible = false;
            // 
            // lblErrorDesciption
            // 
            this.lblErrorDesciption.AutoSize = true;
            this.lblErrorDesciption.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDesciption.Location = new System.Drawing.Point(133, 134);
            this.lblErrorDesciption.Name = "lblErrorDesciption";
            this.lblErrorDesciption.Size = new System.Drawing.Size(71, 13);
            this.lblErrorDesciption.TabIndex = 21;
            this.lblErrorDesciption.Text = "Mangler input";
            this.lblErrorDesciption.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(133, 39);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(71, 13);
            this.lblErrorName.TabIndex = 20;
            this.lblErrorName.Text = "Mangler input";
            this.lblErrorName.Visible = false;
            // 
            // btnFindPicture
            // 
            this.btnFindPicture.Location = new System.Drawing.Point(228, 323);
            this.btnFindPicture.Name = "btnFindPicture";
            this.btnFindPicture.Size = new System.Drawing.Size(107, 23);
            this.btnFindPicture.TabIndex = 19;
            this.btnFindPicture.Text = "Find billede";
            this.btnFindPicture.UseVisualStyleBackColor = true;
            this.btnFindPicture.Click += new System.EventHandler(this.btnFindPicture_Click);
            // 
            // pbEscaperoom
            // 
            this.pbEscaperoom.Location = new System.Drawing.Point(6, 323);
            this.pbEscaperoom.Name = "pbEscaperoom";
            this.pbEscaperoom.Size = new System.Drawing.Size(200, 200);
            this.pbEscaperoom.TabIndex = 18;
            this.pbEscaperoom.TabStop = false;
            // 
            // btnDeleteEscapeRoom
            // 
            this.btnDeleteEscapeRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteEscapeRoom.Location = new System.Drawing.Point(127, 529);
            this.btnDeleteEscapeRoom.Name = "btnDeleteEscapeRoom";
            this.btnDeleteEscapeRoom.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteEscapeRoom.TabIndex = 1;
            this.btnDeleteEscapeRoom.Text = "Slet";
            this.btnDeleteEscapeRoom.UseVisualStyleBackColor = false;
            this.btnDeleteEscapeRoom.Click += new System.EventHandler(this.btnDeleteEscapeRoom_Click);
            // 
            // btnCreateEscapeRoom
            // 
            this.btnCreateEscapeRoom.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCreateEscapeRoom.Location = new System.Drawing.Point(228, 529);
            this.btnCreateEscapeRoom.Name = "btnCreateEscapeRoom";
            this.btnCreateEscapeRoom.Size = new System.Drawing.Size(107, 23);
            this.btnCreateEscapeRoom.TabIndex = 15;
            this.btnCreateEscapeRoom.Text = "Opret";
            this.btnCreateEscapeRoom.UseVisualStyleBackColor = false;
            this.btnCreateEscapeRoom.Click += new System.EventHandler(this.btnCreateEscapeRoom_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(127, 60);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(208, 78);
            this.txbDescription.TabIndex = 14;
            this.txbDescription.Text = "";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(127, 276);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(208, 20);
            this.txtEmployeeID.TabIndex = 13;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(127, 234);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 20);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtCleanTime
            // 
            this.txtCleanTime.Location = new System.Drawing.Point(127, 190);
            this.txtCleanTime.Name = "txtCleanTime";
            this.txtCleanTime.Size = new System.Drawing.Size(208, 20);
            this.txtCleanTime.TabIndex = 11;
            this.txtCleanTime.TextChanged += new System.EventHandler(this.txtCleanTime_TextChanged);
            // 
            // txtMaxClearTime
            // 
            this.txtMaxClearTime.Location = new System.Drawing.Point(127, 150);
            this.txtMaxClearTime.Name = "txtMaxClearTime";
            this.txtMaxClearTime.Size = new System.Drawing.Size(208, 20);
            this.txtMaxClearTime.TabIndex = 10;
            this.txtMaxClearTime.TextChanged += new System.EventHandler(this.txtMaxClearTime_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 566);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 541);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // escapeRoomBindingSource1
            // 
            this.escapeRoomBindingSource1.DataSource = typeof(MAPMAClient.EscRef.EscapeRoom);
            // 
            // escapeRoomBindingSource
            // 
            this.escapeRoomBindingSource.DataSource = typeof(MAPMAClient.EscRef.EscapeRoom);
            // 
            // btnBackCreateEscapeRoom
            // 
            this.btnBackCreateEscapeRoom.BackColor = System.Drawing.Color.Gray;
            this.btnBackCreateEscapeRoom.Location = new System.Drawing.Point(1082, 584);
            this.btnBackCreateEscapeRoom.Name = "btnBackCreateEscapeRoom";
            this.btnBackCreateEscapeRoom.Size = new System.Drawing.Size(75, 23);
            this.btnBackCreateEscapeRoom.TabIndex = 12;
            this.btnBackCreateEscapeRoom.Text = "Tilbage";
            this.btnBackCreateEscapeRoom.UseVisualStyleBackColor = false;
            this.btnBackCreateEscapeRoom.Click += new System.EventHandler(this.btnBackCreateEscapeRoom_Click);
            // 
            // escapeRoomServicesClientBindingSource
            // 
            this.escapeRoomServicesClientBindingSource.DataSource = typeof(MAPMAClient.EscRef.EscapeRoom_ServicesClient);
            // 
            // checkListBindingSource
            // 
            this.checkListBindingSource.DataMember = "checkList";
            this.checkListBindingSource.DataSource = this.escapeRoomBindingSource1;
            // 
            // CreateEscapeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 616);
            this.Controls.Add(this.btnBackCreateEscapeRoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateEscapeRoom";
            this.Text = "Opret Escaperoom";
            this.Load += new System.EventHandler(this.CreateEscapeRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscaperoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomServicesClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMaxClearTime;
        private System.Windows.Forms.Label lblCleanTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateEscapeRoom;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCleanTime;
        private System.Windows.Forms.TextBox txtMaxClearTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource escapeRoomBindingSource;
        private System.Windows.Forms.Button btnBackCreateEscapeRoom;
        private System.Windows.Forms.BindingSource escapeRoomBindingSource1;
        private System.Windows.Forms.Button btnDeleteEscapeRoom;
        private System.Windows.Forms.BindingSource escapeRoomServicesClientBindingSource;
        private System.Windows.Forms.BindingSource checkListBindingSource;
        private System.Windows.Forms.Button btnFindPicture;
        private System.Windows.Forms.PictureBox pbEscaperoom;
        private System.Windows.Forms.Label lblErrorEmployee;
        private System.Windows.Forms.Label lblErrorPrice;
        private System.Windows.Forms.Label lblErrorCleanTime;
        private System.Windows.Forms.Label lblErrorMaxClearTime;
        private System.Windows.Forms.Label lblErrorDesciption;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorImage;
    }
}